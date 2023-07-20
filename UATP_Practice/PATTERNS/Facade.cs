using System;
using System.Collections.Generic;
using System.Net;
using HtmlAgilityPack;

namespace UATP_Practice.PATTERNS
{

    // ----------------------------------------------------------------------------------------------------------------------------------
    // In this updated example, the WebScraperFacade class acts as a facade, encapsulating the complexity of web scraping and providing a
    // simplified interface for the client code.
    // ----------------------------------------------------------------------------------------------------------------------------------
    // The Scrape method is responsible for downloading the HTML content and calling the ExtractFields method to extract the desired
    // fields from the web page. The ExtractFields method encapsulates the logic for extracting each field, such as ExtractField1 and
    // ExtractField2.
    // ----------------------------------------------------------------------------------------------------------------------------------
    // The client code interacts with the facade class by calling the GetField and SetField methods to access and modify the fields,
    // respectively. These methods use the internal _fields dictionary to get and set the field values.
    // ----------------------------------------------------------------------------------------------------------------------------------
    // Overall, this updated example demonstrates the Facade Pattern by providing a simplified interface (Scrape, GetField, SetField)
    // that hides the complexity of the web scraping process and encapsulates the internal logic of extracting and managing the fields.
    // ----------------------------------------------------------------------------------------------------------------------------------

    // Facade Pattern - Web Scraper
    public class WebScraperFacade
    {
        private WebClient _webClient;
        private HtmlDocument _htmlDocument;
        private Dictionary<string, string> _fields;

        public WebScraperFacade()
        {
            _webClient = new WebClient();
            _htmlDocument = new HtmlDocument();
            _fields = new Dictionary<string, string>();
        }

        public void Scrape(string url)
        {
            string html = _webClient.DownloadString(url);
            _htmlDocument.LoadHtml(html);

            ExtractFields();
        }

        private void ExtractFields()
        {
            // Logic to extract the desired fields from the web page
            // ...

            // Example: Extracting field1
            string field1 = ExtractField1();
            _fields["Field1"] = field1;

            // Example: Extracting field2
            string field2 = ExtractField2();
            _fields["Field2"] = field2;

            // ... extract remaining fields ...
        }

        private string ExtractField1()
        {
            // Logic to extract Field1 from the web page
            // ...

            return "Field1 Value";
        }

        private string ExtractField2()
        {
            // Logic to extract Field2 from the web page
            // ...

            return "Field2 Value";
        }

        public string GetField(string fieldName)
        {
            if (_fields.ContainsKey(fieldName))
            {
                return _fields[fieldName];
            }
            else
            {
                throw new ArgumentException("Invalid field name");
            }
        }

        public void SetField(string fieldName, string value)
        {
            if (_fields.ContainsKey(fieldName))
            {
                _fields[fieldName] = value;
            }
            else
            {
                throw new ArgumentException("Invalid field name");
            }
        }
    }

    // ----------------------------------------------------------------------------------------------------------------------------------
    // The Facade Pattern aims to provide a simplified interface that hides the complexities of a subsystem or a set of classes. It
    // promotes loose coupling between the client code and the subsystem, making it easier to use and understand.
    // ----------------------------------------------------------------------------------------------------------------------------------
    // In the context of web scraping, the subsystem represents the complex operations involved in downloading web pages, parsing HTML,
    // and extracting specific fields. The Facade class, WebScraperFacade, acts as an interface to this subsystem and provides a simplified
    // way to interact with it.
    // ----------------------------------------------------------------------------------------------------------------------------------
}
