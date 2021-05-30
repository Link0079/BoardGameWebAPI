var boardGameApp = new Vue({
    el: '#boardGameApp',
    data: {
        playerRole: sessionStorage.getItem("sessionPlayerRole"),
        isAuthorized: false,
        isAdmin: false,
        loading: true,
        boardgames: [],
        allCategories: [],
        allArtists: [],
        currentBoardGame: null,
        selectedCategories: [],
        selectedArtists: [],
        apiMessageInfo: "",
        isDisabled: true,
        isActive: true,
        hasError: false,
        hasSuccess: false,
        editBoardGame: false,
        boardgamesCount: 0,

    },
    created:
        function () {
            let self = this;
            self.FetchBoardGames();
            console.log(self.boardgames.length);
            self.IsPlayerAuthorizedBoardGames();
        },
    methods: {
        FetchBoardGames:
            function () {
                let self = this;
                axios
                    .get(`${boardGameApiURL}`)
                    .then(function (response) {
                        self.boardgames = response.data;
                        self.loading = true;
                        self.boardgamesCount = response.data.length;
                    })
                    .catch(function (error) {
                        console.error(error);
                    })
                    .finally(function () {
                        setTimeout(function () {
                            self.loading = false;

                        }, 1000);
                    });
            },
        FetchCategories:
            function () {
                let self = this;
                axios.get(`${categoriesApiURL}`, axiosBoardGameConfig)
                    .then(function (response) {
                        self.allCategories = response.data;
                    })
                    .catch(function (error) {
                        console.log(error);
                    });
            },
        FetchArtists:
            function () {
                let self = this;
                axios.get(`${artistsApiURL}`, axiosBoardGameConfig)
                    .then(function (response) {
                        self.allArtists = response.data;
                    })
                    .catch(function (error) {
                        console.log(error);
                    });
            },
        EditBoardGame:
            function (editBoardGame) {
                let self = this;
                self.editBoardGame = editBoardGame;
                self.isDisabled = false;
                if (!self.editBoardGame) {
                    self.currentBoardGame = {
                        id: createGuid(),
                        title: "",
                        stock: false,
                        playTime: "",
                        photoUrl: "",
                        description: "",
                        isDeleted: false,
                }
                    console.log("Create new Boardgame");
                }
            },
        SaveBoardGame:
            function () {
                let self = this;
                let stock = self.currentBoardGame.stock;
                let isDeleted = self.currentBoardGame.isDeleted;
                self.currentBoardGame.stock = (stock === "true") ? true : false;
                self.currentBoardGame.isDeleted = (isDeleted === "true") ? true : false;
                if (!self.editBoardGame) {
                    console.log("Create");
                    self.PostBoardGame();
                    self.selectedCategories.forEach(function (id) {
                        setTimeout(function () { self.PostBoarGameCategories(id); }, 2000);
                    });
                    self.selectedArtists.forEach(function (id) {
                        setTimeout(function () { self.PostBoardGameArtists(id); }, 2000);
                    });
                }
                else {
                    console.log("Edit");
                    self.PutBoardGame();
                    self.selectedCategories.forEach(function (id) {
                        setTimeout(function () { self.PostBoarGameCategories(id); }, 2000);
                    });
                    self.selectedArtists.forEach(function (id) {
                        setTimeout(function () { self.PostBoardGameArtists(id); }, 2000);
                    });
                }
            },
        PostBoardGame:
            function() {
                let self = this;
                let postBoardGameUrl = `${boardGameApiURL}`;
                axios.post(postBoardGameUrl, self.currentBoardGame, axiosBoardGameConfig)
                    .then(function (response) {
                        self.isDisabled = true;
                        self.hasSuccess = true;
                        self.apiMessageInfo = `Boardgame with id '${self.currentBoardGame.id}' has been created. Refresh page.!!`
                    })
                    .catch(function (error) {
                        console.log(error);
                        self.hasError = true;
                        self.apiMessageInfo = "Creating new boardgame Failed, check all values!";
                    })
                    .finally(function () {
                        setTimeout(function () {
                            self.hasSuccess = false;
                            self.hasError = false;
                        }, 2000)
                    });
            },
        PutBoardGame:
            function () {
                let self = this;
                let putBoardGameUrl = `${boardGameApiURL}`;
                axios.put(putBoardGameUrl, self.currentBoardGame, axiosBoardGameConfig)
                    .then(function (response) {
                        self.isDisabled = true;
                        self.hasSuccess = true;
                        self.apiMessageInfo = `Boardgame with id '${self.currentBoardGame.id}' has been updated. Refresh page.!!`
                    })
                    .catch(function (error) {
                        console.log(error);
                        self.hasError = true;
                        self.apiMessageInfo = `There was a conflict with updating boardgame with id '${self.currentBoardGame.id}'!`;
                    })
                    .finally(function () {
                        setTimeout(function () {
                            self.hasSuccess = false;
                            self.hasError = false;
                        }, 2000)
                    });
            },
        PostBoarGameCategories:
            function(categoryId) {
                let self = this;
                let postBoardGameCategoryUrl = `${boardGameApiURL}/${self.currentBoardGame.id}/Categories/${categoryId}`;
                axios.post(postBoardGameCategoryUrl, [self.currentBoardGame.id, categoryId], axiosBoardGameConfig)
                    .then(function (response) {
                        console.log("Category was added to BoardGame");
                    })
                    .catch(function (error) {
                        console.log(error);
                    });
            },
        PostBoardGameArtists:
            function (artistId) {
                let self = this;
                let postBoardGameArtistUrl = `${boardGameApiURL}/${self.currentBoardGame.id}/Artists/${artistId}`;
                axios.post(postBoardGameArtistUrl, [self.currentBoardGame.id, artistId], axiosBoardGameConfig)
                    .then(function (response) {
                        console.log("Artist was added to Boardgame.");
                    })
                    .catch(function (error) {
                        console.log(error);
                    });
            },
        DeleteBoardGame:
            function () {
                let self = this;
                let deleteBoardGameUrl = `${boardGameApiURL}/${self.currentBoardGame.id}`;
                axios.delete(deleteBoardGameUrl, axiosBoardGameConfig)
                    .then(function (response) {
                        self.apiMessageInfo = response.data;
                        self.hasSuccess = true;
                    })
                    .catch(function (error) {
                        console.log(error);
                        self.apiMessageInfo = error;
                        self.hasError = true;
                    })
                    .finally(function () {
                        setTimeout(function () {
                            self.hasSuccess = false;
                            self.hasError = false;
                        }, 2500);
                    });
            },
        IsPlayerAuthorizedBoardGames:
            function () {
                let self = this;
                switch (self.playerRole) {
                    case "Admin":
                        self.isAuthorized = true;
                        self.isAdmin = true;
                        break;
                    case "BoardGameEditor":
                        self.isAuthorized = true;
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
        IsInStock:
            function (boardGame) {
                let self = this;
                if (boardGame.stock == "True") {
                    return "badge badge-success";
                }
                else {
                    return "text-hide";
                }
            },
        GetBoardGameDetails:
            function (boardGame) {
                let self = this;
                self.isDisabled = true;
                self.currentBoardGame = boardGame;
                self.FetchCategories();
                self.FetchArtists();
            }
    }
});
