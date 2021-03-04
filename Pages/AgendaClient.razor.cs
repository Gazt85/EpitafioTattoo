using EpitafioTattoo.Models;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Calendars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syncfusion.Blazor.Inputs;


namespace EpitafioTattoo.Pages
{
    public partial class AgendaClient : ComponentBase
    {
        #region Members

        public Appointment Appointment { get; set; } = new Appointment();
        public bool HasPreviousTattoos { get; set; }
        public DateTime MinDate { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        public DateTime MaxDate { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1,1);
        public DateTime MinTime { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 14, 00, 00);
        public DateTime MaxTime { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 19, 00, 00);

        #endregion

        #region Life Cycle Methods

        protected override void OnInitialized()
        {
            HasPreviousTattoos = Appointment.HasPreviousTattoos;
        }

        protected async Task HandleSubmit()
        {

        }

        #endregion

        #region Events

        /// <summary>
        /// This method is a call back function used by 
        /// the Datepicker control to preventing the sunday to be picked.
        /// </summary>
        /// <param name="args"></param>
        public void DisableSundays(RenderDayCellEventArgs args)
        {
            if ((int)args.Date.DayOfWeek == 0)
            {
                args.IsDisabled = true;
            }
        }


        #endregion


    }
}
