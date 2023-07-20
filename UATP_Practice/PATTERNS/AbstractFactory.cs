using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UATP_Practice.PATTERNS
{
    /*
    Create an  example that utilizes the Abstract Factory pattern to create 10 different warriors, each
    with three different attacks and three different defenses.Each warrior will have a unique name, and 
    their skills (Berserk Rage, Defensive Stance, and Swift Strikes) will have values ranging from 1 to 5. 
    The program will print the details of each warrior, including their name, attacks, and defenses. 
    Include these skills as properties of the warrior class.
    */

    // ------------------------------------------------------------------------------------
    // Attack (Abstract Product): It defines the common interface for different types of
    // attacks. It declares the Execute method that needs to be implemented by concrete
    // attack classes.
    // ------------------------------------------------------------------------------------

    // Abstract Product: Attack
    public abstract class Attack
    {
        public abstract void Execute();
    }

    // ------------------------------------------------------------------------------------
    // SlashAttack, ThrustAttack, BashAttack (Concrete Products): These classes represent
    // different types of attacks that inherit from the Attack class.
    // Each attack class provides its own implementation of the Execute method.
    // ------------------------------------------------------------------------------------

    // Concrete Products: Different types of attacks
    public class SlashAttack : Attack
    {
        public override void Execute()
        {
            Console.WriteLine("Slash Attack!");
        }
    }

    public class ThrustAttack : Attack
    {
        public override void Execute()
        {
            Console.WriteLine("Thrust Attack!");
        }
    }

    public class BashAttack : Attack
    {
        public override void Execute()
        {
            Console.WriteLine("Bash Attack!");
        }
    }

    // ------------------------------------------------------------------------------------
    // Defense (Abstract Product): It defines the common interface for different types of
    // defenses. It declares the Execute method that needs to be implemented by concrete
    // defense classes.
    // ------------------------------------------------------------------------------------

    // Abstract Product: Defense
    public abstract class Defense
    {
        public abstract void Execute();
    }

    // ------------------------------------------------------------------------------------
    // BlockDefense, DodgeDefense, ParryDefense (Concrete Products): These classes represent
    // different types of defenses that inherit from the Defense class. Each defense class
    // provides its own implementation of the Execute method.
    // ------------------------------------------------------------------------------------

    // Concrete Products: Different types of defenses
    public class BlockDefense : Defense
    {
        public override void Execute()
        {
            Console.WriteLine("Block Defense!");
        }
    }

    public class DodgeDefense : Defense
    {
        public override void Execute()
        {
            Console.WriteLine("Dodge Defense!");
        }
    }

    public class ParryDefense : Defense
    {
        public override void Execute()
        {
            Console.WriteLine("Parry Defense!");
        }
    }

    // ------------------------------------------------------------------------------------
    // WarriorFactory (Abstract Factory): It declares the abstract method CreateWarrior
    // that should be implemented by concrete factory classes to create different types
    // of warriors.
    // ------------------------------------------------------------------------------------

    // Abstract Factory
    public abstract class WarriorFactory
    {
        public abstract Warrior CreateWarrior(string name);
    }

    // ------------------------------------------------------------------------------------
    // KnightFactory, SamuraiFactory (Concrete Factories): These classes inherit from the
    // WarriorFactory and provide the implementation of the CreateWarrior method to create
    // instances of Knight and Samurai warriors, respectively.
    // ------------------------------------------------------------------------------------

    // Concrete Factories: Create different types of warriors
    public class KnightFactory : WarriorFactory
    {
        public override Warrior CreateWarrior(string name)
        {
            return new Knight(name);
        }
    }

    public class SamuraiFactory : WarriorFactory
    {
        public override Warrior CreateWarrior(string name)
        {
            return new Samurai(name);
        }
    }

    // ------------------------------------------------------------------------------------
    // Warrior (Abstract Product): It defines the common interface for different types of
    // warriors. It includes properties for the warrior's name, attacks, defenses, and skills.
    // It also declares the DisplayDetails method that needs to be implemented by concrete
    // warrior classes.
    // ------------------------------------------------------------------------------------

    // Abstract Product: Warrior
    public abstract class Warrior
    {
        public string Name { get; protected set; }
        public List<Attack> Attacks { get; protected set; }
        public List<Defense> Defenses { get; protected set; }
        public int BerserkRage { get; set; }
        public int DefensiveStance { get; set; }
        public int SwiftStrikes { get; set; }

        public abstract void DisplayDetails();
    }

    // ------------------------------------------------------------------------------------
    // Knight, Samurai (Concrete Products): These classes inherit from the Warrior class
    // and represent different types of warriors. They provide their own implementations
    // of the DisplayDetails method, which displays the warrior's details including their
    // name, attacks, defenses, and skills.
    // ------------------------------------------------------------------------------------

    // Concrete Products: Different types of warriors
    public class Knight : Warrior
    {
        public Knight(string name)
        {
            Name = name;
            Attacks = new List<Attack> { new SlashAttack(), new ThrustAttack(), new BashAttack() };
            Defenses = new List<Defense> { new BlockDefense(), new DodgeDefense(), new ParryDefense() };
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("Knight: " + Name);
            Console.WriteLine("Attacks: ");
            foreach (var attack in Attacks)
            {
                attack.Execute();
            }
            Console.WriteLine("Defenses: ");
            foreach (var defense in Defenses)
            {
                defense.Execute();
            }
            Console.WriteLine("Berserk Rage: " + BerserkRage);
            Console.WriteLine("Defensive Stance: " + DefensiveStance);
            Console.WriteLine("Swift Strikes: " + SwiftStrikes);
            Console.WriteLine();
        }
    }

    public class Samurai : Warrior
    {
        public Samurai(string name)
        {
            Name = name;
            Attacks = new List<Attack> { new SlashAttack(), new BashAttack(), new ThrustAttack() };
            Defenses = new List<Defense> { new ParryDefense(), new DodgeDefense(), new BlockDefense() };
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("Samurai: " + Name);
            Console.WriteLine("Attacks: ");
            foreach (var attack in Attacks)
            {
                attack.Execute();
            }
            Console.WriteLine("Defenses: ");
            foreach (var defense in Defenses)
            {
                defense.Execute();
            }
            Console.WriteLine("Berserk Rage: " + BerserkRage);
            Console.WriteLine("Defensive Stance: " + DefensiveStance);
            Console.WriteLine("Swift Strikes: " + SwiftStrikes);
            Console.WriteLine();
        }
    }

    // ----------------------------------------------------------------------------------------------------------------------------------
    // Overall, the Abstract Factory pattern allows you to create families of related objects (warriors) without specifying their
    // concrete classes. The abstract factory (WarriorFactory) provides an interface for creating the abstract product (Warrior), and
    // the concrete factories (SamuraiFactory and NinjaFactory) implement this interface to create specific concrete products
    // (Samurai and Ninja). This helps achieve loose coupling and allows the client code (Program) to work with the abstract products
    // without being aware of their specific implementations.
    // ----------------------------------------------------------------------------------------------------------------------------------
}
