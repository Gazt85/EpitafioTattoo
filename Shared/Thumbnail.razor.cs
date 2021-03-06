﻿using Blazored.Modal;
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

        [Parameter]
        public string Subgallery { get; set; }

        [CascadingParameter] public IModalService Modal { get; set; }

        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        #endregion

        #region Events

        private async void Maximize()
        {
            ModalParameters parameters = GetModalParameters();

            ModalOptions options = GetModalOptions();

            var modal = Modal.Show<ModalCustomImage>("", parameters, options);
            var result = await modal.Result;

            // it means the user has deleted the image.
            if (result.Data.Equals("Deleted"))
            {
                NavigationManager.NavigateTo("/loader");
                NavigationManager.NavigateTo($"gallery/{Subgallery}");
            }

        }

        #endregion

        /// <summary>
        /// Creates parameters to pass to the modal.
        /// </summary>
        /// <returns>ModalParameters to pass into the modal call.</returns>
        private ModalParameters GetModalParameters()
        {
            var parameters = new ModalParameters();

            parameters.Add(nameof(ModalCustomImage.Source), Source);
            parameters.Add(nameof(ModalCustomImage.Subgallery), Subgallery);

            return parameters;
        }

        /// <summary>
        /// Creates options to pass to the modal.
        /// </summary>
        /// <returns>ModalOptions to pass to the modal call.</returns>
        private ModalOptions GetModalOptions()
        {
            return new ModalOptions
            {
                ContentScrollable = true,
                Animation = ModalAnimation.FadeInOut(1),
                HideCloseButton = true,
            };
        }

       
    }



}