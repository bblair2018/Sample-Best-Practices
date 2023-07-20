using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UATP_Practice.PATTERNS
{
    // ----------------------------------------------------------------------------------------------------------------------------------
    // Imagine you're developing a document processing application that works with different types of documents such as PDF, Word, and
    // Excel. You want to implement a feature that allows visitors to extract text content from these documents. In this scenario, the
    // Visitor Pattern can be used to define a visitor interface and concrete visitors for each document type.
    // ----------------------------------------------------------------------------------------------------------------------------------

    // ------------------------------------------------------------------------------------
    // Visitor interface
    // The IDocumentVisitor interface defines the contract for different visitors. It
    // declares the Visit method, which represents the operation that each visitor performs
    // on the documents.
    // ------------------------------------------------------------------------------------
    public interface IDocumentVisitor
    {
        void Visit(VisitorDocument document);
    }

    // ------------------------------------------------------------------------------------
    // The VisitorDocument class is an abstract base class representing different types
    // of documents. It declares the abstract Accept method to accept a visitor.
    // ------------------------------------------------------------------------------------

    // ------------------------------------------------------------------------------------
    // Abstract VisitorDocument class
    // The VisitorDocument class is an abstract base class representing different types of
    // documents. It declares the abstract Accept method, which accepts a visitor. The
    // concrete document classes (PdfDocument, WordDocument, and ExcelDocument) extend this
    // base class and implement the Accept method, invoking the corresponding Visit method
    // on the visitor.
    // ------------------------------------------------------------------------------------
    public abstract class VisitorDocument
    {
        public abstract void Accept(IDocumentVisitor visitor);
    }

    // ------------------------------------------------------------------------------------
    // The PdfDocument, WordDocument, and ExcelDocument classes are concrete document
    // classes that extend the VisitorDocument base class. They implement the Accept method
    // by invoking the corresponding visit method on the visitor.
    // ------------------------------------------------------------------------------------

    // Concrete PdfDocument class
    public class PdfDocument : VisitorDocument
    {
        /// <summary>
        /// The purpose of the Accept method is to allow a visitor to visit or operate on the current document element. 
        /// It serves as the entry point for the visitor to perform its specific behavior on the document.
        /// </summary>
        /// <param name="visitor">IDocumentVisitor is a reference to the visitor that will perform the operation on the document.</param>
        /// <remarks>In simpler terms, the Accept method allows the document element to accept or welcome a visitor and gives the visitor 
        /// the opportunity to interact with and operate on the document. The actual operation performed by the visitor depends on the concrete 
        /// implementation of the Visit method in the specific visitor class (TextExtractorVisitor or any other visitor class if implemented).</remarks>
        public override void Accept(IDocumentVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void ExtractText()
        {
            Console.WriteLine("Extracting text from PDF document...");
        }
    }

    // Concrete WordDocument class
    public class WordDocument : VisitorDocument
    {
        public override void Accept(IDocumentVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void ExtractText()
        {
            Console.WriteLine("Extracting text from Word document...");
        }
    }

    // Concrete ExcelDocument class
    public class ExcelDocument : VisitorDocument
    {
        public override void Accept(IDocumentVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void ExtractText()
        {
            Console.WriteLine("Extracting text from Excel document...");
        }
    }

    // ------------------------------------------------------------------------------------
    // The TextExtractorVisitor class is a concrete visitor that implements the
    // IDocumentVisitor interface. It provides the Visit method to handle visiting a
    // VisitorDocument instance. It checks the type of the document and invokes the
    // appropriate ExtractText method to extract text content.
    // ------------------------------------------------------------------------------------

    // Concrete visitor to extract text from documents
    public class TextExtractorVisitor : IDocumentVisitor
    {
        public void Visit(VisitorDocument document)
        {
            if (document is PdfDocument pdf)
            {
                pdf.ExtractText();
            }
            else if (document is WordDocument word)
            {
                word.ExtractText();
            }
            else if (document is ExcelDocument excel)
            {
                excel.ExtractText();
            }
        }
    }

    // ----------------------------------------------------------------------------------------------------------------------------------
    // By utilizing the Visitor Pattern, we achieve separation between the document hierarchy and the operations performed on them.
    // The visitor encapsulates the operations, allowing us to extend functionality without modifying the document classes.
    // ----------------------------------------------------------------------------------------------------------------------------------
    // The code above implements the Visitor design pattern to support the extraction of text content from different types of documents
    // (PDF, Word, and Excel) in a document processing application. The Visitor Pattern separates the document hierarchy from the
    // operations performed on them by defining a visitor interface and concrete visitors for each document type.
    // ----------------------------------------------------------------------------------------------------------------------------------
    // The Visitor pattern is a behavioral design pattern that allows you to add new behaviors or operations to a set of objects without
    // modifying the objects themselves. It achieves this by separating the algorithm (behavior) from the object structure, enabling the
    // addition of new algorithms (visitors) without changing the existing classes.
    // ----------------------------------------------------------------------------------------------------------------------------------

}
