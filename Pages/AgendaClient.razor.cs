﻿using EpitafioTattoo.Models;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Calendars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syncfusion.Blazor.Inputs;
using System.IO;

namespace EpitafioTattoo.Pages
{
    public partial class AgendaClient : ComponentBase
    {
        #region Members

        public Appointment Appointment { get; set; } = new Appointment();
        public bool HasPreviousTattoos { get; set; }
        public DirectoryInfo Directory { get; set; }
        public DateTime MinDate { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        public DateTime MaxDate { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1,1);
        public DateTime MinTime { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 14, 00, 00);
        public DateTime MaxTime { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 19, 00, 00);       

        #endregion

        #region Life Cycle Methods

        protected override void OnInitialized()
        {
            HasPreviousTattoos = Appointment.HasPreviousTattoos;
            Directory = new DirectoryInfo(@$"{Environment.CurrentDirectory}\wwwroot\img\region");
        }

        protected async Task HandleSubmit()
        {
            DateTime date = Appointment.Date.GetValueOrDefault();

            DateTime time = Appointment.Time.GetValueOrDefault();

            Appointment.DateAndTime = new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second);

            //Crear nuevo cliente a partir de los datos disponibles para crear un cliente.

        }

        #endregion

        #region Events

        private void Upload_OnChange(UploadChangeEventArgs args)
        {
            foreach (var file in args.Files)
            {
                string path = @$"{Directory}\{file.FileInfo.Name}";
                FileStream filestream = new FileStream(path, FileMode.Create, FileAccess.Write);
                file.Stream.WriteTo(filestream);
                filestream.Close();
                file.Stream.Close();
            }
        }

        private void DateTimePicker_OnChange(ChangedEventArgs<DateTime?> args)
        {
            Appointment.Date = args.Value;
            StateHasChanged();
        }


        private void TimePicker_OnChange(Syncfusion.Blazor.Calendars.ChangeEventArgs<DateTime?> args)
        {
            Appointment.Time = args.Value;
            StateHasChanged();
        }

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
