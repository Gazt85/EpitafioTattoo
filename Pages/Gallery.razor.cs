﻿using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Inputs;
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

        #region Private Methods

        private void OnChange(UploadChangeEventArgs args)
        {
            foreach (var file in args.Files)
            {
                string path = @$"{Directory}\{file.FileInfo.Name}";
                FileStream filestream = new FileStream(path, FileMode.Create, FileAccess.Write);
                file.Stream.WriteTo(filestream);
                filestream.Close();
                file.Stream.Close();
            }
        }

        #endregion
    }
}
