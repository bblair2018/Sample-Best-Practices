using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using UATP_Practice.CLASSES;

namespace UATP_Practice.PATTERNS
{
    // ----------------------------------------------------------------------------------------------------------------------------------
    // Imagine you're developing a chat application that allows multiple users to communicate with each other. In this scenario,
    // the Mediator Pattern can be used to facilitate communication between users without direct dependencies between them.
    // ----------------------------------------------------------------------------------------------------------------------------------

    // ------------------------------------------------------------------------------------
    // The IChatMediator interface declares the methods that the mediator class should
    // implement. It defines the contract for sending messages and adding users to the chat.
    // ------------------------------------------------------------------------------------
    public interface IChatMediator
    {
        void SendMessage(string message, User sender);
        void AddUser(User user);
    }

    // ------------------------------------------------------------------------------------
    // The ChatMediator class implements the IChatMediator interface. It serves as the
    // concrete mediator class responsible for managing users and facilitating communication
    // between them.
    // - The _users field stores a list of users participating in the chat.
    // - The constructor initializes the _users list.
    // - The AddUser method adds a user to the _users list.
    // - The SendMessage method sends a message to all users except the sender.
    //   It iterates over the _users list and calls the ReceiveMessage method
    //   on each user, passing the message.
    // ------------------------------------------------------------------------------------
    public class ChatMediator : IChatMediator
    {
        private List<User> _users;

        public ChatMediator()
        {
            _users = new List<User>();
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public void SendMessage(string message, User sender)
        {
            foreach (var user in _users)
            {
                if (user != sender)
                {
                    user.ReceiveMessage(message);
                }
            }
        }
    }

    // ------------------------------------------------------------------------------------
    // The User class is the abstract base class representing the colleagues (users) in
    // the chat application.
    // - The _mediator field holds a reference to the chat mediator that handles the communication.
    // - The Name property represents the user's name.
    // - The constructor sets the Name and _mediator fields.
    // - The SendMessage method is used by a user to send a message. It delegates the responsibility
    //   of sending the message to the _mediator by calling the SendMessage method, passing the message
    //   and the current user instance.
    // - The ReceiveMessage method is declared as abstract, as each concrete user class
    //   will implement its own way of receiving and processing messages.
    // ------------------------------------------------------------------------------------
    public abstract class User
    {
        protected IChatMediator _mediator;

        public string Name { get; }

        public User(string name, IChatMediator mediator)
        {
            Name = name;
            _mediator = mediator;
        }

        public virtual void SendMessage(string message)
        {
            Console.WriteLine($"{Name} --> sends message: {message}");
            _mediator.SendMessage(message, this);
        }

        public abstract void ReceiveMessage(string message);
    }

    // ------------------------------------------------------------------------------------
    // The ChatUser class is a concrete implementation of the User class, representing
    // individual users in the chat application.
    // - The constructor calls the base class constructor, passing the name and mediator.
    // - The ReceiveMessage method is overridden to handle receiving a message. In this example,
    //   it simply displays the received message on the console, along with the user's name.
    // ------------------------------------------------------------------------------------
    public class ChatUser : User
    {
        public ChatUser(string name, IChatMediator mediator) : base(name, mediator)
        {
        }

        public override void ReceiveMessage(string message)
        {
            Console.WriteLine($"{Name} <-- received message: {message}");
        }
    }
}
