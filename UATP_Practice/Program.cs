using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using UATP_Practice.CLASSES;
using UATP_Practice.PATTERNS;
using UATP_Practice.SOLID;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //SOLID Example
            SOLID();

            //Class Types Example
            AbstractClassExample();
            StaticClass.PrintMessage();
            SealedExample();
            PartialClassExample();
            InnerClassExample();
            refOutExample();

            //Patterns Example
            AbstractFactoryExample();
            AdapterExample();
            BridgeExample();
            BuilderExample();
            ChainOfResponsibilityExample();
            CommandPatternExample();
            CompositeExample();
            DecoratorExample();
            FacadePatternExample();
            FactoryExample();
            FlyWeightExample();
            InterpreterExample();
            IteratorExample();
            MediatorExample();
            MomentoExample();
            ObservableExample();
            PrototypeExample();
            ProxyExample();
            SingletonExample();
            StateExample();
            StrategyExample();
            TemplateExample();
            VistorExample();
                       
        }

        // -------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // SOLID Example - 
        // S - Single Responsibility Principle (SRP): A class should have only one reason to change, meaning it should have a single responsibility or job.
        // O - Open-Closed Principle (OCP): Objects or entities should be open for extension but closed for modification. In other words, new functionality
        //     should be added through extension rather than modifying existing code.
        // L - Liskov Substitution Principle (LSP): Subtypes must be substitutable for their base types, ensuring that objects of a superclass can be replaced
        //     with objects of its subclasses without affecting the correctness of the program.
        // I - Interface Segregation Principle (ISP): Clients should not be forced to depend on interfaces they do not use. This principle encourages creating
        //     specific interfaces for each client instead of having a general-purpose interface.
        // D - Dependency Inversion Principle (DIP): High-level modules should not depend on low-level modules. Both should depend on abstractions.
        //     This principle promotes loose coupling and allows for flexibility and easier testing.
        // -------------------------------------------------------------------------------------------------------------------------------------------------------------------

        #region SOLID Example

        static void SOLID()
        {
            GasEngine gas = new GasEngine();
            ElectricEngine electricEngine = new ElectricEngine();
            Car gasCar = new Car(gas);
            Car eCar = new Car(electricEngine);

            Console.WriteLine(gasCar.start());
            Console.WriteLine(gasCar.stop());

            Console.WriteLine(eCar.start());
            Console.WriteLine(eCar.stop());
        }

        #endregion

        // -------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Class Types Example
        // -------------------------------------------------------------------------------------------------------------------------------------------------------------------

        #region AbstractClassExample

        static void AbstractClassExample()
        {
            AbstractClassAnimal dog = new Dog();
            dog.MakeSound();  // Output: Woof! Woof!
            dog.Sleep();      // Output: Zzzz... Animal is sleeping.

            AbstractClassAnimal cat = new Cat();
            cat.MakeSound();  // Output: Meow! Meow!
            cat.Sleep();      // Output: Zzzz... Animal is sleeping.
        }

        #endregion

        #region SealedExample

        public static void SealedExample()
        {
            SealedCar car = new SealedCar();
            car.Start();  // Output: Car started.

            SealedClassVehicle vehicle = new SealedClassVehicle();
            vehicle.Start();  // Output: Vehicle started.
        }

        #endregion

        #region PartialClassExample

        public static void PartialClassExample()
        {
            PartialClass myObject = new PartialClass();
            myObject.Method1();  // Output: Method1 from File 1
            myObject.Method2();  // Output: Method2 from File 2
        }

        #endregion

        #region InnerClassExample

        public static void InnerClassExample()
        {
            OuterClass outerObj = new OuterClass();
            outerObj.OuterMethod();    // Output: OuterMethod

            OuterClass.InnerClass innerObj = new OuterClass.InnerClass();
            innerObj.InnerMethod();    // Output: InnerMethod
        }

        #endregion

        #region refOutExample

        public static void refOutExample()
        {
            refOutExample example = new refOutExample();
            example.x = 10;

            // Passing a variable using the ref keyword
            example.AddOne(ref example.x);
            Console.WriteLine("x after adding one: " + example.x); // Output: 11

            // Passing a variable using the out keyword
            int y;
            example.MultiplyByTwo(out y);
            Console.WriteLine("y after multiplying by two: " + y); // Output: 20
        }

        #endregion

        // -------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Design patterns are reusable solutions to common software design problems. Here's a list of popular design patterns used in C#, ordered alphabetically:
        // -------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // 1. Abstract Factory Pattern [*]
        // - Provides an interface for creating families of related or dependent objects without specifying their concrete classes.

        // 2. Adapter Pattern [*]
        // - Converts the interface of a class into another interface clients expect, enabling classes to work together that couldn't otherwise due to incompatible interfaces.

        // 3. Bridge Pattern [*]
        // - Decouples an abstraction from its implementation, allowing both to vary independently.

        // 4. Builder Pattern [*]
        // - Separates the construction of an object from its representation, allowing the same construction process to create various representations.

        // 5. Chain of Responsibility Pattern [*]
        // - Avoids coupling the sender of a request to its receiver by giving more than one object a chance to handle the request.

        // 6. Command Pattern [*]
        // - Encapsulates a request as an object, allowing parameterization of clients with different requests, queue or log requests, and support undoable operations

        // 7. Composite Pattern [*]
        // - Composes objects into tree structures to represent part-whole hierarchies, allowing clients to treat individual objects and compositions uniformly.

        // 8. Decorator Pattern [*]
        // - Adds new behaviors to an object dynamically by wrapping it with a decorator class.

        // 9. Facade Pattern [*]
        // - Provides a simplified interface to a complex subsystem, hiding its complexities and making it easier to use.

        // 10. Factory Method Pattern [*]
        // - Defines an interface for creating objects but lets subclasses decide which class to instantiate.

        // 11. Flyweight Pattern [*]
        // - Reduces the memory usage of large numbers of similar objects by sharing common parts of the object's state.

        // 12. Interpreter Pattern [*]
        // - Specifies how to evaluate sentences in a language, allowing the creation of a domain-specific language.

        // 13. Iterator Pattern [*]
        // - Provides a way to access elements of an aggregate object sequentially without exposing its underlying representation.

        // 14. Mediator Pattern [*]
        // - Defines an object that encapsulates how a set of objects interact, promoting loose coupling by keeping objects from referring to each other explicitly.

        // 15. Memento Pattern [*]
        // - Provides the ability to restore an object to its previous state, capturing internal state without violating encapsulation

        // 16. Observer Pattern [*]
        // - Defines a one-to-many dependency between objects, so that when one object changes state, all its dependents are notified and updated automatically.

        // 17. Prototype Pattern [*]
        // - Creates new objects by cloning existing ones, avoiding the need for complex initialization.

        // 19. Proxy Pattern [*]
        // - Provides a surrogate or placeholder object that controls access to another object, allowing additional functionality to be provided when accessing the original object.

        // 18. Singleton Pattern [*]
        // - Ensures that only one instance of a class is created and provides a global point of access to it.

        // 21. State Pattern [*]
        // - Allows an object to alter its behavior when its internal state changes, encapsulating the behavior within separate state classes.

        // 20. Strategy Pattern [*]
        // - Defines a family of interchangeable algorithms, encapsulating each one and making them interchangeable within the same context.

        // 22. Template Method Pattern [*]
        // - Defines the skeleton of an algorithm in a base class, allowing subclasses to override certain steps of the algorithm without changing its structure.

        // 23. Visitor Pattern [*]
        // - Separates an algorithm from an object structure, allowing new operations to be added to the object structure without modifying the objects themselves.

        // -------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // These design patterns are widely used in C# development to address various software design challenges and improve code structure, flexibility, and maintainability.
        // -------------------------------------------------------------------------------------------------------------------------------------------------------------------

        #region AbstractFactoryExample

        public static void AbstractFactoryExample() 
        {
            List<Warrior> warriors = new List<Warrior>();

            Random random = new Random();

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- Start Abstract Factory Pattern");
            Console.WriteLine("--------------------------------------------");

            for (int i = 0; i < 10; i++)
            {
                string name = "Warrior" + (i + 1);

                int berserkRage = random.Next(1, 6);
                int defensiveStance = random.Next(1, 6);
                int swiftStrikes = random.Next(1, 6);

                int factoryIndex = random.Next(0, 2); // Select a random factory (0: Knight, 1: Samurai)
                WarriorFactory factory = factoryIndex == 0 ? new KnightFactory() : new SamuraiFactory();

                Warrior warrior = factory.CreateWarrior(name);
                warrior.BerserkRage = berserkRage;
                warrior.DefensiveStance = defensiveStance;
                warrior.SwiftStrikes = swiftStrikes;

                warriors.Add(warrior);
            }

            foreach (var warrior in warriors)
            {
                warrior.DisplayDetails();
            }

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- End Abstract Factory Pattern");
            Console.WriteLine("--------------------------------------------");
        }

        #endregion

        #region AdapterExample

        public static void AdapterExample()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- Start Adapter Pattern");
            Console.WriteLine("--------------------------------------------");

            //Legacy Adpated Shape.
            LegacyRectangle legacyRectangle = new LegacyRectangle();
            IShape adaptedRectangle = new RectangleAdapter(legacyRectangle);

            //New Shape.
            IShape newTriangle = new NewTriangle();

            ShapeRenderer shapeRenderer = new ShapeRenderer();
            shapeRenderer.RenderShape(adaptedRectangle);
            shapeRenderer.RenderShape(newTriangle);

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- End Adapter Pattern");
            Console.WriteLine("--------------------------------------------");
        }

        #endregion

        #region BridgeExample

        public static void BridgeExample()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- Start Bridge Pattern");
            Console.WriteLine("--------------------------------------------");

            IRenderer rasterRenderer = new RasterRenderer();
            IRenderer vectorRenderer = new VectorRenderer();

            BridgeShape circle1 = new CircleBridge(5, rasterRenderer);
            circle1.Draw();
            BridgeShape circle2 = new CircleBridge(5, vectorRenderer);
            circle2.Draw();


            BridgeShape rectangle1 = new RectangleBridge(3, 4, vectorRenderer);
            rectangle1.Draw();
            BridgeShape rectangle2 = new RectangleBridge(3, 4, rasterRenderer);
            rectangle2.Draw();

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- End Bridge Pattern");
            Console.WriteLine("--------------------------------------------");
        }

        #endregion

        #region BuilderExample

        public static void BuilderExample()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- Start Builder Pattern");
            Console.WriteLine("--------------------------------------------");

            Email email = new EmailBuilder()
                .From("sender@example.com")
                .To("recipient@example.com")
                .WithSubject("Hello!")
                .WithBody("This is the body of the email.")
                .Build();

            Console.WriteLine("Sender: " + email.Sender);
            Console.WriteLine("Recipient: " + email.Recipient);
            Console.WriteLine("Subject: " + email.Subject);
            Console.WriteLine("Body: " + email.Body);

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- End Builder Pattern");
            Console.WriteLine("--------------------------------------------");
        }

        #endregion

        #region ChainOfResponsibilityExample

        public static void ChainOfResponsibilityExample()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- Start Chain of Responsibility Pattern");
            Console.WriteLine("--------------------------------------------");

            // Create the chain of approvers
            var teamLead = new TeamLead();
            var departmentManager = new DepartmentManager();
            var ceo = new CEO();

            teamLead.SetNextApprover(departmentManager);
            departmentManager.SetNextApprover(ceo);

            // Create a leave request
            var leaveRequest = new LeaveRequest(10);

            // Process the leave request
            teamLead.ProcessLeaveRequest(leaveRequest);

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- End Chain of Responsibility Pattern");
            Console.WriteLine("--------------------------------------------");
        }

        #endregion

        #region CommandPatternExample

        public static void CommandPatternExample()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- Start Command Pattern");
            Console.WriteLine("--------------------------------------------");

            Light light = new Light();

            LightOnCommand onCommand = new LightOnCommand(light);
            LightOffCommand offCommand = new LightOffCommand(light);

            RemoteControl remote = new RemoteControl();

            remote.SetCommand(onCommand);
            remote.PressButton(); // Turns on the light

            remote.SetCommand(offCommand);
            remote.PressButton(); // Turns off the light

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- End Command Pattern");
            Console.WriteLine("--------------------------------------------");
        }

        #endregion

        #region CommandSQLExample (Not Executed in Program)

        public static void CommandSQLExample()
        {
            string connectionString = "your_connection_string_here";

            string query = "INSERT INTO Customers (Name, Email) VALUES (@Name, @Email)";

            // Creating an array of SqlParameter objects
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Name", SqlDbType.NVarChar) { Value = "John Doe" },
            new SqlParameter("@Email", SqlDbType.NVarChar) { Value = "john.doe@example.com" }
            };

            // Creating the SQL command with parameters
            ISQLDatabaseCommand sqlCommand = new SqlCommandWrapper(connectionString, query, parameters);

            sqlCommand.Execute();
        }

        #endregion

        #region CommandStoredProcedureExample (Not Executed in Program)

        public static void CommandStoredProcedureExample()
        {
            string connectionString = "your_connection_string_here";

            string storedProcedureName = "YourStoredProcedureName";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Parameter1", SqlDbType.NVarChar) { Value = "John Doe" },
            new SqlParameter("@Parameter2", SqlDbType.NVarChar) { Value = "john.doe@example.com" },
            new SqlParameter("@Parameter3", SqlDbType.Int) { Value = 42 }
            };

            ISQLStoredProcDatabaseCommand storedProcedureCommand = new StoredProcedureCommand(storedProcedureName, connectionString, parameters);

            storedProcedureCommand.Execute();
        }

        #endregion

        #region CommandLinqExample (Not Executed in Program)

        public static void CommandLinqExample()
        {
            // Connection string or other DbContext options
            string connectionString = "your_connection_string_here";
            DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseSqlServer(connectionString).Options;

            // LINQ query
            // The Func delegate has multiple generic type parameters, where the last type parameter represents the return type of the function,
            // and the preceding type parameters represent the input parameter types.
            Func<DbContext, IEnumerable<string>> linqQuery = dbContext =>
                from customer in dbContext.Set<Customer>().Where(c => c.Age > 25)
                select customer.Name;

            // Creating the LINQ query command
            IDbLinqCommand<string> linqQueryCommand = new LinqQueryCommand<string>(dbContextOptions, linqQuery);

            // Executing the LINQ query
            IEnumerable<string> results = linqQueryCommand.Execute();

            // Displaying the results
            foreach (string result in results)
            {
                Console.WriteLine(result);
            }
        }

        #endregion

        #region CompositeExample

        public static void CompositeExample()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- Start Composite Pattern");
            Console.WriteLine("--------------------------------------------");

            // Creating individual employees
            var john = new Employee { Name = "John Doe", Salary = 5000 };
            var mary = new Employee { Name = "Mary Smith", Salary = 6000 };
            var sarah = new Employee { Name = "Sarah Johnson", Salary = 5500 };

            // Creating a group of employees
            var developmentGroup = new EmployeeGroup { Name = "Development Group" };
            developmentGroup.Add(john);
            developmentGroup.Add(mary);

            var marketingGroup = new EmployeeGroup { Name = "Marketing Group" };
            marketingGroup.Add(sarah);

            // Creating the top-level organization
            var organization = new EmployeeGroup { Name = "My Organization" };
            organization.Add(developmentGroup);
            organization.Add(marketingGroup);

            // Calculating total salary of the organization
            decimal totalSalary = organization.GetSalary();

            Console.WriteLine($"Total salary of the organization: {totalSalary}");

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- End Composite Pattern");
            Console.WriteLine("--------------------------------------------");
        }

        #endregion

        #region DecoratorExample

        public static void DecoratorExample()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- Start Decorator Pattern");
            Console.WriteLine("--------------------------------------------");

            // Create a basic pizza with cheese
            IPizza basicPizza = new BasicPizza();
            Console.WriteLine("Description: " + basicPizza.GetDescription());
            Console.WriteLine("Cost: $" + basicPizza.GetCost());

            Console.WriteLine();

            // Decorate the basic pizza with mushrooms, sausage, and pepperoni
            IPizza deluxePizza = new PepperoniDecorator(new SausageDecorator(new MushroomDecorator(basicPizza)));

            //NOTE: Below is the same as the above.
            //IPizza deluxePizza = new MushroomDecorator(basicPizza);
            //deluxePizza = new SausageDecorator(deluxePizza);
            //deluxePizza = new PepperoniDecorator(deluxePizza);

            Console.WriteLine("Description: " + deluxePizza.GetDescription());
            Console.WriteLine("Cost: $" + deluxePizza.GetCost());

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- End Decorator Pattern");
            Console.WriteLine("--------------------------------------------");
        }

        #endregion

        #region FacadePatternExample

        public static void FacadePatternExample()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- Start Facade Pattern");
            Console.WriteLine("--------------------------------------------");

            WebScraperFacade scraper = new WebScraperFacade();
            string url = "https://example.com";
            scraper.Scrape(url);

            // Get and set fields using dictionary indexing
            string field1 = scraper.GetField("Field1");
            string field2 = scraper.GetField("Field2");
            Console.WriteLine($"Field1: {field1}");
            Console.WriteLine($"Field2: {field2}");

            scraper.SetField("Field1", "New Field1 Value");
            string updatedField1 = scraper.GetField("Field1");
            Console.WriteLine($"Updated Field1: {updatedField1}");

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- End Facade Pattern");
            Console.WriteLine("--------------------------------------------");
        }

        #endregion

        #region FactoryExample

        /// <summary>
        /// By using the Factory Method pattern, we can abstract the object creation process and allow subclasses to decide which concrete class to instantiate. 
        /// This promotes loose coupling and flexibility in adding new product variants without modifying the existing code.
        /// </summary>
        public static void FactoryExample()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- Start Factory Pattern");
            Console.WriteLine("--------------------------------------------");

            // Prompt user for document type (Randomly get this)
            string[] documentTypes = { "resume", "report", "letter" };

            Random random = new Random();
            int randomIndex = random.Next(documentTypes.Length);
            string selectedDocumentType = documentTypes[randomIndex];

            // Create the appropriate document based on user input
            DocumentCreator creator;
            switch (selectedDocumentType)
            {
                case "resume":
                    creator = new ResumeCreator();
                    break;
                case "report":
                    creator = new ReportCreator();
                    break;
                case "letter":
                    creator = new LetterCreator();
                    break;
                default:
                    Console.WriteLine("Invalid document type.");
                    return;
            }

            // Create the document and perform operations
            Document document = creator.CreateDocument();
            document.Title = "My Document Title";
            document.Print();

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- End Factory Pattern");
            Console.WriteLine("--------------------------------------------");
        }

        #endregion

        #region FlyWeightExample

        public static void FlyWeightExample()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- Start Fly Weight Pattern");
            Console.WriteLine("--------------------------------------------");

            PlayerFactory factory = new PlayerFactory();

            // Create Counter-Terrorist players
            IPlayer ctPlayer1 = factory.GetPlayer("counter-terrorist", "M4A1");
            ctPlayer1.Mission();  // Output: "Counter-Terrorist with weapon M4A1 | Performing mission..."

            IPlayer ctPlayer2 = factory.GetPlayer("counter-terrorist", "AWP");
            ctPlayer2.Mission();  // Output: "Counter-Terrorist with weapon AWP | Performing mission..."

            IPlayer ctPlayer3 = factory.GetPlayer("counter-terrorist", "AWP");
            ctPlayer2.Mission();  // Output: "Counter-Terrorist with weapon AWP | Performing mission..."

            // Create Terrorist players
            IPlayer tPlayer1 = factory.GetPlayer("terrorist", "AK-47");
            tPlayer1.Mission();  // Output: "Terrorist with weapon AK-47 | Performing mission..."

            IPlayer tPlayer2 = factory.GetPlayer("terrorist", "Glock-18");
            tPlayer2.Mission();  // Output: "Terrorist with weapon Glock-18 | Performing mission..."

            // Check if Counter-Terrorist players are the same instance
            Console.WriteLine(ctPlayer2== ctPlayer3);  // Output: True

            // Check if Terrorist players are the same instance
            Console.WriteLine(tPlayer1 == tPlayer2);  // Output: False

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- End Fly Weight Pattern");
            Console.WriteLine("--------------------------------------------");
        }

        #endregion

        #region IterpreterExample

        /// <summary>
        /// 1. In the Main method of the InterpreterExample class (our client code), we create instances of the expression classes, passing the necessary parameters.
        /// 2. We use a StringBuilder called query to accumulate the SQL query components. This class allows us to efficiently build strings by appending smaller parts together.
        /// 3. We call the Interpret method on each expression instance, passing the query as a parameter. This causes each expression to append its respective SQL snippet to the query string.
        /// 4. Finally, we print the complete SQL query by converting the query StringBuilder to a string using the ToString method.
        /// </summary>
        public static void InterpreterExample()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- Start Interpreter Pattern");
            Console.WriteLine("--------------------------------------------");

            // Create the SQL query: SELECT column1, column2 FROM table WHERE condition ORDER BY column3
            var query = new StringBuilder();
            var selectExpression = new SelectExpression(new string[] { "column1", "column2" });
            var fromExpression = new FromExpression("table");
            var whereExpression = new WhereExpression("condition");
            var orderByExpression = new OrderByExpression("column3");

            // Build the SQL query
            selectExpression.Interpret(query);
            fromExpression.Interpret(query);
            whereExpression.Interpret(query);
            orderByExpression.Interpret(query);

            // Print the SQL query
            Console.WriteLine(query.ToString());

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- End Interpreter Pattern");
            Console.WriteLine("--------------------------------------------");

        }

        #endregion

        #region IteratorExample

        public static void IteratorExample()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- Start Iterator Pattern");
            Console.WriteLine("--------------------------------------------");

            Organization organization = new Organization();

            foreach (FullTimeEmployee employee in organization)
            {
                Console.WriteLine($"Name: {employee.Name}, Position: {employee.Position}, Salary: {employee.Salary}");

            }

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- End Iterator Pattern");
            Console.WriteLine("--------------------------------------------");
        }

        #endregion

        #region MediatorExample

        /// <summary>
        /// By utilizing the Mediator Pattern, the chat users (ChatUser) are decoupled from each other, 
        /// and the communication between them is managed by the chat mediator (ChatMediator). The mediator 
        /// acts as a central point for routing messages, allowing users to communicate without having direct 
        /// dependencies on each other
        /// </summary>
        public static void MediatorExample()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- Start Mediator Pattern");
            Console.WriteLine("--------------------------------------------");

            IChatMediator chatMediator = new ChatMediator();

            User user1 = new ChatUser("John", chatMediator);
            User user2 = new ChatUser("Jane", chatMediator);
            User user3 = new ChatUser("Mike", chatMediator);

            chatMediator.AddUser(user1);
            chatMediator.AddUser(user2);
            chatMediator.AddUser(user3);

            user1.SendMessage("Hello everyone!");
            user2.SendMessage("Hi John!");
            user3.SendMessage("Hi Johny boy!");

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- End Mediator Pattern");
            Console.WriteLine("--------------------------------------------");
        }

        #endregion

        #region MomentoExample

        public static void MomentoExample()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- Start Moment Pattern");
            Console.WriteLine("--------------------------------------------");

            // Create a new game with initial level and score
            var game = new CoolGame(1, 0);

            // Create a history object to store game mementos
            var history = new GameHistory();

            // Play the game and save progress
            game.PlayLevel(1, 100);
            var memento = game.Save();
            history.SaveMemento(memento);

            // Play the game and update progress
            game.PlayLevel(2, 200);

            // Restore previous progress
            memento = history.LoadMemento();
            game.Restore(memento);

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- End Moment Pattern");
            Console.WriteLine("--------------------------------------------");
        }

        #endregion

        #region ObservableExample

        public static void ObservableExample()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- Start Observer Pattern");
            Console.WriteLine("--------------------------------------------");

            Stock stock = new Stock("ABC", 100.0m);

            Investor investor1 = new Investor("John");
            Investor investor2 = new Investor("Jane");
            Investor investor3 = new Investor("Mike");

            stock.Attach(investor1);
            stock.Attach(investor2);
            stock.Attach(investor3);

            // Price change will trigger updates for all investors
            stock.SetPrice(105.0m);
            stock.SetPrice(125.0m);

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- End Observer Pattern");
            Console.WriteLine("--------------------------------------------");
        }

        #endregion

        #region PrototypeExample

        /// <summary>
        /// In this example, the ShapeCache acts as a prototype manager, allowing users to retrieve clones of predefined shapes by their keys. 
        /// Users can then work with the cloned shapes, which are independent of the original prototypes. The prototype pattern enables easy 
        /// creation and manipulation of objects while reducing the need for object creation logic.
        /// </summary>
        public static void PrototypeExample()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- Start Prototype Pattern");
            Console.WriteLine("--------------------------------------------");

            // Load the cache with pre-defined shapes
            ShapeCache.LoadCache();

            // Get a rectangle from the cache and modify it
            Shape clonedShape = ShapeCache.GetShape("Rectangle");

            if (clonedShape is Rectangle clonedRectangle)
            {
                clonedRectangle.Draw(); // Before Outputs: Rectangle: Width=100, Height=50
                clonedRectangle.Width = 200;
                clonedRectangle.Height = 100;
                clonedRectangle.Draw(); // After Outputs: Rectangle: Width=200, Height=100
            }

            // Get a circle from the cache and modify it
            clonedShape = ShapeCache.GetShape("Circle");
            if (clonedShape is Circle clonedCircle)
            {
                clonedCircle.Draw(); // Before Outputs: Circle: Radius=50
                clonedCircle.Radius = 75;
                clonedCircle.Draw(); // After Outputs: Circle: Radius=75
            }

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- End Prototype Pattern");
            Console.WriteLine("--------------------------------------------");

        }

        #endregion

        #region ProxyExample

        public static void ProxyExample()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- Start Proxy Pattern");
            Console.WriteLine("--------------------------------------------");

            IApiClient api = new ApiProxy();

            string data = api.GetData();
            Console.WriteLine(data);

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- End Proxy Pattern");
            Console.WriteLine("--------------------------------------------");

        }

        #endregion

        #region SingletonExample

        public static void SingletonExample()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- Start Singleton Pattern");
            Console.WriteLine("--------------------------------------------");

            Logger logger1 = Logger.Instance;
            Logger logger2 = Logger.Instance;

            // Both logger1 and logger2 refer to the same instance of Logger
            Console.WriteLine(logger1 == logger2); // Outputs: True

            logger1.Log("This is a log message."); // Outputs: Logging message: This is a log message.
            logger2.Log("Another log message."); // Outputs: Logging message: Another log message.

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- End Singleton Pattern");
            Console.WriteLine("--------------------------------------------");

        }

        #endregion

        #region StateExample

        /// <summary>
        /// This example demonstrates how the SetState method can be used to directly change the state of the traffic light, 
        /// bypassing the regular state transition logic triggered by the Request method. It provides flexibility in controlling 
        /// the state of the traffic light system based on specific requirements or external conditions.
        /// </summary>
        public static void StateExample()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- Start State Pattern");
            Console.WriteLine("--------------------------------------------");

            TrafficLight trafficLight = new TrafficLight();

            trafficLight.Request(); // Red -> Green
            trafficLight.Request(); // Green -> Yellow
            trafficLight.Request(); // Yellow -> Red

            // Change state using SetState method
            trafficLight.SetState(new GreenState());
            trafficLight.Request(); // Green -> Yellow
            trafficLight.SetState(new RedState());
            trafficLight.Request(); // Red -> Green

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- End State Pattern");
            Console.WriteLine("--------------------------------------------");
        }

        #endregion

        #region StrategyExample

        public static void StrategyExample()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- Start Strategy Pattern");
            Console.WriteLine("--------------------------------------------");

            PaymentProcessor paymentProcessor = new PaymentProcessor();

            // Process credit card payment
            IPaymentStrategy creditCardStrategy = new CreditCardPaymentStrategy("1234567890", "12/2023", "123");
            paymentProcessor.SetPaymentStrategy(creditCardStrategy);
            paymentProcessor.ProcessPayment(100.0m);

            // Process PayPal payment
            IPaymentStrategy payPalStrategy = new PayPalPaymentStrategy("example@gmail.com", "password123");
            paymentProcessor.SetPaymentStrategy(payPalStrategy);
            paymentProcessor.ProcessPayment(50.0m);

            // Process bank transfer payment
            IPaymentStrategy bankTransferStrategy = new BankTransferPaymentStrategy("123456789", "987654321");
            paymentProcessor.SetPaymentStrategy(bankTransferStrategy);
            paymentProcessor.ProcessPayment(200.0m);

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- End Strategy Pattern");
            Console.WriteLine("--------------------------------------------");
        }

        #endregion

        #region TemplateExample

        public static void TemplateExample()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- Start Template Pattern");
            Console.WriteLine("--------------------------------------------");

            CoffeeMaker cappuccinoMaker = new CappuccinoMaker();
            cappuccinoMaker.MakeCoffee();
            // Outputs:
            // Boiling water
            // Brewing Cappuccino espresso
            // Pouring coffee into cup
            // Adding milk foam and chocolate powder
            // Coffee is ready!

            Console.WriteLine();

            CoffeeMaker americanoMaker = new AmericanoMaker();
            americanoMaker.MakeCoffee();
            // Outputs:
            // Boiling water
            // Brewing Americano espresso
            // Pouring coffee into cup
            // Adding hot water
            // Coffee is ready!

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- End Template Pattern");
            Console.WriteLine("--------------------------------------------");
        }

        #endregion

        #region VistorExample

        /// <summary>
        /// When the visitor visits each VisitorDocument instance, it checks the type of the document and calls the corresponding ExtractText method to extract the text content.
        /// </summary>
        public static void VistorExample()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- Start Visitor Pattern");
            Console.WriteLine("--------------------------------------------");

            var documents = new List<VisitorDocument>
            {
                new PdfDocument(),
                new WordDocument(),
                new ExcelDocument()
            };

            var textExtractor = new TextExtractorVisitor();

            foreach (VisitorDocument document in documents)
            {
                //The method in the Visitor Pattern is conventionally named Accept because it signifies
                //that the visited object accepts or receives the visitor. The name Accept implies that
                //the visited object acknowledges the visitor's presence and allows it to perform its operation.
                document.Accept(textExtractor);
            }

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("- End Visitor Pattern");
            Console.WriteLine("--------------------------------------------");
        }

        #endregion

    }
}