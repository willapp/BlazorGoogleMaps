using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleMapsComponents.Maps
{
    /// <summary>
    /// A circle on the Earth's surface; also known as a "spherical cap".
    /// </summary>
    public class Circle : GoogleMapObjectRef
    {
        /// <summary>
        /// Create a circle using the passed CircleOptions, which specify the center, radius, and style.
        /// </summary>
        /// <param name="opts"></param>
        public async static Task<Circle> CreateAsync(IJSRuntime jsRuntime, CircleOptions opts = null)
        {
            var jsObjectRef = await JsObjectRef.CreateAsync(jsRuntime, "google.maps.Circle", opts);
            var obj = new Circle(jsObjectRef);

            return obj;
        }

        private Circle(JsObjectRef jsObjectRef)
            : base(jsObjectRef)
        {
        }

        /// <summary>
        /// Gets the LatLngBounds of this Circle.
        /// </summary>
        /// <returns></returns>
        public Task<LatLngBoundsLiteral> GetBounds()
        {
            return InvokeAsync<LatLngBoundsLiteral>("getBounds");
        }

        /// <summary>
        /// Returns the center of this circle.
        /// </summary>
        /// <returns></returns>
        public Task<LatLngLiteral> GetCenter()
        {
            return InvokeAsync<LatLngLiteral>("getCenter");
        }

        /// <summary>
        /// Returns whether this circle can be dragged by the user.
        /// </summary>
        /// <returns></returns>
        public Task<bool> GetDraggable()
        {
            return InvokeAsync<bool>("getDraggable");
        }

        /// <summary>
        /// Returns whether this circle can be edited by the user.
        /// </summary>
        /// <returns></returns>
        public Task<bool> GetEditable()
        {
            return InvokeAsync<bool>("getEditable");
        }

        /// <summary>
        /// Returns the map on which this circle is displayed.
        /// </summary>
        /// <returns></returns>
        public Task<Map> GetMap()
        {
            return InvokeAsync<Map>("getMap");
        }

        /// <summary>
        /// Returns the radius of this circle (in meters).
        /// </summary>
        /// <returns></returns>
        public Task<double> GetRadius()
        {
            return InvokeAsync<double>("getRadius");
        }

        /// <summary>
        /// Returns whether this circle is visible on the map.
        /// </summary>
        /// <returns></returns>
        public Task<bool> GetVisible()
        {
            return InvokeAsync<bool>("getVisible");
        }

        /// <summary>
        /// Sets the center of this circle.
        /// </summary>
        /// <param name="center"></param>
        public Task SetCenter(LatLngLiteral center)
        {
            return InvokeAsync("setCenter", center);
        }

        /// <summary>
        /// If set to true, the user can drag this circle over the map.
        /// </summary>
        /// <param name="draggable"></param>
        public Task SetDraggable(bool draggable)
        {
            return InvokeAsync("setDraggable", draggable);
        }

        /// <summary>
        /// If set to true, the user can edit this circle by dragging the control points shown at the center and around the circumference of the circle.
        /// </summary>
        /// <param name="editable"></param>
        public Task SetEditable(bool editable)
        {
            return InvokeAsync("setEditable", editable);
        }

        /// <summary>
        /// Renders the circle on the specified map. If map is set to null, the circle will be removed.
        /// </summary>
        /// <param name="map"></param>
        public Task SetMap(Map map)
        {
            return InvokeAsync(
                "setMap",
                map);
        }

        public Task SetOptions(CircleOptions options)
        {
            return InvokeAsync("setOptions", options);
        }

        /// <summary>
        /// Sets the radius of this circle (in meters).
        /// </summary>
        /// <param name="radius"></param>
        public Task SetRadius(double radius)
        {
            return InvokeAsync("setRadius", radius);
        }

        /// <summary>
        /// Hides this circle if set to false.
        /// </summary>
        /// <param name="visible"></param>
        public Task SetVisible(bool visible)
        {
            return InvokeAsync("setVisible", visible);
        }
    }
}
