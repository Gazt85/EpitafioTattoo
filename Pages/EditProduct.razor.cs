using Entities.Data_Transfer_Objects;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Inputs;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EpitafioTattoo.Pages
{
    public partial class EditProduct : ComponentBase
    {
        #region Properties        

        [Parameter]
        public Guid Id { get; set; }       

        public ProductToUpdateDto Model { get; set; }

        public DirectoryInfo Directory { get; set; }

        public Syncfusion.Blazor.Inputs.Internal.UploadFiles UploadFile { get; set; }

        private const string _digitalDesigns = "digitalDesigns";
        private const string _paintings = "paintings";
        private const string _merchandising = "merchandising";

        //test
        public List<ProductDto> ProductList { get; set; } = new List<ProductDto>();

        #endregion


        #region Life Cycle Methods

        protected override void OnInitialized()
        {           

            //test
            var p7 = new ProductDto
            {
                Id = new Guid("f749e0cd-1917-401e-a8da-27e2d88da463"),
                Name = "Remera Kill em' All",
                Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                ImageSource = @"img\merch\metallica.png",
                Price = 500
            };

            var p8 = new ProductDto
            {
                Id = new Guid("52c007e5-4b58-4e61-91fc-b8b95a430bb9"),
                Name = "Remera Ride The Lighting",
                Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                ImageSource = @"img\merch\RideTheLighting.png",
                Price = 600
            };
            var p9 = new ProductDto
            {
                Id = new Guid("59cc79df-7ea9-4a4a-ab2b-5e598014152b"),
                Name = "Remera Vintage",
                Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                ImageSource = @"img\merch\Vintage.png",
                Price = 750,
                ProductType = "merchandising"
            };

            var p10 = new ProductDto
            {
                Id = new Guid("f749e0cd-1917-401e-a8da-27e2d88da463"),
                Name = "Taza Personalizada",
                Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                ImageSource = @"img\merch\Mug.png",
                Price = 500
            };

            ProductList.Add(p7);
            ProductList.Add(p8);
            ProductList.Add(p9);
            ProductList.Add(p10);

            var prod = ProductList.FirstOrDefault(x => x.Id == Id);

            if(prod != null)
            {
                Model = new ProductToUpdateDto
                {
                    Id = Id,
                    Price = prod.Price,
                    Name = prod.Name,
                    ImageSource = prod.ImageSource,
                    Description = prod.Description,

                };
            }

            //fin test

            switch (prod.ProductType)
            {
                case _digitalDesigns:
                    Directory = new DirectoryInfo(@$"{Environment.CurrentDirectory}\wwwroot\img\digitalDesigns");
                    break;

                case _paintings:
                    Directory = new DirectoryInfo(@$"{Environment.CurrentDirectory}\wwwroot\img\paintings");
                    break;

                case _merchandising:
                    Directory = new DirectoryInfo(@$"{Environment.CurrentDirectory}\wwwroot\img\merch");
                    break;
            }
        }

        

        #endregion

        #region Events
        
        protected async Task HandleSubmit()
        {
            if (UploadFile != null)
            {
                UploadNewImageFile();
                DeletePreviousImage();
            }
           
        }

       

        private void Upload_OnChange(UploadChangeEventArgs args)
        {
           
            foreach (var file in args.Files)
            {
                UploadFile = file;               
            }
        }

        #endregion

        private void UploadNewImageFile()
        {
            string path = @$"{Directory}\{UploadFile.FileInfo.Name}";
            FileStream filestream = new FileStream(path, FileMode.Create, FileAccess.Write);

            UploadFile.Stream.WriteTo(filestream);
            filestream.Close();
            UploadFile.Stream.Close();
        }

        private void DeletePreviousImage()
        {
            try
            {
                var lastSlashIndex = Model.ImageSource.LastIndexOf(@"\");

                if (lastSlashIndex > 0)
                {
                    var imageName = Model.ImageSource.Substring(lastSlashIndex + 1);

                    if (File.Exists(Path.Combine(Directory.ToString(), imageName)))
                    {
                        // If file found, delete it    
                        File.Delete(Path.Combine(Directory.ToString(), imageName));
                    }
                }               
            }

            catch (IOException ioExp)
            {
                Console.WriteLine(ioExp.Message);
            }
        }
    }
}
