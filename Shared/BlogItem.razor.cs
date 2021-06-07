using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EpitafioTattoo.Shared
{
    public partial class BlogItem
    {

        #region Properties

        public Guid Id { get; set; }

        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public DateTime Date { get; set; }

        [Parameter]
        public string Description { get; set; }

        public string Link { get; set; }

        [Inject] protected NavigationManager NavigationManager { get; set; }

        #endregion

        #region Life Cycle Methods

        protected override void OnInitialized()
        {
            Id = new Guid();
            Link = "https://www.youtube.com/watch?v=0HU1rMDGyB8&t=187s";
        }

        #endregion

        #region Events

        private void GoToPost(Guid id)
        {
            NavigationManager.NavigateTo($"blogpost/{id}"); //ver de usar el id de las properties
        }

            #endregion
        }


}
