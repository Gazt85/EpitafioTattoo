﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EpitafioTattoo.Shared
{
    public partial class Thumbnail : ComponentBase
    {
        [Parameter]
        public string Source { get; set; }
    }
    
}
