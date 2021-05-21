var boardGameApiURL = 'https://localhost:5001/api/boardgames';
var playerApiURL = 'https://localhost:5001/api/players';
var categoriesApiURL = 'https://localhost:5001/api/categories';
var artistsApiURL = 'https://localhost:5001/api/artists';
var playedGamesApiURL = 'https://localhost:5001/api/playedgames';
var rolesApiURL = 'https://localhost:5001/api/Roles';
var playerToken = "";
const axiosConfig = { headers: { Authorization: `${playerToken}` } };
sessionStorage.setItem("token", `${playerToken}`);

var authenticationApp = new Vue({
    el: '#authenticationApp',
    data: {
        playerToRegister: null,
        playerToLogin: null,
        playerInfo: null,
        isRegisterPage: false,
        loginButton: "Register",
        signButton: "Sign In",
        parsedPlayerJwt: null
    },
    created:
        function () {
            let self = this;
            self.playerToRegister = { userName: "", email: "", password: "", confirmPassword: "", name: "", dob: "" },
            self.playerToLogin = { userName: "", password: "" }
    },
    methods: {
        toLoginOrRegister:
            function (signButton) {
                let self = this;
                if (signButton != "Register") {
                    self.registerPlayer();
                }
                else {
                    self.loginPlayer();
                }
            },
        registerPlayer:
            function () {
                let self = this;
                axios.post(`${playerApiURL}/register`, self.playerToRegister)
                    .then(function (response) { self.playerInfo = response.data; })
                    .catch(function (error) { console.log(error); });
            },
        wantToLogin:
            function () {
                let self = this;
                if (self.isRegisterPage) {
                    self.isRegisterPage = false;
                    self.loginButton = "Register";
                    self.signButton = "Sign In";
                }
                else {
                    self.isRegisterPage = true;
                    self.loginButton = "Login";
                    self.signButton = "Sign Up";
                }
            },
        loginPlayer:
            function () {
                let self = this;
                axios.post(`${playerApiURL}/login`, self.playerToLogin)
                    .then(function (response) { self.playerToken = response.token; })
                    .catch(function (error) { console.log(error); });
                localStorage.setItem("token", self.playerToken);
                self.parsedPlayerJwt = self.parseJwt(self.playerToken);
            },
        parseJwt:
            function (token) {
            try {
                return JSON.parse(atob(token.split('.')[1]));
            } catch (e) {
                return null;
            }
        }

    }
});
