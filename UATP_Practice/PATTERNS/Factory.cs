using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UATP_Practice.PATTERNS
{
    // ----------------------------------------------------------------------------------------------------------------------------------
    // Document: The Document class represents the abstract product. It defines the common interface that all concrete document classes
    // must implement. In the Factory Pattern, this is typically an abstract class or interface that represents the product being created.
    // ----------------------------------------------------------------------------------------------------------------------------------

    // Abstract Document class
    public abstract class Document
    {
        public string Title { get; set; }

        public abstract void Print();
    }

    // ----------------------------------------------------------------------------------------------------------------------------------
    // Concrete Document classes: The Resume, Report, and Letter classes are concrete implementations of the Document class. Each
    // concrete class provides its own implementation of the Print method. These classes represent the specific products that can be
    // created by the factory.
    // ----------------------------------------------------------------------------------------------------------------------------------
    // Concrete Document classes
    public class Resume : Document
    {
        public override void Print()
        {
            Console.WriteLine("Printing Resume: " + Title);
        }
    }

    public class Report : Document
    {
        public override void Print()
        {
            Console.WriteLine("Printing Report: " + Title);
        }
    }

    public class Letter : Document
    {
        public override void Print()
        {
            Console.WriteLine("Printing Letter: " + Title);
        }
    }

    // ----------------------------------------------------------------------------------------------------------------------------------
    // Document Creator: The DocumentCreator class represents the abstract factory. It defines an abstract method CreateDocument that
    // returns a Document object. This abstract method serves as the factory method that encapsulates the object creation logic
    // ----------------------------------------------------------------------------------------------------------------------------------
    // Document Creator
    public abstract class DocumentCreator
    {
        public abstract Document CreateDocument();
    }

    // ----------------------------------------------------------------------------------------------------------------------------------
    // Concrete Document Creator classes: The ResumeCreator, ReportCreator, and LetterCreator classes are concrete implementations of the
    // DocumentCreator class. Each concrete creator class provides its own implementation of the CreateDocument method. These classes are
    // responsible for creating specific instances of the Document objects, which correspond to the concrete products.
    // ----------------------------------------------------------------------------------------------------------------------------------
    // Concrete Document Creator classes
    public class ResumeCreator : DocumentCreator
    {
        public override Document CreateDocument()
        {
            return new Resume();
        }
    }

    public class ReportCreator : DocumentCreator
    {
        public override Document CreateDocument()
        {
            return new Report();
        }
    }

    public class LetterCreator : DocumentCreator
    {
        public override Document CreateDocument()
        {
            return new Letter();
        }
    }

    // ----------------------------------------------------------------------------------------------------------------------------------
    // By utilizing the Factory Pattern, the client code can use the factory objects (DocumentCreator instances) to create concrete
    // Document objects without explicitly knowing the specific class to instantiate. The client only interacts with the abstract factory
    // interface (DocumentCreator) and relies on polymorphism to create the appropriate concrete Document objects.
    // ----------------------------------------------------------------------------------------------------------------------------------
}
