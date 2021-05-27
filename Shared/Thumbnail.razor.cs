using Blazored.Modal;
using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EpitafioTattoo.Shared
{
    public partial class Thumbnail : ComponentBase
    {

        #region Members


        [Parameter]
        public string Source { get; set; }

        [CascadingParameter] public IModalService Modal { get; set; }

        #endregion

        #region Private Methods

        private void Maximize()
        {
            var parameters = new ModalParameters();
            parameters.Add(nameof(CustomImageModal.Source), Source);

            var options = new ModalOptions { ContentScrollable = true };

            Modal.Show<CustomImageModal>("", parameters,options);
        }

        #endregion
    }



}