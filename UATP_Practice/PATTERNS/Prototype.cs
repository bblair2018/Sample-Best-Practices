using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UATP_Practice.PATTERNS
{
    // ------------------------------------------------------------------------------------
    // First, we define the abstract Shape class and implement concrete shape classes:
    // ------------------------------------------------------------------------------------

    /// <summary>
    /// This is the prototype base class that defines the contract for cloning itself 
    /// (Clone method) and drawing the shape (Draw method). It serves as the common 
    /// interface for all concrete shape classes.
    /// </summary>
    public abstract class Shape : ICloneable
    {
        public abstract object Clone();
        public abstract void Draw();
    }

    // ------------------------------------------------------------------------------------
    // These are the concrete implementations of the Shape class. They provide specific
    // behavior for cloning themselves (Clone method) and drawing their respective shapes
    // (Draw method).
    // ------------------------------------------------------------------------------------

    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override object Clone()
        {
            return new Rectangle { Width = this.Width, Height = this.Height };
        }

        public override void Draw()
        {
            Console.WriteLine($"Rectangle: Width={Width}, Height={Height}");
        }
    }

    public class Circle : Shape
    {
        public int Radius { get; set; }

        public override object Clone()
        {
            return new Circle { Radius = this.Radius };
        }

        public override void Draw()
        {
            Console.WriteLine($"Circle: Radius={Radius}");
        }
    }

    // ------------------------------------------------------------------------------------
    // Next, we create a ShapeCache class to serve as a prototype manager
    // ------------------------------------------------------------------------------------
    // This class acts as a prototype manager and holds a cache of pre-created shape objects.
    // It provides a method GetShape to retrieve a cloned shape from the cache based on a
    // given key (shape type). If the requested shape is not found in the cache,
    // it throws an exception. The LoadCache method initializes the cache with some
    // pre-defined shapes (Rectangle and Circle) for demonstration purposes.
    // ------------------------------------------------------------------------------------

    public class ShapeCache
    {
        private static Dictionary<string, Shape> shapeCache = new Dictionary<string, Shape>();

        public static Shape GetShape(string shapeKey)
        {
            Shape cachedShape = shapeCache.GetValueOrDefault(shapeKey);
            if (cachedShape == null)
            {
                throw new ArgumentException("Shape not found in cache.", nameof(shapeKey));
            }
            return (Shape)cachedShape.Clone(); // Cast the cloned object back to Shape
        }

        public static void LoadCache()
        {
            Rectangle rectangle = new Rectangle { Width = 100, Height = 50 };
            shapeCache["Rectangle"] = rectangle;

            Circle circle = new Circle { Radius = 50 };
            shapeCache["Circle"] = circle;
        }
    }

    // ----------------------------------------------------------------------------------------------------------------------------------
    // The key part of the Prototype Pattern is the Clone method in the concrete shape classes (Rectangle and Circle). Instead of using
    // the new keyword to create a new instance, they return a clone of themselves. This way, when a client needs a new shape, the
    // Prototype Pattern allows them to get a copy of an existing shape (prototype) from the cache and modify it, rather than creating
    // a new shape from scratch.
    // ----------------------------------------------------------------------------------------------------------------------------------
    // The code supports the Prototype Pattern through the implementation of the Shape class hierarchy and the ShapeCache class.
    // The Prototype Pattern is a creational design pattern that allows you to create new objects by copying or cloning existing objects,
    // without making the client code dependent on the concrete classes.
    // ----------------------------------------------------------------------------------------------------------------------------------

}
