using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EpitafioTattoo.Shared
{
    public partial class VideoItem
    {
        #region Properties

        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public DateTime Date { get; set; }

        public string DateToShow { get; set; }

        [Parameter]
        public string Description { get; set; }

        [Parameter]
        public string ImageSource { get; set; }

        [Parameter]
        public string Link { get; set; }

        #endregion

        #region Life Cycle Methods

        protected override void OnInitialized()
        {

            if (string.IsNullOrEmpty(ImageSource))
            {
                ImageSource =  @"img\black.png"; 
            }

        }

     
        #endregion       
    }
}
