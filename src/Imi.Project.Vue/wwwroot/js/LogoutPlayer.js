﻿var logoutApp = new Vue({
    el: '#logoutApp',
    data: {
        isLogedIn: sessionStorage.getItem("sessionLogedIn"),
    },
    watch: {

    },
    methods: {
        LogoutPlayer:
            function () {
                let self = this;
                console.log(self.isLogedIn);
                if (self.isLogedIn) {
                    sessionStorage.clear();
                    window.location.href = "https://localhost:5002";
                }
            }
    }
});