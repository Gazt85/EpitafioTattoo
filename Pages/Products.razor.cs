using Entities.Data_Transfer_Objects;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EpitafioTattoo.Pages
{
    public partial class Products : ComponentBase
    {
        #region Members

        [Parameter]
        public string Name { get; set; }

        public string ProductType { get; set; }

        [Inject] protected NavigationManager NavigationManager { get; set; }

        public List<ProductDto> ProductList { get; set; } = new List<ProductDto>();

        private const string _digitalDesigns = "digitalDesigns";
        private const string _paintings = "paintings";
        private const string _merchandising = "merchandising";

        private const string _digitalDesignsES = "Diseños Digitales";
        private const string _paintingsES = "Pinturas";       
        private const string _merchandisingES = "Merchandising";

        #endregion

        #region LifeCycle Methods        

        protected override void OnInitialized()
        {
            switch (Name)
            {
                case _digitalDesigns:
                    ProductType = _digitalDesignsES;
                    //Llamar a servicio para GET de disenos digitales
                    var p1 = new ProductDto
                    {
                        Id = new Guid("f749e0cd-1917-401e-a8da-27e2d88da463"),
                        Name = "Pepsico",
                        Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                        ImageSource = @"img\digitalDesigns\Pepsico.png",
                        Price = 1500,
                        ProductType = Name
                        
                    };
                    var p2 = new ProductDto
                    {
                        Id = new Guid("0cc2a3ba-1b4b-412c-a64d-5b5d0e52f21c"),
                        Name = "Cisco",
                        Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                        ImageSource = @"img\digitalDesigns\cisco.png",
                        Price = 500,
                        ProductType = Name
                    };

                    ProductList.Add(p1);
                    ProductList.Add(p2);

                    break;

                case _paintings:
                    ProductType = _paintingsES;
                    //Llamar a servicio para GET de pinturas
                    var p3 = new ProductDto
                    {
                        Id = new Guid("40f02bfa-f8de-4301-aacf-1dfa8a49cc73"),
                        Name = "Hombre con Manzana",
                        Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                        ImageSource = @"img\paintings\man.jpg",
                        Price = 2500,
                        ProductType = Name
                    };

                    var p4 = new ProductDto
                    {
                        Id = new Guid("fdb439d7-3a85-4020-9e17-7b87e57d5eeb"),
                        Name = "Monalisa",
                        Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                        ImageSource = @"img\paintings\monalisa.jpg",
                        Price = 1500,
                        ProductType = Name
                    };

                    var p5 = new ProductDto
                    {
                        Id = new Guid("7a187307-6639-4243-b932-729488a0d789"),
                        Name = "Dia de lluvia",
                        Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                        ImageSource = @"img\paintings\rainyDay.jpg",
                        Price = 1000,
                        ProductType = Name
                    };

                    var p6 = new ProductDto
                    {
                        Id = new Guid("f1d40888-54d2-4dc8-9637-2f3c24096489"),
                        Name = "Paisaje",
                        Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                        ImageSource = @"img\paintings\Ross.png",
                        Price = 1500,
                        ProductType = Name
                    };

                    ProductList.Add(p3);
                    ProductList.Add(p4);
                    ProductList.Add(p5);
                    ProductList.Add(p6);

                    break;

                case _merchandising:
                    ProductType = _merchandisingES;
                    //Llamar a servicio para GET de merch.

                    var p7 = new ProductDto
                    {
                        Id = new Guid("f749e0cd-1917-401e-a8da-27e2d88da463"),
                        Name = "Remera Kill em' All",
                        Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                        ImageSource = @"img\merch\metallica.png",
                        Price = 500,
                        ProductType = Name
                    };

                    var p8 = new ProductDto
                    {
                        Id = new Guid("52c007e5-4b58-4e61-91fc-b8b95a430bb9"),
                        Name = "Remera Ride The Lighting",
                        Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                        ImageSource = @"img\merch\RideTheLighting.png",
                        Price = 600,
                        ProductType = Name
                    };
                    var p9 = new ProductDto
                    {
                        Id= new Guid("59cc79df-7ea9-4a4a-ab2b-5e598014152b"),
                        Name = "Remera Vintage",
                        Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                        ImageSource = @"img\merch\Vintage.png",
                        Price = 750,
                        ProductType = Name
                    };

                    var p10 = new ProductDto
                    {
                        Id = new Guid("f749e0cd-1917-401e-a8da-27e2d88da463"),
                        Name = "Taza Personalizada",
                        Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                        ImageSource = @"img\merch\Mug.png",
                        Price = 500,
                        ProductType = Name
                    };

                    ProductList.Add(p7);
                    ProductList.Add(p8);
                    ProductList.Add(p9);
                    ProductList.Add(p10);

                    break;              
            }

        }

        #endregion

        #region Events

        private void Add()
        {
            NavigationManager.NavigateTo($"addproduct/{Name}");
        }

        #endregion
    }
}
