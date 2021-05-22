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
        getBoardGameCssClass:
            function (boardGame) {
                if (boardGame.stock == "True") {
                   return "list-group-item-success";
                }
            },
        getBoardGameDetails:
            function (boardGame) {
                let self = this;
                self.currentBoardGame = boardGame;
            }
    }
});
