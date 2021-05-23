var boardGameApp = new Vue({
    el: '#boardGameApp',
    data: {
        boardgames: null,
        currentBoardGame: null,
        loading: true,
        playerRole: sessionStorage.getItem("sessionPlayerRole"),
        isAuthorized: false,
        deleteResponseInfo: null,
        deleteErrorInfo: "",
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
        IsPlayerAuthorizedBoardGames:
            function () {
                let self = this;
                switch (self.playerRole) {
                    case "Admin":
                        self.isAuthorized = true;
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
                        console.log(response);
                        self.deleteResponseInfo = response;
                        console.log("Delete");
                    })
                    .catch(function (error) {
                        console.log(error);
                        self.deleteErrorInfo = error;
                    })
                    .finally(function () {
                        console.log("Ready With Deletion");
                    });
            },

        GetBoardGameDetails:
            function (boardGame) {
                let self = this;
                self.currentBoardGame = boardGame;
                self.IsPlayerAuthorizedBoardGames();
            }
    }
});
