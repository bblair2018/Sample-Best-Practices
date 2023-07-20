using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UATP_Practice.PATTERNS
{
    // ----------------------------------------------------------------------------------------------------------------------------------
    // This demonstrates the Command pattern by separating the requester (invoker) from the receiver and encapsulating requests as
    // objects. Let's see how it satisfies the Command pattern:
    // ----------------------------------------------------------------------------------------------------------------------------------

    // ------------------------------------------------------------------------------------
    // ICommand (Command): It defines the interface for executing commands, which is a
    // single method Execute(). This interface represents the common behavior that all
    // commands should implement.
    // ------------------------------------------------------------------------------------

    // Command interface
    public interface ICommand
    {
        void Execute();
    }

    // ------------------------------------------------------------------------------------
    // LightOnCommand and LightOffCommand (Concrete Commands): These classes implement the
    // ICommand interface and encapsulate specific actions (TurnOn() and TurnOff()) to be
    // executed by the receiver (Light
    // ------------------------------------------------------------------------------------

    // Concrete Command classes
    public class LightOnCommand : ICommand
    {
        private readonly Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }
    }

    public class LightOffCommand : ICommand
    {
        private readonly Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }
    }

    // ------------------------------------------------------------------------------------
    // Light (Receiver): It represents the object that performs the actual operations.
    // In this example, the Light class has methods TurnOn() and TurnOff() that are
    // invoked by the commands.
    // ------------------------------------------------------------------------------------

    // Receiver class
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Light is off");
        }
    }

    // ------------------------------------------------------------------------------------
    // RemoteControl (Invoker): It acts as the invoker, responsible for setting and
    // executing commands. It has a method SetCommand() to set the command to be executed
    // and a method PressButton() to trigger the execution of the command.
    // ------------------------------------------------------------------------------------

    // Invoker class
    public class RemoteControl
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PressButton()
        {
            _command.Execute();
        }
    }

    // ----------------------------------------------------------------------------------------------------------------------------------
    // Overall, this example demonstrates the Command pattern by encapsulating requests as objects (ICommand), allowing the invoker
    // (RemoteControl) to be decoupled from the receiver (Light), and providing flexibility and extensibility in command execution.
    // ----------------------------------------------------------------------------------------------------------------------------------
    // Encapsulation: Each command (LightOnCommand and LightOffCommand) encapsulates a specific action and its associated receiver (Light).
    // This encapsulation allows the invoker (RemoteControl) to be decoupled from the receiver and simplifies the addition of new commands.
    // ----------------------------------------------------------------------------------------------------------------------------------
    // Flexibility: The RemoteControl can be easily configured with different commands at runtime by using the SetCommand() method.
    // This flexibility enables dynamic switching of commands and supports extensibility.
    // ----------------------------------------------------------------------------------------------------------------------------------
    // Undo/Redo: The Command pattern provides a foundation for implementing undo/redo functionality. By storing the executed commands,
    // the RemoteControl can support undo operations by reversing the command execution or keeping a history of executed commands for
    // redo operations.
    // ----------------------------------------------------------------------------------------------------------------------------------

}
