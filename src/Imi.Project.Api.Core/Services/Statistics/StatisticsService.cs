using AutoMapper;
using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Dtos.Games;
using Imi.Project.Api.Core.Dtos.Statistics;
using Imi.Project.Api.Core.Dtos.Users;
using Imi.Project.Api.Core.Extentions;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Core.Interfaces.Repositories.Games;
using Imi.Project.Api.Core.Interfaces.Repositories.Users;
using Imi.Project.Api.Core.Interfaces.Services.Statistics;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services.Statistics
{
    public class StatisticsService : IStatisticsService
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IBoardGameRepository _boardGameRepository;
        private readonly IArtistRepository _artistRepository;
        private readonly IMapper _mapper;
        public StatisticsService(IPlayerRepository playerRepository, IMapper mapper,
            IBoardGameRepository boardGameRepository, IArtistRepository artistRepository)
        {
            _artistRepository = artistRepository;
            _boardGameRepository = boardGameRepository;
            _playerRepository = playerRepository;
            _mapper = mapper;
        }
        public async Task<StatisticsResponseDto> GetStatisticsAsync(int totalItems)
        {
            var statisticsResponseDto = new StatisticsResponseDto();
            statisticsResponseDto.TopBoardgamePlayTime = _mapper.Map<ICollection<BoardGameResponseDto>>(await _boardGameRepository.GetTopBoardGameWithLongestPlayTimeAsync(totalItems));
            statisticsResponseDto.TopHighesRatedBoardGames = _mapper.Map<ICollection<BoardGameResponseDto>>(await _boardGameRepository.GetTopBoardGameWithHighestRatingAsync(totalItems));
            statisticsResponseDto.GetTopPlayerWithLongestTotalPlaytime = _mapper.Map<ICollection<PlayerResponseDto>>(await _playerRepository.GetTopPlayerWithLongestTotalPlaytimeAsync(totalItems));
            statisticsResponseDto.TopPlayerWithMostPlayedGames = _mapper.Map<ICollection<PlayerResponseDto>>(await _playerRepository.TopPlayerWithMostPlayedGamesAsync(totalItems));
            statisticsResponseDto.TopFirstPlayers = _mapper.Map<ICollection<PlayerResponseDto>>(await _playerRepository.TopFirstPlayersAsync(totalItems));
            statisticsResponseDto.TopArtistWithMostArtwork = _mapper.Map<ICollection<ArtistResponseDto>>(await _artistRepository.TopArtistWithMostArtworkAsync(totalItems));
            statisticsResponseDto.TotalBoardGamesPlayTime = _boardGameRepository.GetTotalBoardGamePlayTimeAsync().Result.ConvertToSTringDuration();

            return statisticsResponseDto;
        }
    }
}
