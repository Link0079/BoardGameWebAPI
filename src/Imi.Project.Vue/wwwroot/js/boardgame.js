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
        isDisabled: true,
        isActive: true,
        hasError: false,
        hasSuccess: false,
        editBoardGame: false,

    },
    created:
        function () {
            let self = this;
            self.FetchBoardGames();
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
        EditBoardGame:
            function (editBoardGame) {
                let self = this;
                self.editBoardGame = editBoardGame;
                self.isDisabled = false;
                if (!self.editBoardGame) {
                    function createGuid() {
                        return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function (c) {
                            var r = Math.random() * 16 | 0, v = c === 'x' ? r : (r & 0x3 | 0x8);
                            return v.toString(16);
                        });
                    }

                    self.currentBoardGame = {
                        id: createGuid(),
                        title: "",
                        price: 0,
                        stock: false,
                        minPlayers: 0,
                        maxPlayers: 0,
                        age: 0,
                        year: 2000,
                        rating: 0,
                        playTime: "0",
                        photoUrl: "",
                        description: "",
                        isDeleted: false,
                }
                    console.log("Create new Boardgame");
                }
                else {
                    console.log("Edit old BoardGame");
                }
            },
        SaveBoardGame:
            function () {
                let self = this;
                console.log("Save");
                if (!self.editBoardGame) {
                    console.log("Create");
                    let postBoardGameUrl = `${boardGameApiURL}`;
                    let stock = self.currentBoardGame.stock;
                    if (stock === "true") {
                        self.currentBoardGame.stock = true;
                    }
                    else {
                        self.currentBoardGame.stock = false;
                    }
                    axios.post(postBoardGameUrl, self.currentBoardGame, axiosBoardGameConfig)
                        .then(function (response) {
                            console.log(response.data);
                            //self.currentBoardGame = response.data;
                            self.isDisabled = true;

                        })
                        .catch(function (error) {
                            console.log(error);
                        });
                }
                else {
                    console.log("Edit");
                }

            },
        DeleteBoardGame:
            function () {
                let self = this;
                let deleteBoardGameUrl = `${boardGameApiURL}/${self.currentBoardGame.id}`;
                axios.delete(deleteBoardGameUrl, axiosBoardGameConfig)
                    .then(function (response) {
                        console.log(response.data);
                        self.apiErrorInfo = response.data;
                        self.hasSuccess = true;
                        console.log("Delete");
                    })
                    .catch(function (error) {
                        console.log(error);
                        self.apiErrorInfo = error;
                        self.hasError = true;
                        console.log("Failed at Delete");
                    })
                    .finally(function () {
                        setTimeout(function () {
                            self.hasSuccess = false;
                            self.hasError = false;
                        }, 2500);
                    });
            },
        SetCssApiInfo:
            function (hasInfo) {
                switch (hasInfo) {
                    case "response":
                        return "alert-success";
                        break;
                    case "error":
                        return "alert-danger";
                        break;
                    default:
                }
            },


        GetBoardGameDetails:
            function (boardGame) {
                let self = this;
                self.isDisabled = true;
                self.currentBoardGame = boardGame;
                self.FetchCategories();
                self.FetchArtists();
                self.IsPlayerAuthorizedBoardGames();
            }
    }
});
