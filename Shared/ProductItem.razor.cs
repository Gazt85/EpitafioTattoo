using Blazored.Modal;
using Blazored.Modal.Services;
using Entities.Data_Transfer_Objects;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EpitafioTattoo.Shared
{
    public partial class ProductItem : ComponentBase
    {
        #region Properties       
              
        [Parameter]
        public ProductDto Product { get; set; }

        [Inject] protected NavigationManager NavigationManager { get; set; }

        [CascadingParameter] public IModalService Modal { get; set; }

        //Test
        public List<ProductDto> ProductList { get; set; } = new List<ProductDto>();

        #endregion

        #region LifeCycle Methods        

        protected override void OnInitialized()
        {
            if (string.IsNullOrEmpty(Product.ImageSource))
            {
                Product.ImageSource = @"img\black.png";
            }           
        }

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
                Delete();
            }

        }

        private void Edit()
        {
            NavigationManager.NavigateTo($"editproduct/{Product.Id}");
        }

        private void Delete()
        {
            //NavigationManager.NavigateTo("/loader");
            //NavigationManager.NavigateTo($"products/{Product.ProductType}");
        }

        #endregion

        /// <summary>
        /// Creates parameters to pass to the modal.
        /// </summary>
        /// <returns>ModalParameters to pass into the modal call.</returns>
        private ModalParameters GetModalParameters()
        {
            var parameters = new ModalParameters();

            parameters.Add(nameof(ModalCustomImage.Source), Product.ImageSource);
            parameters.Add(nameof(ModalCustomImage.Subgallery), Product.ProductType);

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
