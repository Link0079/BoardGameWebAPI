var categoryApp = new Vue({
    el: '#categoryApp',
    data: {
        playerRole: sessionStorage.getItem("sessionPlayerRole"),
        isAuthorized: false,
        isAdmin: false,
        loading: false,
        categories: [],
        currentCategory: null,
        apiMessageInfo: "",
        isDisabled: true,
        hasError: false,
        hasSuccess: false,
        editCategory: false,
    },
    created:
        function () {
            let self = this;
            self.IsPlayerAuthorizedCategories();
            if (self.isAuthorized) {
                self.FetchCategories();
            }
            else {
                self.hasError = true;
                self.apiMessageInfo = "Please register or login.";
            }
        },
    methods: {
        FetchCategories:
            function () {
                let self = this;
                axios.get(`${categoriesApiURL}`, axiosBoardGameConfig)
                    .then(function (response) {
                        self.categories = response.data;
                        self.loading = true;
                    })
                    .catch(function (error) {
                        console.log(error.response.data.title);
                    })
                    .finally(function () {
                        setTimeout(function () {
                            self.loading = false;
                        }, 1000)
                    });
            },
        IsPlayerAuthorizedCategories:
            function () {
                let self = this;
                switch (self.playerRole) {
                    case "Admin":
                        self.isAuthorized = true;
                        self.isAdmin = true;
                        break;
                    case "BoardGameEditor":
                        self.isAuthorized = false;
                        break;
                    case "ArtistEditor":
                        self.isAuthorized = false;
                        break;
                    case "Player":
                        self.isAuthorized = false;
                        break;
                    default:
                }
            },
        EditCategory:
            function (editCategory) {
                let self = this;
                self.editCategory = editCategory;
                self.isDisabled = false;
                if (!self.editCategory) {
                    self.currentCategory = {
                        name: ""
                    }
                }
            },
        SaveCategory:
            function () {
                let self = this;
                if (!self.editCategory) {
                    self.PostCategory();
                }
                else {
                    self.PutCategory();
                }
            },
        PostCategory:
            function () {
                let self = this;
                let postCategoryUrl = `${categoriesApiURL}`;
                axios.post(postCategoryUrl, self.currentCategory, axiosBoardGameConfig)
                    .then(function (response) {
                        self.isDisabled = true;
                        self.hasSuccess = true;
                        self.currentCategory = response.data;
                        self.categories.push(self.currentCategory);
                        self.apiMessageInfo = `Boardgame with id '${response.data.id}' has been created. Refresh page.!!`
                    })
                    .catch(function (error) {
                        console.log(error.response.data.title);
                        self.hasError = true;
                        self.apiMessageInfo = `${error.response.data.title} Please check values`;
                    })
                    .finally(function () {
                        setTimeout(function () {
                            self.hasSuccess = false;
                            self.hasError = false;
                        }, 2000)
                    });
            },
        PutCategory:
            function () {
                let self = this;
                let putCategoryUrl = `${categoriesApiURL}`;
                axios.put(putCategoryUrl, self.currentCategory, axiosBoardGameConfig)
                    .then(function (response) {
                        self.isDisabled = true;
                        self.hasSuccess = true;
                        self.apiMessageInfo = `Boardgame with id '${response.data.id}' has been updated. Refresh page.!!`
                    })
                    .catch(function (error) {
                        console.log(error.response.data.title);
                        self.hasError = true;
                        self.apiMessageInfo = `${error.response.data.title} Please check values.`;
                    })
                    .finally(function () {
                        setTimeout(function () {
                            self.hasSuccess = false;
                            self.hasError = false;
                        }, 2000)
                    });
            },
        DeleteCategory:
            function () {
                let self = this;
                let deleteCategoryUrl = `${categoriesApiURL}/${self.currentCategory.id}`;
                axios.delete(deleteCategoryUrl, axiosBoardGameConfig)
                    .then(function (response) {
                        self.apiMessageInfo = response.data;
                        self.categories.forEach(function (category, index) {
                            if (category.id === self.currentCategory.id) {
                                self.categories.splice(index, 1);
                            }
                        });
                        self.currentCategory = null;
                        self.hasSuccess = true;
                    })
                    .catch(function (error) {
                        console.log(error.response.data.title);
                        self.apiMessageInfo = error.response.data.title;
                        self.hasError = true;
                    })
                    .finally(function () {
                        setTimeout(function () {
                            self.hasSuccess = false;
                            self.hasError = false;
                        }, 2500);
                    });
            },
        CancelCategory:
            function () {
                let self = this;
                self.currentCategory = null;
                self.isDisabled = true;
            },
        GetCategoryDetails:
            function (category) {
                let self = this;
                self.isDisabled = true;
                self.currentCategory = category;
            },
    },
});
