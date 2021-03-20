using AutoMapper;
using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Dtos.Games;
using Imi.Project.Api.Core.Dtos.Users;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Entities.Games;
using Imi.Project.Api.Core.Entities.Users;
using Imi.Project.Api.Core.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Imi.Project.Api.Core.Mapping
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            #region Player
            CreateMap<Player, PlayerResponseDto>()
                .ForMember(dest => dest.PlayedGameCount,
                    opt => opt.MapFrom(src => src.GameScores
                    .Where(gs => gs.PlayerId == src.Id).Count()))
                .ForMember(dest => dest.PlayTimeTotal,
                    opt => opt.MapFrom(src => src.GameScores
                    .Where(gs => gs.PlayerId == src.Id)
                    .Sum(gs => gs.PlayedGame.PlayTime)
                    .ConvertToStringDuration()))
            //.ForMember(dest => dest.FavoPlayedGame,
            //    opt => opt.MapFrom(src => src.GameScores
            //      .Where(gs => gs.PlayerId == src.Id)
            //      .GroupBy(gs => gs.PlayedGame.BoardGameId, 
            //      (boardGame, boardGames) => new
            //      {
            //          Key = boardGame,
            //          Title = boardGames.Select(b => new {Title = b.PlayedGame.BoardGame.Title})
            //      })));
            ;
            #endregion
            #region Category
            CreateMap<Category, CategoryResponseDto>();

            #endregion
            #region Artist
            CreateMap<Artist, ArtistResponseDto>()
                .ForMember(dest => dest.NumberOfArtwork,
                    opt => opt.MapFrom(src => src.Artwork
                      .Where(art => art.ArtistId == src.Id).Count()))
                .ForMember(dest => dest.Dob,
                    opt => opt.MapFrom(src => src.Dob
                    .ConvertToStringDateNotation()));
            #endregion
            #region BoardGame
            CreateMap<BoardGame, BoardGameResponseDto>()
                .ForMember(dest => dest.Categories,
                    opt => opt.MapFrom(src => src.Categories
                    .Select(bc => new CategoryResponseDto
                    {
                        Id = bc.CategoryId,
                        Name = bc.Category.Name
                    })))
                .ForMember(dest => dest.NumberOfCategories,
                    opt => opt.MapFrom(src => src.Categories
                    .Where(bc => bc.CategoryId == src.Id).Count()))
                .ForMember(dest => dest.NumberofArtists,
                    opt => opt.MapFrom(src => src.Artists
                    .Where(ba => ba.BoardGameId == src.Id).Count()))
                .ForMember(dest => dest.PlayTime,
                    opt => opt.MapFrom(src => src.PlayTime
                    .ConvertToStringDuration()));
            #endregion
            #region PlayedGame
            CreateMap<PlayedGame, PlayedGameResponseDto>()
                .ForMember(dest => dest.PlayTime,
                    opt => opt.MapFrom(src => src.PlayTime
                      .ConvertToStringDuration()))
                .ForMember(dest => dest.PlayerCount,
                    opt => opt.MapFrom(src => src.GameScores
                      .Where(gs => gs.PlayedGameId == src.Id).Count()))
                .ForMember(dest => dest.GameScores,
                    opt => opt.MapFrom(src => src.GameScores
                      .Where(gs => gs.PlayedGameId == src.Id)
                      .Select(gs => new GameScoreResponseDto
                      {
                          PlayerName = gs.Player.Name,
                          Score = gs.Score
                      }).OrderByDescending(gs=>gs.Score)));
            #endregion
            #region GameScore
            CreateMap<GameScore, GameScoreResponseDto>()
                .ForMember(dest => dest.PlayerName,
                    opt => opt.MapFrom(src => src.Player.Name))
                .ForMember(dest => dest.Score,
                    opt => opt.MapFrom(src => src.Score));
            #endregion

            #region Country

            #endregion
            #region Publisher

            #endregion
        }
    }
}
