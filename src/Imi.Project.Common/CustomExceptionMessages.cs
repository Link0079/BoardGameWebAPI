using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Common
{
    public class CustomExceptionMessages
    {
        #region Required messages
        // Boardgame
        public const string RequiredBoardGameTitle = "Please enter a valid name.";
        public const string RequiredBoardGamePrice = "Please enter a valid price.";
        public const string RequiredBoardGameYear = "Please enter a valid year.";
        // PlayedGame

        // Artist
        public const string RequiredArtistName = "Please enter a valid name.";
        // Category
        public const string RequiredCategryName = "Please enter a valid name.";
        // Player
        public const string RequiredPlayerName = "Please enter a valid name.";
        public const string RequiredPlayerUserName = "Please enter a valid username.";
        public const string RequiredPlayerEmail = "Please enter a valid email.";
        public const string RequiredPlayerPassword = "Please enter a password.";
        public const string RequiredPlayerConfirmPassword = "The password and confirmation password do not match.";
        #endregion

        #region Not Found Messages
        // Artist
        public const string NotFoundArtistName = "There were no artists found that contain '{0}' in their name.";
        public const string NotFoundArtistId = "Artist with id '{0}' does not exist.";
        public const string NotFoundArtistBoardGames = "Artist with id '{0}' has not made any artwork.";
        // BoardGame
        public const string NotFoundBoardGameTitle = "There were no boardgames found that contain '{0}' in their title.";
        public const string NotFoundBoardGameId = "Boardgame with id '{0}' does not exist.";
        // Category
        public const string NotFoundCategoryName = "There were no categories found that contain '{0}' in their name.";
        public const string NotFoundCategoryId = "Category with id '{0}' does not exist.";
        public const string NotFoundCategoryBoardGames = "Category with id '{0}' does not have any boardgames.";
        //PlayedGame
        public const string NotFoundPlayedGameId = "PlayedGame with id '{0}' does not exist.";
        // Player
        public const string NotFoundPlayerName = "There were no players found that contain '{0}' in their name.";
        public const string NotFoundPlayerId = "Player with id '{0}' does not exist.";
        public const string NotFoundPlayerPlayedGames = "Player wit id '{0}' has not played any games.";
        // Statistics
        public const string NotFoundStatisticsTotalItems = "'{0}' is not a valid number, please enter a number.";
        #endregion

    }
}
