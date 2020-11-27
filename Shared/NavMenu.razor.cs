using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syncfusion.Blazor.Navigations;
using Syncfusion.Blazor.Buttons;

namespace EpitafioTattoo.Shared
{
    public partial class NavMenu : ComponentBase
    {
        #region Members

        public SfSidebar Sidebar { get; set; }
        public string Target { get; set; } = ".maincontent";
        public bool SidebarToggle { get; set; } = false;
        public string piercing { get; set; } = "piercing";
        public string tattoo { get; set; } = "tattoo";
        [Inject] protected NavigationManager NavigationManager { get; set; }

        #endregion

        #region Public Methods

        public void Toggle()
        {
            SidebarToggle = !SidebarToggle;
        }

        public void OnclickHandler(AccordionClickArgs args)
        {
            if (args.Item == null)
            {
                return;
            }

            switch (args.Item.Header)
            {
                case "Eka Epitafio":
                    NavigationManager.NavigateTo("/index");
                    break;

                case "Agenda":
                    NavigationManager.NavigateTo("/fetchdata");
                    break;
            }
        }

        #endregion

        #region Private Methods

        private void Navigate(string dest)
        {
            switch (dest)
            {
                case "piercing":
                    NavigationManager.NavigateTo("/loader");
                    NavigationManager.NavigateTo($"gallery/{piercing}");
                    break;

                case "tattoo":
                    NavigationManager.NavigateTo("/loader");
                    NavigationManager.NavigateTo($"gallery/{tattoo}");
                    break;
            }
        }

        #endregion

     


    }
}

