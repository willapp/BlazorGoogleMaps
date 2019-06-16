using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleMapsComponents.Maps.TheData
{
    /// <summary>
    /// google.maps.Data.MouseEvent interface
    /// This object is passed to mouse event handlers on a Data object. 
    /// This interface extends MouseEvent.
    /// </summary>
    public class MouseEvent : Maps.MouseEvent
    {
        public Feature Feature { get; set; }
    }
}
