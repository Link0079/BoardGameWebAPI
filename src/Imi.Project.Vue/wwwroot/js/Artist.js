var artistApp = new Vue({
    el: '#artistApp',
    data: {
        playerRole: sessionStorage.getItem("sessionPlayerRole"),
        isAuthorized: false,
        isAdmin: false,
        loading: false,
        artists: [],
        currentArtist: null,
        apiMessageInfo: "",
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
                self.apiMessageInfo = "Please register or login.";
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
                if (!self.editArtist) { self.currentArtist = { name: "", dob: "" }
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
                        self.currentArtist = response.data;
                        self.artists.push(self.currentArtist);
                        self.apiMessageInfo = `Artist with id '${response.data.id}' has been created. Refresh page.!!`
                    })
                    .catch(function (error) {
                        console.log(error.response.data.title);
                        self.hasError = true;
                        self.apiMessageInfo = "Creating new artist Failed, check all values!";
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
                        self.apiMessageInfo = `Artist with id '${self.currentArtist.id}' has been updated. Refresh page.!!`
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
        DeleteArtist:
            function () {
                let self = this;
                let deleteArtistsUrl = `${artistsApiURL}/${self.currentArtist.id}`;
                axios.delete(deleteArtistsUrl, axiosBoardGameConfig)
                    .then(function (response) {
                        self.apiMessageInfo = response.data;
                        self.artists.forEach(function (artist, index) {
                            if (artist.id === self.currentArtist.id) {
                                self.artists.splice(index, 1);
                            }
                        });
                        self.currentArtist = null;
                        self.hasSuccess = true;
                    })
                    .catch(function (error) {
                        console.log(error);
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
        CancelArtist:
            function () {
                let self = this;
                self.isDisabled = true;
                self.currentArtist = null;
            },
        GetArtistDetails:
            function (artist) {
                let self = this;
                self.isDisabled = true;
                self.currentArtist = artist;
            },
    },
});
