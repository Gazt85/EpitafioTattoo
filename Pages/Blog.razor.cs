﻿using EpitafioTattoo.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Data_Transfer_Objects;
using Microsoft.AspNetCore.Components;

namespace EpitafioTattoo.Pages
{
    public partial class Blog : ComponentBase
    {
        #region Members

        public List<BlogItemDto> BlogItems { get; set; } = new List<BlogItemDto>();

        [Inject] protected NavigationManager NavigationManager { get; set; }

        #endregion

        #region Life Cycle Methods

        protected override void OnInitialized()
        {
            var blog1 = new BlogItemDto()
            {
                Title = "Titulo 1",
                Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                Date = DateTime.Now
            };

            var blog2 = new BlogItemDto()
            {
                Title = "Titulo 2",
                Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                Date = new DateTime(2020, 12, 12)
            };

            var blog3 = new BlogItemDto()
            {
                Title = "Titulo 3",
                Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                Date = new DateTime(2020, 07, 31)
            };

            var blog4 = new BlogItemDto()
            {
                Title = "Titulo 4",
                Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                Date = new DateTime(2020, 06, 18)
            };

            var blog5 = new BlogItemDto()
            {
                Title = "Titulo 5",
                Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                Date = new DateTime(2021, 02, 15)
            };

            var blog6 = new BlogItemDto()
            {
                Title = "Titulo 6",
                Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                Date = new DateTime(2020, 04, 05)
            };

            this.BlogItems.Add(blog1);
            this.BlogItems.Add(blog2);
            this.BlogItems.Add(blog3);
            this.BlogItems.Add(blog4);
            this.BlogItems.Add(blog5);
            this.BlogItems.Add(blog6);

            this.BlogItems.OrderByDescending(x => x.Date);

        }

        #endregion

        #region Events

        private void Add()
        {
            NavigationManager.NavigateTo($"addblogpost");
        }

        #endregion
    }
}
