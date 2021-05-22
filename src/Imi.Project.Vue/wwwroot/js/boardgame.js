var boardGameApp = new Vue({
    el: '#boardGameApp',
    data: {
        boardgames: null,
        currentBoardGame: null,
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
                    .then(function (response) { self.boardgames = response.data; })
                    .catch(function (error) {
                        console.error(error);
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
