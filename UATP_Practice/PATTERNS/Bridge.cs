using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UATP_Practice.PATTERNS
{
    // ----------------------------------------------------------------------------------------------------------------------------------
    // Let's say you're building a drawing application that supports different shapes (e.g., circles and rectangles) and different
    // rendering modes (e.g., raster and vector). You want to decouple the abstraction (shape) from its implementation (rendering),
    // allowing them to vary independently. In this case, you can use the Bridge Pattern.
    // ----------------------------------------------------------------------------------------------------------------------------------

    // ------------------------------------------------------------------------------------
    // First, define an interface that represents the rendering functionality:
    // ------------------------------------------------------------------------------------

    public interface IRenderer
    {
        void RenderCircle(float radius);
        void RenderRectangle(float width, float height);
    }

    // ------------------------------------------------------------------------------------
    // Next, implement the concrete rendering classes:
    // ------------------------------------------------------------------------------------

    public class RasterRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"Rendering circle with radius {radius} in raster mode.");
        }

        public void RenderRectangle(float width, float height)
        {
            Console.WriteLine($"Rendering rectangle with width {width} and height {height} in raster mode.");
        }
    }

    public class VectorRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"Rendering circle with radius {radius} in vector mode.");
        }

        public void RenderRectangle(float width, float height)
        {
            Console.WriteLine($"Rendering rectangle with width {width} and height {height} in vector mode.");
        }
    }

    // ------------------------------------------------------------------------------------
    // Now, define an abstract shape class that will act as the bridge between the shape
    // and the renderer:
    // ------------------------------------------------------------------------------------

    public abstract class BridgeShape
    {
        protected IRenderer renderer;

        protected BridgeShape(IRenderer renderer)
        {
            this.renderer = renderer;
        }

        public abstract void Draw();
    }

    // ------------------------------------------------------------------------------------
    // Next, implement the concrete shape classes
    // ------------------------------------------------------------------------------------

    public class CircleBridge : BridgeShape
    {
        private float radius;

        public CircleBridge(float radius, IRenderer renderer) : base(renderer)
        {
            this.radius = radius;
        }

        public override void Draw()
        {
            renderer.RenderCircle(radius);
        }
    }

    public class RectangleBridge : BridgeShape
    {
        private float width;
        private float height;

        public RectangleBridge(float width, float height, IRenderer renderer) : base(renderer)
        {
            this.width = width;
            this.height = height;
        }

        public override void Draw()
        {
            renderer.RenderRectangle(width, height);
        }
    }

    // ----------------------------------------------------------------------------------------------------------------------------------
    // The Bridge Pattern promotes flexibility and extensibility in your code, as you can introduce new shapes and renderers without
    // impacting each other. It also allows you to switch or add new rendering modes without modifying the existing shape classes. This
    // decoupling between the abstraction and its implementation simplifies the maintenance and evolution of the drawing application, as
    // changes in one part of the system are isolated from the other. Additionally, the Bridge Pattern enables you to achieve a cleaner
    // and more modular code structure by separating concerns and adhering to the principle of composition over inheritance.
    // ----------------------------------------------------------------------------------------------------------------------------------
    // In the provided code, the "bridge" refers to the BridgeShape abstract class. It acts as a bridge between the shape classes
    // (CircleBridge and RectangleBridge) and the renderer classes (IRenderer, RasterRenderer, and VectorRenderer). The purpose of the
    // bridge is to decouple the shape classes from the renderer implementation.
    // ----------------------------------------------------------------------------------------------------------------------------------

}
