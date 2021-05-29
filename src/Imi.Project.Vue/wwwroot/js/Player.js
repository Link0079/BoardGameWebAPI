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
        apiErrorInfo: "",
        isDisabled: true,
        hasError: false,
        hasSuccess: false,
        editPlayer: false,
    },
    created:
        function () {
            let self = this;
            self.IsPlayerAuthorizedPlayers();
            if (self.isAuthorized) {
                self.FetchArtists();
            }
            else {
                self.hasError = true;
                self.apiErrorInfo = "You are not Authorized.!!";
            }
        },
    methods: {
        FetchPlayer:
            function () {
                let self = this;
                let playerId = sessionStorage.getItem("sessionPlayerId");
                axios.get(`${playerApiURL}`/`${playerId}`, axiosBoardGameConfig)
                    .then(function (response) {
                        self.artists = response.data;
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
        IsPlayerAuthorizedPlayers:
            function () {
                let self = this;
                switch (self.playerRole) {
                    case "":
                        self.isAuthorized = false;
                        break;
                    case "Admin":
                        self.isAuthorized = true;
                        self.isAdmin = true;
                        break;
                    default:
                        self.isAuthorized = true;
                }
            },
        EditArtist:
            function (editPlayer) {
                let self = this;
                self.editPlayer = editPlayer;
                self.isDisabled = false;
                if (!self.editPlayer) {
                    self.playerToRegister = { email: "", name: "", dob: "" };
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
                        self.isDisabled = true;
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
        DeleteArtist:
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
        GetPlayerDetails:
            function (player) {
                let self = this;
                self.isDisabled = true;
                self.currentPlayer = player;
            },
    },
});
