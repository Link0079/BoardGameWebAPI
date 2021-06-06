using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Vue.ViewModels.Components
{
    public class MainNavLinkViewModel
    {
        public string Text { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public bool IsActive { get; set; }
        public string Area { get; set; }

    }
}
