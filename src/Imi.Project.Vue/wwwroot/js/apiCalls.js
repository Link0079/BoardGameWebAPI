var playerApiURL = 'https://localhost:5001/api/players';
var boardGameApiURL = 'https://localhost:5001/api/boardgames';
var categoriesApiURL = 'https://localhost:5001/api/categories';
var artistsApiURL = 'https://localhost:5001/api/artists';
var playedGamesApiURL = 'https://localhost:5001/api/playedgames';
var rolesApiURL = 'https://localhost:5001/api/Roles';
var harryPotterCharactersApiURL = 'https://hp-api.herokuapp.com/api/characters';
var PlayerTokenApiCall = sessionStorage.getItem("sessionPlayerToken");
const axiosBoardGameConfig = { headers: { Authorization: `Bearer ${PlayerTokenApiCall}` } };

function createGuid() {
    return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function (c) {
        var r = Math.random() * 16 | 0, v = c === 'x' ? r : (r & 0x3 | 0x8);
        return v.toString(16);
    });
}
