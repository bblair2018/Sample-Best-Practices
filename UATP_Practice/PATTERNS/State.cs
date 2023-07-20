using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UATP_Practice.PATTERNS
{
    // ----------------------------------------------------------------------------------------------------------------------------------
    // Let's consider a traffic light system that manages the state transitions and behavior of a traffic light at an intersection. The
    // State Pattern can be used to implement this scenario.
    // ----------------------------------------------------------------------------------------------------------------------------------

    // ------------------------------------------------------------------------------------
    // First, define an interface that represents the states of the traffic light:
    // ------------------------------------------------------------------------------------
    // The ITrafficLightState interface defines the contract for the different states of
    // the traffic light. Each concrete state class (RedState, GreenState, and YellowState)
    // implements this interface and provides its own implementation of the HandleRequest method.
    // ------------------------------------------------------------------------------------

    public interface ITrafficLightState
    {
        void HandleRequest(TrafficLight trafficLight);
    }

    // ------------------------------------------------------------------------------------
    // Next, implement concrete state classes for each possible state of the traffic light:
    // ------------------------------------------------------------------------------------
    // The concrete state classes (RedState, GreenState, and YellowState) represent
    // different states of the traffic light. Each class implements the HandleRequest
    // method to handle the specific behavior associated with its state. When the
    // traffic light's state changes, the context (TrafficLight) can switch to a different
    // concrete state class.
    // ------------------------------------------------------------------------------------

    public class RedState : ITrafficLightState
    {
        public void HandleRequest(TrafficLight trafficLight)
        {
            Console.WriteLine("Red Light - Stop");
            trafficLight.SetState(new GreenState());
        }
    }

    public class GreenState : ITrafficLightState
    {
        public void HandleRequest(TrafficLight trafficLight)
        {
            Console.WriteLine("Green Light - Go");
            trafficLight.SetState(new YellowState());
        }
    }

    public class YellowState : ITrafficLightState
    {
        public void HandleRequest(TrafficLight trafficLight)
        {
            Console.WriteLine("Yellow Light - Prepare to stop");
            trafficLight.SetState(new RedState());
        }
    }

    // ------------------------------------------------------------------------------------
    // Next, define a context class that represents the traffic light:
    // ------------------------------------------------------------------------------------
    // The TrafficLight class acts as the context in the State pattern. It maintains a
    // reference to the current state (_state) and has methods (SetState and Request)
    // to interact with the state and trigger state transitions. The Request method calls
    // the HandleRequest method of the current state, allowing the state to modify the
    // traffic light's behavior and switch to a different state. 
    // ------------------------------------------------------------------------------------
    // Each time the Request method is called on the TrafficLight, it triggers the
    // HandleRequest method of the current state. After performing its specific action,
    // the current state calls the SetState method on the TrafficLight, effectively
    // changing the state to the next state in the sequence (Red -> Green -> Yellow -> Red).
    // ------------------------------------------------------------------------------------

    public class TrafficLight
    {
        private ITrafficLightState _state;

        public TrafficLight()
        {
            _state = new RedState(); // Initial state is Red
        }

        public void SetState(ITrafficLightState state)
        {
            _state = state;
        }

        /// <summary>
        /// In summary, this is used to pass a reference to the current object (TrafficLight) to the HandleRequest 
        /// method of the current state object, enabling the state object to interact with and modify the traffic 
        /// light's state if required.
        /// </summary>
        public void Request()
        {
            _state.HandleRequest(this);
        }
    }

    // ----------------------------------------------------------------------------------------------------------------------------------
    // The code above implements the State design pattern to model a traffic light system. The State pattern allows an object
    // (in this case, the traffic light) to change its behavior when its internal state changes. By using the State pattern, the traffic
    // light can transition through different states (Red, Green, Yellow) and perform different actions based on its current state.
    // ----------------------------------------------------------------------------------------------------------------------------------
    // In this example, the traffic light transitions through its states as the Request method is called, simulating the behavior of a
    // traffic light at an intersection. The State pattern enables the traffic light to change its behavior and perform different actions
    // based on its current state, allowing for more flexible and maintainable code when dealing with complex state transitions.
    // ----------------------------------------------------------------------------------------------------------------------------------


}
