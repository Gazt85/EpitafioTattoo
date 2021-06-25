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
        [Inject] protected NavigationManager NavigationManager { get; set; }

        private const string _piercing = "piercing";
        private const string _tattoo = "tattoo";
        private const string _digitalDesigns = "digitalDesigns";
        private const string _paintings = "paintings";      
        private const string _merchandising = "merchandising";

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

                case "Agendarme":
                    NavigationManager.NavigateTo("/agenda");
                    break;

                case "Blog":
                    NavigationManager.NavigateTo("/blog");
                    break;

                case "Videos":
                    NavigationManager.NavigateTo("/video");
                    break;

                case "Merchandising":
                    NavigationManager.NavigateTo("/loader");
                    NavigationManager.NavigateTo($"products/{_merchandising}");
                    break;

                case "Contacto":
                    NavigationManager.NavigateTo("/contact");
                    break;

                case "Preguntas Frecuentes":
                    NavigationManager.NavigateTo("/faq");
                    break;

            }
        }

        #endregion

        #region Private Methods

        private void Navigate(string dest)
        {
            switch (dest)
            {
                case _piercing:
                    NavigationManager.NavigateTo("/loader");
                    NavigationManager.NavigateTo($"gallery/{_piercing}");
                    break;

                case _tattoo:
                    NavigationManager.NavigateTo("/loader");
                    NavigationManager.NavigateTo($"gallery/{_tattoo}");
                    break;

                case _digitalDesigns:
                    NavigationManager.NavigateTo("/loader");
                    NavigationManager.NavigateTo($"products/{_digitalDesigns}");
                    break;

                case _paintings:
                    NavigationManager.NavigateTo("/loader");
                    NavigationManager.NavigateTo($"products/{_paintings}");
                    break;

                case _merchandising:
                    NavigationManager.NavigateTo("/loader");
                    NavigationManager.NavigateTo($"products/{_merchandising}");
                    break;


            }
        }

        #endregion

     


    }
}

