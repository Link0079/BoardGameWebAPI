var boardGameApiURL = 'https://localhost:5001/api/boardgames';
var categoriesApiURL = 'https://localhost:5001/api/categories';
var artistsApiURL = 'https://localhost:5001/api/artists';
var playedGamesApiURL = 'https://localhost:5001/api/playedgames';
var rolesApiURL = 'https://localhost:5001/api/Roles';

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
