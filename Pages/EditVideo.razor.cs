using EpitafioTattoo.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EpitafioTattoo.Pages
{
    public partial class EditVideo : ComponentBase
    {
        #region Properties

        [Parameter]
        public Guid Id { get; set; }

        public EditVideoModel Model { get; set; }

        #endregion

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
