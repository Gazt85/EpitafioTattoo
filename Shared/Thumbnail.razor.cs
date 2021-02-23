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

        #endregion

        #region Private Methods

        private void Maximize()
        {
            //Llamar a un modal que muestre la foto maximizada y tenga boton para cerrar.
        }

        #endregion
    }



}