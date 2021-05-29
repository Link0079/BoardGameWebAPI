var playerApp = new Vue({
    el: '#playerApp',
    data: {
        playerRole: sessionStorage.getItem("sessionPlayerRole"),
        playerId: sessionStorage.getItem("sessionPlayerId"),
        isAuthorized: false,
        isAdmin: false,
        loading: false,
        players: [],
        currentPlayer: null,
        playedGames: [],
        currentPlayedGame: null,
        apiErrorInfo: "",
        isDisabledPlayer: true,
        hasPlayedGames: false,
        hasError: false,
        hasSuccess: false,
        editPlayer: false,
    },
    created:
        function () {
            let self = this;
            self.IsPlayerAuthorizedPlayers();
            if (self.isAuthorized) {
                self.FetchCurrentPlayer();
                self.FetchCurrentPlayerPlayedGames();
            }
            else {
                self.hasError = true;
                self.apiErrorInfo = "Please register or login.";
            }
        },
    methods: {
        FetchCurrentPlayer:
            function () {
                let self = this;
                let playerId = sessionStorage.getItem("sessionPlayerId");
                axios.get(`${playerApiURL}/${playerId}`, axiosBoardGameConfig)
                    .then(function (response) {
                        self.currentPlayer = response.data;
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
        FetchCurrentPlayerPlayedGames:
            function () {
                let self = this;
                let playerId = sessionStorage.getItem("sessionPlayerId");
                axios.get(`${playerApiURL}/${playerId}/playedgames`, axiosBoardGameConfig)
                    .then(function (response) {
                        self.playedGames = response.data;
                        self.hasPlayedGames = true;
                    })
                    .catch(function (error) {
                        console.log(error.response);
                        self.hasPlayedGames = false;
                    });
            },
        IsPlayerAuthorizedPlayers:
            function () {
                let self = this;
                console.log(self.playerRole);
                switch (self.playerRole) {
                    case "Admin":
                        self.isAuthorized = true;
                        self.isAdmin = true;
                        break;
                    case "BoardGameEditor":
                        self.isAuthorized = true;
                        break;
                    case "ArtistEditor":
                        self.isAuthorized = true;
                        break;
                    case "Player":
                        self.isAuthorized = true;
                        break;
                    default:
                        self.isAuthorized = false;
                }
            },
        EditPlayer:
            function (editPlayer) {
                let self = this;
                self.editPlayer = editPlayer;
                self.isDisabledPlayer = false;
                if (!self.editPlayer) {
                    self.editPlayer = { email: "", name: "", dob: "" };
                }
            },
        SavePlayer:
            function () {
                let self = this;
                self.PutPlayer();
            },
        PutPlayer:
            function () {
                let self = this;
                let putPlayersUrl = `${playerApiURL}`;
                axios.put(putPlayersUrl, self.currentPlayer, axiosBoardGameConfig)
                    .then(function (response) {
                        self.isDisabledPlayer = true;
                        self.hasSuccess = true;
                        self.apiErrorInfo = `Player with id '${playerId}' has been updated. Refresh page.!!`
                    })
                    .catch(function (error) {
                        console.log(error);
                        self.hasError = true;
                        self.apiErrorInfo = `There was a conflict with updating player with id '${playerId}'!`;
                    })
                    .finally(function () {
                        setTimeout(function () {
                            self.hasSuccess = false;
                            self.hasError = false;
                        }, 2000)
                    });
            },
        DeletePlayer:
            function () {
                let self = this;
                let deletePlayersUrl = `${playerApiURL}/${playerId}`;
                axios.delete(deletePlayersUrl, axiosBoardGameConfig)
                    .then(function (response) {
                        self.apiErrorInfo = response.data;
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
        GetPlayedGameDetails:
            function (playedGame) {
                let self = this;
                self.isDisabledPlayer = true;
                self.currentPlayedGame = playedGame;
                console.log(self.currentPlayedGame);
            },
    },
});
