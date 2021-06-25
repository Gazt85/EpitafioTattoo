using Blazored.Modal;
using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EpitafioTattoo.Shared
{
    public partial class ModalCustomImage : ComponentBase
    {

        #region Properties
        [CascadingParameter]
        BlazoredModalInstance BlazoredModal { get; set; }

        [CascadingParameter]
        IModalService Modal { get; set; }        

        [Parameter]
        public string Source { get; set; }

        [Parameter]
        public string Subgallery { get; set; }
        public DirectoryInfo Directory { get; set; }

        #endregion

        protected override void OnInitialized()
        {
            Directory = new DirectoryInfo(@$"{Environment.CurrentDirectory}\wwwroot\img\{Subgallery}");
        }

        #region Events

        async Task Close() => await BlazoredModal.CloseAsync(ModalResult.Ok(true));
        async Task Cancel() => await BlazoredModal.CancelAsync();

        async Task Delete()
        {
            ModalParameters parameters = GetModalParameters(); 

            var confirmation = Modal.Show<ModalPrompt>("", parameters);

            var result = await confirmation.Result;

            if (result.Cancelled)
                return;

            DeleteImage();
            await BlazoredModal.CloseAsync(ModalResult.Ok("Deleted"));
        }

        private ModalParameters GetModalParameters()
        {
            var parameters = new ModalParameters();

            parameters.Add(nameof(ModalPrompt.Text), "¿Esta seguro que desea eliminar la imagen?");
            parameters.Add(nameof(ModalPrompt.AceptOption), "Si");
            parameters.Add(nameof(ModalPrompt.CancelOption), "No");

            return parameters;
        }

        #endregion

        void DeleteImage()
        {
            try
            {
                var lastSlashIndex = Source.LastIndexOf(@"/");

            if (lastSlashIndex > 0)
            {
                var imageName = Source.Substring(lastSlashIndex + 1);

                    if (File.Exists(Path.Combine(Directory.ToString(), imageName)))
                    {
                        // If file found, delete it
                        File.Delete(Path.Combine(Directory.ToString(), imageName));
                    }
                }
            }

            catch (IOException ioExp)
            {
                Console.WriteLine(ioExp.Message);
            }

        }
    }
}
