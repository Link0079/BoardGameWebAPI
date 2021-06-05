var logoutApp = new Vue({
    el: '#logoutApp',
    data: {
        isLogedIn: sessionStorage.getItem("sessionPlayerLogedIn"),
    },
    methods: {
        LogoutPlayer:
            function () {
                let self = this;
                if (self.isLogedIn) {
                    sessionStorage.clear();
                    window.location.href = "/";
                }
                else {
                    window.location.href = "/";
                }
            }
    },
});