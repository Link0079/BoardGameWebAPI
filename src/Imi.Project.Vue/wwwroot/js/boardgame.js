var boardGameApp = new Vue({
    el: '#boardGameApp',
    data: {
        playerRole: sessionStorage.getItem("sessionPlayerRole"),
        isAuthorized: false,
        loading: true,
        boardgames: [],
        currentBoardGame: null,
        selectedCategories: [],
        selectedArtists: [],
        allCategories: [],
        allArtists: [],
        hasError: false,
        hasSuccess: false,
        isAdmin: false,
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
        CreateNewBoardGame:
            function () {
                console.log("Create");
            },
        EditBoardGame:
            function () {
                console.log("Edit");
            },
        SaveBoardGame:
            function () {
                console.log("Save");
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
                self.currentBoardGame = boardGame;
                self.FetchCategories();
                self.FetchArtists();
                //self.selectedCategories = boardGame.categories;
                self.IsPlayerAuthorizedBoardGames();
                //self.GetCurrentBoardGameCategories();
            }
    }
});
