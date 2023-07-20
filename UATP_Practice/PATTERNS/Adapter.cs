using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UATP_Practice.PATTERNS
{
    // ----------------------------------------------------------------------------------------------------------------------------------
    // Let's imagine we have an existing LegacyRectangle class that represents rectangles in our legacy system. However, we need to use a
    // new ShapeRenderer class that expects an interface called IShape to render shapes. To bridge the gap between the existing
    // LegacyRectangle and the IShape interface, we can use the Adapter Pattern.
    // ----------------------------------------------------------------------------------------------------------------------------------

    // ------------------------------------------------------------------------------------
    // First, we define the IShape interface that represents the required interface for
    // rendering shapes:
    // ------------------------------------------------------------------------------------

    public interface IShape
    {
        void Draw();
    }

    // ------------------------------------------------------------------------------------
    // Next, we have the existing LegacyRectangle class that we want to adapt to the IShape
    // interface:
    // ------------------------------------------------------------------------------------

    public class LegacyRectangle
    {
        public void DisplayRectangle()
        {
            Console.WriteLine("Legacy Rectangle: Displaying rectangle.");
        }
    }

    // ------------------------------------------------------------------------------------
    // To create the adapter, we implement a class called RectangleAdapter that adapts the
    // LegacyRectangle to the IShape interface:
    // ------------------------------------------------------------------------------------

    public class RectangleAdapter : IShape
    {
        private readonly LegacyRectangle legacyRectangle;

        public RectangleAdapter(LegacyRectangle rectangle)
        {
            legacyRectangle = rectangle;
        }

        public void Draw()
        {
            legacyRectangle.DisplayRectangle();
        }
    }

    // ------------------------------------------------------------------------------------
    // This is a new shape that is NOT legacy.
    // ------------------------------------------------------------------------------------

    public class NewTriangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("New Triangle: Drawing triangle.");
        }
    }

    // ------------------------------------------------------------------------------------
    // This a ShapeRenderer that works with any shape, legacy or new.
    // ------------------------------------------------------------------------------------

    public class ShapeRenderer
    {
        public void RenderShape(IShape shape)
        {
            shape.Draw();
        }
    }

    // ----------------------------------------------------------------------------------------------------------------------------------
    // In this example, the RectangleAdapter acts as an adapter that enables the LegacyRectangle to be used as an IShape by converting
    // the Draw method call into a call to DisplayRectangle. The ShapeRenderer is able to work with any shape, whether it's a
    // LegacyRectangle adapted through RectangleAdapter or a NewTriangle, because both implement the IShape interface.
    // ----------------------------------------------------------------------------------------------------------------------------------
    // The Adapter pattern allows the LegacyRectangle class, which has a different interface, to be used alongside the IShape interface
    // without modifying the existing code. It facilitates the interaction between the client code and the incompatible LegacyRectangle
    // class by providing a consistent interface (IShape) for all shapes.
    // ----------------------------------------------------------------------------------------------------------------------------------
}
