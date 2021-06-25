using Entities.Data_Transfer_Objects;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Inputs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EpitafioTattoo.Pages
{
    public partial class AddProduct : ComponentBase
    {
        #region Properties


        [Parameter]
        public string Name { get; set; }

        public ProductToInsertDto Model { get; set; } = new ProductToInsertDto();

        public DirectoryInfo Directory { get; set; }

        public Syncfusion.Blazor.Inputs.Internal.UploadFiles UploadFile { get; set; }

        private const string _digitalDesigns = "digitalDesigns";
        private const string _paintings = "paintings";
        private const string _merchandising = "merchandising";

        #endregion

        #region Life Cycle Methods

        protected override void OnInitialized()
        {
            switch (Name)
            {
                case _digitalDesigns:
                    Directory = new DirectoryInfo(@$"{Environment.CurrentDirectory}\wwwroot\img\digitalDesigns");
                    break;

                case _paintings:
                    Directory = new DirectoryInfo(@$"{Environment.CurrentDirectory}\wwwroot\img\paintings");
                    break;

                case _merchandising:
                    Directory = new DirectoryInfo(@$"{Environment.CurrentDirectory}\wwwroot\img\merch");
                    break;
            }
        }

        #endregion

        #region Events

        protected async Task HandleSubmit()
        {
            if (UploadFile != null)
            {
                UploadNewImageFile();               
            }

        }

        private void Upload_OnChange(UploadChangeEventArgs args)
        {

            foreach (var file in args.Files)
            {
                UploadFile = file;
            }
        }

        #endregion

        private void UploadNewImageFile()
        {
            string path = @$"{Directory}\{UploadFile.FileInfo.Name}";
            FileStream filestream = new FileStream(path, FileMode.Create, FileAccess.Write);

            UploadFile.Stream.WriteTo(filestream);
            filestream.Close();
            UploadFile.Stream.Close();
        }
    }
}
