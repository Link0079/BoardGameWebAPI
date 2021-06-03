var playerApp = new Vue({
    el: '#playerApp',
    data: {
        playerRole: sessionStorage.getItem("sessionPlayerRole"),
        playerId: sessionStorage.getItem("sessionPlayerId"),
        isAuthorized: false,
        isAdmin: false,
        loading: false,
        players: [],
        boardGames: [],
        playedGames: [],
        selectedPlayer: [],
        selectedGameScore: [],
        selectedPlayTime: 0,
        numberOfPlayers: 0,
        selectedBoardGame: null,
        currentPlayer: null,
        currentPlayedGame: null,
        isDisabledPlayer: true,
        isDisabledGameScore: true,
        isDisabledPlayerAdmin: true,
        isByPlayedGameDetails: true,
        seePlayedGames: false,
        seeProfile: true,
        seeAdminArea: false,
        apiMessageInfo: "",
        hasError: false,
        hasSuccess: false,
        hasPlayedGames: false,
        editPlayer: false,
    },
    created:
        function () {
            let self = this;
            self.IsPlayerAuthorizedPlayers();
            if (self.isAuthorized) {
                self.FetchCurrentPlayer();
                self.FetchCurrentPlayerPlayedGames();
                self.FetchPlayers();
                self.FetchBoardGames();
            }
            else {
                self.hasError = true;
                self.apiMessageInfo = "Please register or login.";
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
                let playerIdApiUrl = `${playerApiURL}/${playerId}/playedgames`;
                axios.get(playerIdApiUrl, axiosBoardGameConfig)
                    .then(function (response) {
                        self.playedGames = response.data;
                        self.hasPlayedGames = true;
                    })
                    .catch(function (error) {
                        console.log(error.response);
                        self.hasPlayedGames = false;
                    });
            },
        FetchPlayers:
            function () {
                let self = this;
                axios.get(`${playerApiURL}`, axiosBoardGameConfig)
                    .then(function (response) {
                        self.players = response.data;
                    })
                    .catch(function (error) {
                        console.log(error);
                    })
            },
        FetchBoardGames:
            function () {
                let self = this;
                axios.get(`${boardGameApiURL}`, axiosBoardGameConfig)
                    .then(function (response) {
                        self.boardGames = response.data;
                    })
                    .catch(function (error) {
                        console.log(error);
                    });
            },
        IsPlayerAuthorizedPlayers:
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
                        self.apiMessageInfo = `Player with id '${self.currentPlayer.id}' has been updated. Refresh page.!!`
                    })
                    .catch(function (error) {
                        console.log(error);
                        self.hasError = true;
                        self.apiMessageInfo = `There was a conflict with updating player with id '${self.currentPlayer.id}'!`;
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
                let deletePlayersUrl = `${playerApiURL}/${self.currentPlayer.id}`;
                axios.delete(deletePlayersUrl, axiosBoardGameConfig)
                    .then(function (response) {
                        self.apiMessageInfo = "Player has been deleted";
                        self.hasSuccess = true;
                    })
                    .catch(function (error) {
                        console.log(error.response);
                        self.apiMessageInfo = error;
                        self.hasError = true;
                    })
                    .then(function () {
                        setTimeout(function () {
                            self.hasSuccess = false;
                            self.hasError = false;
                            window.location.href = "/home";
                            sessionStorage.clear();
                        }, 2500);
                    });
            },
        SeeArea:
            function (area) {
                let self = this;
                switch (area) {
                    case "PlayedGames":
                        self.seePlayedGames = true;
                        self.seeProfile = false;
                        self.seeAdminArea = false;
                        break;
                    case "Profile":
                        self.seePlayedGames = false;
                        self.seeProfile = true;
                        self.seeAdminArea = false;
                        break;
                    case "AdminArea":
                        self.seePlayedGames = false;
                        self.seeProfile = false;
                        self.seeAdminArea = true;
                        break;
                    default:
                }
            },
        EditPlayedGame:
            function () {
                let self = this;
                self.isByPlayedGameDetails = false;
                self.currentPlayedGame = {boardGameTitle: "", gameScores: [], id: "", playerCount: 0, playTime: 0};
                self.isDisabledGameScore = false;
            },
        SavePlayedGame:
            function () {
                let self = this;
                self.PostPlayedGame();
            },
        PostPlayedGame:
            function () {
                let self = this;
                let playedGameRequestDto = { id: createGuid() ,playTime: 0 , boardGameId: self.selectedBoardGame.id, gameScores: [] };
                playedGameRequestDto.playTime = self.selectedPlayTime;
                self.selectedPlayer.forEach(function (playerId, index) {
                    let score = self.selectedGameScore[index] == null ? 0 : Number(self.selectedGameScore[index]);
                    let playerScore = { playerId: "", score: 0 };
                    playerScore.playerId = playerId;
                    playerScore.score = score;
                    playedGameRequestDto.gameScores.push(playerScore);
                });
                let postPlayedGameApiUrl = `${playedGamesApiURL}`;
                axios.post(postPlayedGameApiUrl, playedGameRequestDto, axiosBoardGameConfig)
                    .then(function (response) {
                        self.playedGames.push(response.data);
                        self.apiMessageInfo = "Played game has been created. Please refresh page.!!";
                        self.hasSuccess = true;
                    })
                    .catch(function (error) {
                        console.log(error.response);
                        self.apiMessageInfo = error;
                        self.hasError = true;
                    })
                    .then(function () {
                        setTimeout(function () {
                            self.hasSuccess = false;
                            self.hasError = false;
                            self.ClearSelectedBoardGame();
                        }, 2500);
                    });
            },
        PutPlayedGame:
            function () {

            },
        DeletePlayedGame:
            function () {
                let self = this;
                let deletePlayedGameUrl = `${playedGamesApiURL}/${self.currentPlayedGame.id}`;
                axios.delete(deletePlayedGameUrl, axiosBoardGameConfig)
                    .then(function (response) {
                        self.apiMessageInfo = response.data;
                        self.playedGames.forEach(function (playedGame, index) {
                            if (playedGame.id === self.currentPlayedGame.id) {
                                self.playedGames.splice(index, 1);
                            }
                        });
                        self.hasSuccess = true;
                    })
                    .catch(function (error) {
                        console.log(error);
                        self.apiMessageInfo = error;
                        self.hasError = true;
                    })
                    .finally(function () {
                        setTimeout(function () {
                            self.hasError = false;
                            self.hasSuccess = false;
                        }, 2500);
                    });
            },
        GetPlayedGameDetails:
            function (playedGame) {
                let self = this;
                self.isDisabledGameScore = true;
                self.currentPlayedGame = playedGame;
                self.isByPlayedGameDetails = true;
            },
        GetPlayerDetails:
            function (player) {
                let self = this;
                self.isDisabledPlayerAdmin = true;
                self.currentPlayer = player;
            },
        ClearSelectedBoardGame:
            function () {
                let self = this;
                self.currentPlayedGame = null;
                self.selectedBoardGame = null;
                self.selectedGameScore = [];
                self.selectedPlayer = [];
                self.selectedPlayTime = 0;
                self.numberOfPlayers = 0;
            },
    },
});
