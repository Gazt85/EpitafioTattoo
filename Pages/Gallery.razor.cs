using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Inputs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace EpitafioTattoo.Pages
{
    public partial class Gallery : ComponentBase
    {
        #region Members

        [Parameter]
        public string Subgallery { get; set; }
        //[Inject]
        //public SignInManager<IdentityUser> SignInManager { get; set; }
        //[Inject]
        //public UserManager<IdentityUser> UserManager { get; set; }
        public DirectoryInfo Directory { get; set; }

        private UploaderButtonsProps browseBtn = new UploaderButtonsProps() { Browse = "Explorar", Clear = "Limpiar", Upload = "Subir" };

        #endregion

        #region LifeCycle Methods        

        protected override void OnInitialized()
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

                if (!File.Exists(Path.Combine(Directory.ToString(), file.FileInfo.Name)))
                {
                    FileStream filestream = new FileStream(path, FileMode.Create, FileAccess.Write);
                    file.Stream.WriteTo(filestream);
                    filestream.Close();
                    file.Stream.Close();
                }
            }
        }

        #endregion
    }
}
