using AutoMapper;
using Imi.Project.Api.Core.Dtos.Games;
using Imi.Project.Api.Core.Entities.Games;
using Imi.Project.Api.Core.Interfaces.Repositories.Games;
using Imi.Project.Api.Core.Interfaces.Services.Games;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services.Games
{
    public class PlayedGameService : IPlayedGameService
    {
        private readonly IPlayedGameRepository _playedGameRepository;
        private readonly IGameScoreRepository _gameScoreRepository;
        private readonly IMapper _mapper;
        public PlayedGameService(IPlayedGameRepository playedGameRepository, 
            IMapper mapper, IGameScoreRepository gameScoreRepository)
        {
            _playedGameRepository = playedGameRepository;
            _gameScoreRepository = gameScoreRepository;
            _mapper = mapper;
        }
        public async Task<PlayedGameResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _playedGameRepository.GetByIdAsync(id);
            var dto = _mapper.Map<PlayedGameResponseDto>(result);
            return dto;
        }
        public async Task<IEnumerable<PlayedGameResponseDto>> GetByPlayerIdAsync(Guid id)
        {
            var result = await _playedGameRepository.GetByPlayerIdAsync(id);
            var dto = _mapper.Map<IEnumerable<PlayedGameResponseDto>>(result);
            return dto;
        }
        public async Task<IEnumerable<PlayedGameResponseDto>> ListAllAsync()
        {
            var result = await _playedGameRepository.ListAllAsync();
            var dto = _mapper.Map<IEnumerable<PlayedGameResponseDto>>(result);
            return dto;
        }
        public async Task<PlayedGameResponseDto> AddAsync(PlayedGameRequestDto playedGameRequestDto)
        {
            var playedGameEntity = _mapper.Map<PlayedGame>(playedGameRequestDto);
            await _playedGameRepository.AddAsync(playedGameEntity);
            return await GetByIdAsync(playedGameEntity.Id);
        }
        public async Task<PlayedGameResponseDto> UpdateAsync(PlayedGameRequestDto playedGameRequestDto)
        {
            var playedGameEntity = _mapper.Map<PlayedGame>(playedGameRequestDto);
            Expression<Func<GameScore, bool>> gsExpression = gs => gs.PlayedGameId == playedGameEntity.Id;
            var currentGameScoreList = _gameScoreRepository.GetFiltered(gsExpression);
            await _gameScoreRepository.DeleteAsync(currentGameScoreList);
            if(playedGameRequestDto.GameScores != null)
            {
                playedGameEntity.GameScores = new List<GameScore>();
                foreach (var score in playedGameRequestDto.GameScores)
                    playedGameEntity.GameScores.Add(new GameScore
                    { 
                        PlayerId = score.PlayerId,
                        Score = score.Score,
                        PlayedGameId = playedGameEntity.Id
                    });
                await _gameScoreRepository.AddAsync(playedGameEntity.GameScores);
            }
            await _playedGameRepository.UpdateAsync(playedGameEntity);
            return await GetByIdAsync(playedGameEntity.Id);
        }
        public async Task DeleteAsync(Guid id)
        {
            await _playedGameRepository.DeleteAsync(id);
        }
    }
}
