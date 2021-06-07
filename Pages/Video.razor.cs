using EpitafioTattoo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EpitafioTattoo.Pages
{
    public partial class Video
    {
        #region Properties

        public List<VideoItemModel> VideoItems { get; set; } = new List<VideoItemModel>();

        #endregion

        #region Life Cycle Methods

        protected override void OnInitialized()
        {
            var video1 = new VideoItemModel
            {
                Title = "Tyranny",
                Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                Date = new DateTime(2020, 12, 12),
                ImageSource = "",
                Link = "https://www.youtube.com/watch?v=0HU1rMDGyB8&t=202s"

            };

            var video2 = new VideoItemModel
            {
                Title = "Nerium",
                Description = "This is a wider card with supporting text below as a natural lead-in to additional content.This is a wider card with supporting text below as a natural lead-in to additional content",
                Date = new DateTime(2020, 12, 12),
                ImageSource = @"img\Eka logo.jpeg",
                Link = "https://www.youtube.com/watch?v=BL2NHqc74sQ&ab_channel=NERIUMOFFICIALNERIUMOFFICIAL"

            };

            var video3 = new VideoItemModel
            {
                Title = "Whiskey Blues",
                Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                Date = new DateTime(2020, 12, 12),
                ImageSource = @"img\tattoo\leon.jpeg",
                Link = "https://www.youtube.com/watch?v=f5jGX9A6ErA&ab_channel=JAZZ%26BLUESJAZZ%26BLUES"

            };

            var video4 = new VideoItemModel
            {
                Title = "Bra vs Ger",
                Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                Date = new DateTime(2020, 12, 12),
                ImageSource = @"img\Eka logo.jpeg",
                Link = "https://www.youtube.com/watch?v=m3HZKHTLHDU&ab_channel=RptimaoTV2RptimaoTV2"


            };

            var video5 = new VideoItemModel
            {
                Title = "The Witcher",
                Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                Date = new DateTime(2020, 12, 12),
                ImageSource = "",
                Link = "https://www.youtube.com/watch?v=PyYlB_MVuLM"

            };

            var video6 = new VideoItemModel
            {
                Title = "Breaking Bad",
                Description = "This is a wider card with supporting text below as a natural lead-in to additional content.",
                Date = new DateTime(2020, 12, 12),
                ImageSource = "",
                Link = "https://www.youtube.com/watch?v=NQ1n5KHTAvo&ab_channel=Shane"

            };

            VideoItems.Add(video1);
            VideoItems.Add(video2);
            VideoItems.Add(video3);
            VideoItems.Add(video4);
            VideoItems.Add(video5);
            VideoItems.Add(video6);
        }       


        #endregion
    }
}
