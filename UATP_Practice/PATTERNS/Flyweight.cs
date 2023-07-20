using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UATP_Practice.PATTERNS
{
    /*
    The Flyweight Pattern is a structural design pattern that focuses on efficient memory usage by sharing common data across multiple objects. 
    It aims to minimize the memory footprint of an application by sharing as much data as possible among similar objects instead of replicating it in each object.

    In the Flyweight Pattern, there are two key components:

    - Flyweight: This is the shared object that stores intrinsic (invariant) state, which is independent of the context in which it is used. 
      The Flyweight object should be immutable so that it can be safely shared among multiple objects.

    - Context: This is the extrinsic (variant) state that varies across objects and cannot be shared. The Context object contains the unique
    state information that is specific to each object.

    The Flyweight Pattern works by separating the intrinsic state from the extrinsic state. Objects that share the same intrinsic state can refer to the same Flyweight object, 
    reducing memory usage.

    The typical workflow of the Flyweight Pattern involves the following steps:

    1. Create a Flyweight Factory: This factory manages the creation and sharing of Flyweight objects. It keeps track of existing Flyweights and provides a way to retrieve
       or create new Flyweights based on the requested state.
    
    2. Request Flyweight: When an object needs to use a Flyweight, it requests it from the Flyweight Factory. The requested Flyweight can be either an existing one (if available)
       or a new one created by the factory.

    3. Use Flyweight: Once a Flyweight is obtained, the object uses it in conjunction with its unique context (extrinsic state). The Flyweight provides the shared intrinsic state,
       while the object provides the unique extrinsic state.

    By utilizing the Flyweight Pattern, applications can significantly reduce memory usage when dealing with large numbers of objects that share common properties. This pattern is
    particularly useful when the common data is immutable and can be shared safely across objects. It promotes efficient resource utilization and can improve performance in scenarios
    where memory consumption is a concern.
    */


    // ----------------------------------------------------------------------------------------------------------------------------------
    // In this example, we have a game scenario where players can be either Terrorists or Counter-Terrorists. Each player can be assigned
    // a weapon and can play the game.
    // ----------------------------------------------------------------------------------------------------------------------------------

    interface IPlayer
    {
        void Mission();
    }

    // ------------------------------------------------------------------------------------
    // The CounterTerrorist and Terrorist classes implement the IPlayer interface as
    // concrete flyweights. Each flyweight has an intrinsic state represented by the weapon
    // field.
    // ------------------------------------------------------------------------------------

    // Concrete Flyweight: Represents a Counter-Terrorist player
    class CounterTerrorist : IPlayer
    {
        private string weapon;

        public CounterTerrorist(string weapon)
        {
            this.weapon = weapon;
        }

        public void Mission()
        {
            Console.WriteLine($"Counter-Terrorist with weapon {weapon} | Performing mission...");
        }
    }

    // Concrete Flyweight: Represents a Terrorist player
    class Terrorist : IPlayer
    {
        private string weapon;

        public Terrorist(string weapon)
        {
            this.weapon = weapon;
        }

        public void Mission()
        {
            Console.WriteLine($"Terrorist with weapon {weapon} | Performing mission...");
        }
    }

    // ------------------------------------------------------------------------------------
    // The PlayerFactory class serves as the flyweight factory. It maintains a dictionary
    // of flyweight objects (CounterTerrorist and Terrorist).
    // ------------------------------------------------------------------------------------

    // Flyweight Factory: Manages the creation and sharing of flyweight objects
    class PlayerFactory
    {
        private Dictionary<string, IPlayer> players;

        public PlayerFactory()
        {
            players = new Dictionary<string, IPlayer>();
        }

        /// <summary>
        /// In the GetPlayer method, a unique key is generated based on the team and weapon combination. The dictionary is then checked to see if a player with 
        /// the specified key exists. If not, a new player object is created based on the team and weapon combination, and it is added to the dictionary with the key. 
        /// Subsequent requests for the same team and weapon will retrieve the existing player object from the dictionary.
        /// 
        /// The dictionary serves as a cache of flyweight objects, where the key represents the combination of team and weapon, and the value is the corresponding player 
        /// object. This allows the factory to reuse existing flyweight objects when requested with the same combination of team and weapon, instead of creating new objects.
        /// </summary>
        /// <param name="team">The team to which the player is assigned.</param>
        /// <param name="weapon">The weapon that is assigned to the player.</param>
        /// <returns></returns>
        /// <exception cref="NotSupportedException"></exception>
        public IPlayer GetPlayer(string team, string weapon)
        {
            string key = $"{team}_{weapon}";

            if (!players.ContainsKey(key))
            {
                IPlayer player;

                if (team == "terrorist")
                {
                    player = new Terrorist(weapon);
                }
                else if (team == "counter-terrorist")
                {
                    player = new CounterTerrorist(weapon);
                }
                else
                {
                    throw new NotSupportedException($"Team '{team}' is not supported.");
                }

                players[key] = player;
            }

            return players[key];
        }
    }

    // ----------------------------------------------------------------------------------------------------------------------------------
    // By using the Flyweight Pattern, we avoid duplicating the intrinsic state (weapon) for each player object, saving memory.
    // ----------------------------------------------------------------------------------------------------------------------------------
    // In the context of the Flyweight Pattern, intrinsic state refers to the part of an object's state that is shared and can be considered
    // as fixed or immutable. It represents the properties or data that are common among multiple objects and can be shared to reduce memory
    // consumption.
    // ----------------------------------------------------------------------------------------------------------------------------------

}
