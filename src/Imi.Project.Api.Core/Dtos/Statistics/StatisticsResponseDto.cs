using Imi.Project.Api.Core.Dtos.Games;
using Imi.Project.Api.Core.Dtos.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Dtos.Statistics
{
    public class StatisticsResponseDto
    {
        public IEnumerable<BoardGameResponseDto> TopBoardgamePlayTime { get; set; }
        public IEnumerable<BoardGameResponseDto> TopHighesRatedBoardGames{ get; set; }
        public IEnumerable<PlayerResponseDto> GetTopPlayerWithLongestTotalPlaytime { get; set; }
        public IEnumerable<ArtistResponseDto> TopArtistWithMostArtwork{ get; set; }
        public IEnumerable<PlayerResponseDto> TopPlayerWithMostPlayedGames{ get; set; }
        public IEnumerable<PlayerResponseDto> TopFirstPlayers{ get; set; }
        public string TotalBoardGamesPlayTime{ get; set; }
    }
}
