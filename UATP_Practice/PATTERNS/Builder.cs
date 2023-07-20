using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UATP_Practice.PATTERNS
{
    public class Email
    {
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }

    public class EmailBuilder
    {
        private Email email;

        public EmailBuilder()
        {
            email = new Email();
        }

        public EmailBuilder From(string sender)
        {
            email.Sender = sender;
            return this;
        }

        public EmailBuilder To(string recipient)
        {
            email.Recipient = recipient;
            return this;
        }

        public EmailBuilder WithSubject(string subject)
        {
            email.Subject = subject;
            return this;
        }

        public EmailBuilder WithBody(string body)
        {
            email.Body = body;
            return this;
        }

        public Email Build()
        {
            // Perform any additional validation or configuration if needed
            return email;
        }
    }

    // ----------------------------------------------------------------------------------------------------------------------------------
    // Overall, this example follows the principles of the Builder pattern by providing a builder class (EmailBuilder) that constructs
    // a complex object (Email) step by step, allowing for fluent and customizable object creation.
    // ----------------------------------------------------------------------------------------------------------------------------------

}
