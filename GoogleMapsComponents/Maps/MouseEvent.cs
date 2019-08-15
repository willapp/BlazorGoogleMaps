using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleMapsComponents.Maps
{
    /// <summary>
    /// This object is returned from various mouse events on the map and overlays.
    /// </summary>
    public class MouseEvent : GoogleMapObjectRef
    {
        public MouseEvent(JsObjectRef jsObjectRef)
            : base(jsObjectRef)
        {
        }


        /// <summary>
        /// The latitude/longitude that was below the cursor when the event occurred.
        /// </summary>
        public Task<LatLngLiteral> LatLng
        {
            get { return GetJson<LatLngLiteral>("latLng"); }
        }

        /// <summary>
        /// Prevents this event from propagating further.
        /// </summary>
        public void Stop()
        {
            _ = InvokeAsync("stop");
        }
    }
}
