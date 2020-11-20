using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EpitafioTattoo.Pages
{
    public partial class Gallery : ComponentBase
    {
        #region Members

        [Parameter]
        public string Subgallery { get; set; }

        public DirectoryInfo Directory { get; set; }

        #endregion

        #region LifeCycle Methods

        protected override async Task OnInitializedAsync()
        {
            Directory = new DirectoryInfo(@$"{Environment.CurrentDirectory}\wwwroot\img\{Subgallery}");


        }       

        #endregion
    }
}
