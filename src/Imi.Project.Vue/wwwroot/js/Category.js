var categoryApp = new Vue({
    el: '#categoryApp',
    data: {
        playerRole: sessionStorage.getItem("sessionPlayerRole"),
        isAuthorized: false,
        isAdmin: false,
        loading: false,
        categories: [],
        currentCategory: null,
        apiErrorInfo: "",
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
                self.apiErrorInfo = "You are not Authorized.!!";
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
                        console.log(error);
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
                        id: createGuid(),
                        name: "",
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
                        self.categories.push(self.currentCategory);
                        self.apiErrorInfo = `Boardgame with id '${self.currentCategory.id}' has been created. Refresh page.!!`
                    })
                    .catch(function (error) {
                        console.log(error);
                        self.hasError = true;
                        self.apiErrorInfo = "Creating new boardgame Failed, check all values!";
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
                        self.apiErrorInfo = `Boardgame with id '${self.currentCategory.id}' has been updated. Refresh page.!!`
                    })
                    .catch(function (error) {
                        console.log(error);
                        self.hasError = true;
                        self.apiErrorInfo = `There was a conflict with updating category with id '${self.currentCategory.id}'!`;
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
                        self.apiErrorInfo = response.data;
                        self.categories.forEach(function (category, index) {
                            if (category.id === self.currentCategory.id) {
                                self.categories.splice(index, 1);
                            }
                        });
                        self.hasSuccess = true;
                    })
                    .catch(function (error) {
                        console.log(error);
                        self.apiErrorInfo = error;
                        self.hasError = true;
                    })
                    .finally(function () {
                        setTimeout(function () {
                            self.hasSuccess = false;
                            self.hasError = false;
                        }, 2500);
                    });
            },
        GetCategoryDetails:
            function (category) {
                let self = this;
                self.isDisabled = true;
                self.currentCategory = category;
            },
    },
});
