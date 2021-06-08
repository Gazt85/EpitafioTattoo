using Entities.Data_Transfer_Objects;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EpitafioTattoo.Pages
{
    public partial class EditBlogPost : ComponentBase

    {
        [Parameter]
        public Guid Id { get; set; }

        public BlogPostToUpdateDto Model { get; set; }


        #region Life Cycle Methods

        protected override void OnInitialized()
        {

        }

        protected async Task HandleSubmit()
        {

        }

        #endregion
    }
}
