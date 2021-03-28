using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<IEnumerable<Category>> SearchByNameAsync(string name);
    }
}
