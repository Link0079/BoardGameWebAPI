var playerApiURL = 'https://localhost:5001/api/players';
var boardGameApiURL = 'https://localhost:5001/api/boardgames';
var categoriesApiURL = 'https://localhost:5001/api/categories';
var artistsApiURL = 'https://localhost:5001/api/artists';
var playedGamesApiURL = 'https://localhost:5001/api/playedgames';
var rolesApiURL = 'https://localhost:5001/api/Roles';
var PlayerTokenApiCall = sessionStorage.getItem("sessionPlayerToken");
const axiosConfig = { headers: { Authorization: `${PlayerTokenApiCall}` } };