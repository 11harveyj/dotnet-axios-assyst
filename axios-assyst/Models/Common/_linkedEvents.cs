﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst.Models.Common
{
    public class _linkedEvents
    {
        public int id { get; set; }
        public Models.Endpoints._event linkedEvent { get; set; }

        public _linkedEvents (Models.Endpoints._event @event)
        {
            this.linkedEvent = @event;
        }
    }
}
