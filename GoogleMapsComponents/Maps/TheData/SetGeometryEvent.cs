using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleMapsComponents.Maps.TheData
{
    /// <summary>
    /// google.maps.Data.SetGeometryEvent interface 
    /// </summary>
    public class SetGeometryEvent
    {
        /// <summary>
        /// The feature whose geometry was set.
        /// </summary>
        public Feature Feature { get; set; }

        /// <summary>
        /// The new feature geometry.
        /// </summary>
        public Geometry NewGeometry { get; set; }

        /// <summary>
        /// The previous feature geometry.
        /// </summary>
        public Geometry OldGeometry { get; set; }
    }
}
