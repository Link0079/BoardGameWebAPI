using Imi.Project.Vue.ViewModels.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Vue.Components
{
    [ViewComponent(Name = "MainNavigation")]
    public class MainNavComponent : ViewComponent
    {
        private IEnumerable<MainNavLinkViewModel> publicLinks;
        public MainNavComponent()
        {

        publicLinks = new List<MainNavLinkViewModel>
            {
                new MainNavLinkViewModel { Area = null, Controller = "Home", Action = "Index", Text = "Home", IsActive = false },
                new MainNavLinkViewModel { Area = null, Controller = "Players", Action = "Index", Text = "Players", IsActive = false },
                new MainNavLinkViewModel { Area = null, Controller = "BoardGames", Action = "Index", Text = "BoardGames", IsActive = false },
                new MainNavLinkViewModel { Area = null, Controller = "PlayedGames", Action = "Index", Text = "PlayedGames", IsActive = false }
            };
        }
        public async Task<IViewComponentResult> InvokeAsync(bool showAdmin = false)
        {
            //var navLinks = publicLinks;
            foreach (var lnk in publicLinks)
            {
                if (this.RouteData.Values["Area"]?.ToString().ToLower() == lnk.Area?.ToLower() &&
                    this.RouteData.Values["Controller"]?.ToString().ToLower() == lnk.Controller.ToLower() &&
                    this.RouteData.Values["Action"]?.ToString().ToLower() == lnk.Action.ToLower())
                    lnk.IsActive = true;
                else
                    lnk.IsActive = false;
            }
            return await Task.FromResult<IViewComponentResult>(View(publicLinks));
        }
    }
}
