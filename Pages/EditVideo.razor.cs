﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Data_Transfer_Objects;

namespace EpitafioTattoo.Pages
{
    public partial class EditVideo : ComponentBase
    {
        #region Properties

        [Parameter]
        public Guid Id { get; set; }

        public VideoToInsertDto Model { get; set; }

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
