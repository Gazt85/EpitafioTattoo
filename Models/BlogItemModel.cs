using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EpitafioTattoo.Models
{
    /// <summary>
    /// This class is used for a small presentation
    /// of each blog post. 
    /// </summary>
    public class BlogItemModel
    {
        public string Title { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }
    }
}
