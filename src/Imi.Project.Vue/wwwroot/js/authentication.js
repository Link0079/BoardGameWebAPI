var authenticationApp = new Vue({
    el: '#authenticationApp',
    data: {
        isRegisterPage: false,
        playerToRegister: null,
        playerToLogin: null,
        signButton: "Let's Go",
        apiErrorInfo: null,
        hasError: false,
        hasSuccess: false,
        redirect: false,
        regError: null,
    },
    created:
        function () {
            let self = this;
            self.playerToRegister = { userName: "", email: "", password: "", confirmPassword: "", name: "", dob: "" },
            self.playerToLogin = { userName: "", password: "" }
    },
    methods: {
        ShowLoginOrRegister:
            function (showForm) {
                let self = this;
                if (showForm) {
                        self.isRegisterPage = false;
                        self.signButton = "Let's Go";
                }
                else {
                    self.isRegisterPage = true;
                    self.signButton = "Sign Up";
                }
            },
        HandleLoginForm:
            function (isLogin) {
                let self = this;
                if (isLogin) {
                    axios.post(`${playerApiURL}/login`, self.playerToLogin)
                        .then(function (response) {
                            self.HandleSessionStorage(response.data);
                            console.log("Login Success");
                            self.apiErrorInfo = "Login Success";
                            self.redirect = true;
                            self.hasSuccess = true;
                        })
                        .catch(function (error) {
                            console.log(error);
                            self.apiErrorInfo = "You are not Authorized. Check your usernme and/or password.";
                            self.hasError = true;
                        })
                        .finally(function () {
                            setTimeout(function () {
                                self.hasError = false;
                                self.hasSuccess = false;
                                self.RedirectFrom("Login");
                            }, 2500);
                        });
                }
                else {
                    axios.post(`${playerApiURL}/register`, self.playerToRegister)
                        .then(function (response) {
                            self.apiErrorInfo = response.data;
                            console.log("Registeration Success");
                            self.redirect = true;
                            self.hasSuccess = true;
                        })
                        .catch(function (error) {
                            console.log(error.response.data.errors);
                            console.log(error.response);
                            self.regError = error.response.data.errors;
                            //for (let prop in self.regError) {
                            //    console.log(prop + " => No hasOwnProp");
                            //    let errorTest = prop.split('.')[1];
                                //if (error.hasOwnProperty(prop)) {
                                //    console.log(prop + " => Short hasOwnProp");
                                //    }
                            //};

                            self.apiErrorInfo = "Registration Failed";
                            self.hasError = true;
                        })
                        .finally(function () {
                            setTimeout(function () {
                                self.hasError = false;
                                self.hasSuccess = false;
                                self.RedirectFrom("Register");
                            }, 2500);
                        });
                }
            },
        HandleSessionStorage:
            function (loginData) {
                let self = this;
                let token = loginData.token;
                sessionStorage.setItem("sessionPlayerToken", token);
                sessionStorage.setItem("sessionPlayerLogedIn", "true");
                sessionStorage.setItem("sessionPlayerId", `${loginData.playerId}`);

                //let playerJwt = sessionStorage.getItem("sessionToken");               // get token from sessionStorage..
                //console.log(playerJwt + "playerJwt Testing Token");                   // log token into console for verification
                let playerParsedJwt = self.parseJwt(token);                             // parse token with function above..

                for (let prop in playerParsedJwt) {                                     // loop through all properties of the object
                    //console.log(prop + " => No hasOwnProp");                          // log prop into console for verification !!Could fail!!
                    if (prop.includes("role")) {                                        // check if prop has "role" => true of false
                        //console.log(playerParsedJwt[prop] + " => PlayerRole");        // log role into console for verification
                        sessionStorage.setItem("sessionPlayerRole", playerParsedJwt[prop]);    // set new sessionStorage entry
                    }
                    //    if (playerParsedJwt.hasOwnProperty(prop)) {                   // if "No hasOnwProp" fails.?? This will resolve it.
                    //        console.log(prop + " => Short hasOwnProp");
                    //    }
                }
            },
        parseJwt:
        function (token) {
            try { return JSON.parse(atob(token.split('.')[1])); }
            catch (e) {return null; } },
        RedirectFrom:
            function (redirectFrom) {
                let self = this;
                switch (redirectFrom) {
                    case "Login":
                        if (self.redirect) {
                            window.location.href = "/boardgames";
                        }
                        break;
                    case "Register":
                        if (self.redirect) {
                            self.ShowLoginOrRegister(true);
                            self.playerToRegister = { userName: "", email: "", password: "", confirmPassword: "", name: "", dob: "" };
                            break;
                        }
                    default:
                }
                self.redirect = false;
            }
    }
});
