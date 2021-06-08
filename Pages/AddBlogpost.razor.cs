using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Data_Transfer_Objects;

namespace EpitafioTattoo.Pages
{
    public partial class AddBlogPost
    {
        public BlogPostToInsertDto Model { get; set; } = new BlogPostToInsertDto();


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
