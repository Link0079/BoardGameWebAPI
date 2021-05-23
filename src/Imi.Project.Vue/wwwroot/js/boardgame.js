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
            self.fetchBoardGames();
        },
    methods: {
        fetchBoardGames:
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

                        }, 1500);
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
        getBoardGameDetails:
            function (boardGame) {
                let self = this;
                self.currentBoardGame = boardGame;
            }
    }
});
