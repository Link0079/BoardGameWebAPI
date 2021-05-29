var artistApp = new Vue({
    el: '#artistApp',
    data: {
        playerRole: sessionStorage.getItem("sessionPlayerRole"),
        isAuthorized: false,
        isAdmin: false,
        loading: false,
        artists: [],
        currentArtist: null,
        apiErrorInfo: "",
        isDisabled: true,
        hasError: false,
        hasSuccess: false,
        editArtist: false,
    },
    created:
        function () {
            let self = this;
            self.IsPlayerAuthorizedArtists();
            if (self.isAuthorized) {
                self.FetchArtists();
            }
            else {
                self.hasError = true;
                self.apiErrorInfo = "You are not Authorized.!!";
            }
        },
    methods: {
        FetchArtists:
            function () {
                let self = this;
                axios.get(`${artistsApiURL}`, axiosBoardGameConfig)
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
        IsPlayerAuthorizedArtists:
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
                        self.isAuthorized = true;
                        break;
                    case "Player":
                        self.isAuthorized = false;
                        break;
                    default:
                }
            },
        EditArtist:
            function (editArtist) {
                let self = this;
                self.editArtist = editArtist;
                self.isDisabled = false;
                if (!self.editArtist) {
                    self.currentArtist = {
                        id: createGuid(),
                        name: "",
                        dob: 01/01/2000
                    }
                }
            },
        SaveArtist:
            function () {
                let self = this;
                if (!self.editArtist) {
                    self.PostArtist();
                }
                else {
                    self.PutArtist();
                }
            },
        PostArtist:
            function () {
                let self = this;
                let postArtistsUrl = `${artistsApiURL}`;
                axios.post(postArtistsUrl, self.currentArtist, axiosBoardGameConfig)
                    .then(function (response) {
                        self.isDisabled = true;
                        self.hasSuccess = true;
                        self.artists.push(self.currentArtist);
                        self.apiErrorInfo = `Artist with id '${self.currentArtist.id}' has been created. Refresh page.!!`
                    })
                    .catch(function (error) {
                        console.log(error);
                        self.hasError = true;
                        self.apiErrorInfo = "Creating new artist Failed, check all values!";
                    })
                    .finally(function () {
                        setTimeout(function () {
                            self.hasSuccess = false;
                            self.hasError = false;
                        }, 2000)
                    });
            },
        PutArtist:
            function () {
                let self = this;
                let putArtistsUrl = `${artistsApiURL}`;
                axios.put(putArtistsUrl, self.currentArtist, axiosBoardGameConfig)
                    .then(function (response) {
                        self.isDisabled = true;
                        self.hasSuccess = true;
                        self.apiErrorInfo = `Artist with id '${self.currentArtist.id}' has been updated. Refresh page.!!`
                    })
                    .catch(function (error) {
                        console.log(error);
                        self.hasError = true;
                        self.apiErrorInfo = `There was a conflict with updating artist with id '${self.currentArtist.id}'!`;
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
                let deleteArtistsUrl = `${artistsApiURL}/${self.currentArtist.id}`;
                axios.delete(deleteArtistsUrl, axiosBoardGameConfig)
                    .then(function (response) {
                        self.apiErrorInfo = response.data;
                        self.artists.forEach(function (artist, index) {
                            if (artist.id === self.currentArtist.id) {
                                self.artists.splice(index, 1);
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
        GetArtistDetails:
            function (artist) {
                let self = this;
                self.isDisabled = true;
                self.currentArtist = artist;
            },
    },
});
