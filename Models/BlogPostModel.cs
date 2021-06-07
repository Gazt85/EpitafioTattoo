using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EpitafioTattoo.Models
{
    /// <summary>
    /// This class represents the full blogpost.
    /// </summary>
    public class BlogPostModel
    {
        public string Title { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }
    }
}
