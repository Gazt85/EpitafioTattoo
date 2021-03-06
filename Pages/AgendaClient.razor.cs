﻿using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Calendars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syncfusion.Blazor.Inputs;
using System.IO;
using Entities.Data_Transfer_Objects;
using Blazored.Modal;
using Blazored.Modal.Services;
using EpitafioTattoo.Shared;

namespace EpitafioTattoo.Pages
{
    public partial class AgendaClient : ComponentBase
    {
        #region Members

        public AppointmentToInsertDto Appointment { get; set; } = new AppointmentToInsertDto();
        public bool HasPreviousTattoos { get; set; }
        public DirectoryInfo Directory { get; set; }

        [CascadingParameter]
        IModalService Modal { get; set; }
        public DateTime MinDate { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        public DateTime MaxDate { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1,1);
        public DateTime MinTime { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 14, 00, 00);
        public DateTime MaxTime { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 19, 00, 00);

        private UploaderButtonsProps browseBtn = new UploaderButtonsProps() { Browse = "Buscar", Clear = "Limpiar", Upload = "Subir" };

        #endregion

        #region Life Cycle Methods

        protected override void OnInitialized()
        {
            HasPreviousTattoos = Appointment.HasPreviousTattoos;
            Directory = new DirectoryInfo(@$"{Environment.CurrentDirectory}\wwwroot\img\region");

            //Precargar los textbox con los datos del cliente logueado, si existe.
        }

        protected async Task HandleSubmit()
        {
            ModalParameters parameters = GetModalParameters();

             Modal.Show<ModalConfirmation>("", parameters);
            //Appointment.DateAndTime = GetDateTime();
            // Esto se debe hacer en la API.

            //var client = new ClientDto(Appointment.FirstName,Appointment.LastName,Appointment.Phone,Appointment.Email);

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

        #region Auxiliary

        private ModalParameters GetModalParameters()
        {
            var parameters = new ModalParameters();

            parameters.Add(nameof(ModalConfirmation.Text1), "¡Gracias por agendarte en Epitafio Tatoo!");
            parameters.Add(nameof(ModalConfirmation.Text2), $"La fecha agendada tentativa es {GetDateTime().ToString("dd/MM/yyyy -- hh:mm ")} hrs.");
            parameters.Add(nameof(ModalConfirmation.Text3), "Ten en cuenta que la fecha que seleccionaste sera revisada por nuestro equipo " +
                "y te estaremos contactando a la brevedad para confirmarte.");
            parameters.Add(nameof(ModalConfirmation.AceptOption), "Ok");

            return parameters;
        }

        /// <summary>
        /// Gets the appointment Date and appointment Time to
        /// create the data for the Appointment.DateTime
        /// </summary>
        /// <returns></returns>
        private DateTime GetDateTime()
        {
            DateTime date = Appointment.Date.GetValueOrDefault();

            DateTime time = Appointment.Time.GetValueOrDefault();

            return new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second);
        }

        #endregion


    }
}
