using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Repositories
{
    public interface IArtistRepository : IRepository<Artist>
    {
        Task<IEnumerable<Artist>> SearchByNameAsync(string name);
        Task<IEnumerable<Artist>> TopArtistWithMostArtworkAsync(int totalItems);
    }
}
