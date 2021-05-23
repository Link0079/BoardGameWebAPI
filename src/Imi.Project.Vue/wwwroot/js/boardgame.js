var boardGameApp = new Vue({
    el: '#boardGameApp',
    data: {
        boardgames: null,
        currentBoardGame: null,
        loading: true,
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
        GetBoardGameDetails:
            function (boardGame) {
                let self = this;
                self.currentBoardGame = boardGame;
            }
    }
});
