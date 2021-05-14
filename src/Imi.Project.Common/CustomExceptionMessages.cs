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
        public const string RequierdPlayerDob = "Please enter a date of birth.";
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
        public const string NotFoundPlayerPlayedGames = "Player with id '{0}' has not played any games.";
        public const string NotFoundPlayerRoles = "Player with id '{0}' has no role(s).";
        // Statistics
        public const string NotFoundStatisticsTotalItems = "'{0}' is not a valid number, please enter a number.";
        //Roles
        public const string NotFoundRoleId = "Role with id '{0}' does not exist";
        public const string NotFoundRoleName = "There were no roles found that contain '{0}' in their name.";
        #endregion

        #region Conflicts
        // Roles
        public const string ConflictRoleNameExists = "Role with name '{0}' does already exists.";

        // Players
        public const string ConflictAddPlayer = "There was a conflict with adding a player.";
        public const string ConflictUpdatePlayer = "There was a conflict with updating player with id '{0}'.";
        public const string ConflictDeletePlayerId = "There was a conflict with deleting player with id '{0}'.";
        public const string ConflictUpdatePlayerIsActive = "There was a conflict with deactivating/activating player with id '{0}'.";
        public const string ConflictAddRoleToPlayer = "There was a conflict with adding a role with id '{0}' to player with id '{1}'.";
        public const string ConflictDeleteRolesFromPlayer = "There was a conflict with deleting the roles from player with id '{0}'.";

        // BoardGames
        public const string ConflictAddBoardGame = "There was a conflict with adding a boardgame.";
        public const string ConflictUpdateBoardgame = "There was a conflict with updating boardgame with id '{0}'.";
        public const string ConflictDeleteBoardGameId = "There was a conflict with deleting boardgame with id '{0}'.";
        public const string ConflictAddCategoryToBoardGame = "There was a conflict with adding a category with id '{1}' to boardgame with id '{0}'.";
        public const string ConflictAddArtistToBoardGame = "There was a conflict with adding an artist with id '{1}' to boardgame with id '{0}'.";
        public const string ConflictDeleteCategoryFromBoardGame = "There was a conflict with deleting a category with id '{1}' from boardgame with id '{0}'.";
        public const string ConflictDeleteArtistFromBoardGame = "There was a conflict with deleting an artist with id '{1}' from boardgame with id '{0}'.";

        // Artists
        public const string ConflictAddArtist = "There was a conflict with adding an artist.";
        public const string ConflictUpdateArtist = "There was a conflict with updating artist with id '{0}'.";
        public const string ConflictDeleteArtistId = "There was a conflict with deleting artist with id '{0}'.";


        #endregion

        #region Add
        // Player
        public const string AddPlayerRole = "Role has been add to player with id '{0}'.";
        #endregion

        #region Update
        // Player
        public const string UpdatePlayerInfo = "Player with id '{0}' has been updated.";
        public const string UpdatePlayerRole = "Role from player with id '{0}' has been updated.";
        #endregion

        #region Deleted
        public const string DeleteRoleId = "Role with id {0} has been deleted.";
        public const string DeletePlayerId = "Player with id {0} has been deleted.";
        public const string DeleteBoardGameId = "Boardgame with id {0} has been deleted.";
        public const string DeleteCategoryId = "Category with id {0} has been deleted.";
        public const string DeleteArtistId = "Artist with id {0} has been deleted.";
        public const string DeletePlayedGameId = "Playedgame with id {0} has been deleted.";
        public const string DeleteRolesFromPlayer = "Roles from player with id '{0}' has been deleted";
        #endregion

    }
}

