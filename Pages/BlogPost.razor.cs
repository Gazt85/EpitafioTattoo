using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Data_Transfer_Objects;

namespace EpitafioTattoo.Pages
{
    public partial class BlogPost
    {
        #region Properties

        [Parameter]
        public Guid Id { get; set; }

        public BlogPostDto BlogPostModel { get; set; }

        private const string _back = "<< Volver";

        #endregion

        #region Life Cycle Methods

        protected override void OnInitialized()
        {
            //Llamar a backend con el id para obtener el objeto BlogPost

            BlogPostModel = new BlogPostDto
            {
                Title = "The Title",
                Date = DateTime.Now,
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
            };
            
            //Agregar boton para volver a la lista de posts.
            
        }

        #endregion
    }
}
