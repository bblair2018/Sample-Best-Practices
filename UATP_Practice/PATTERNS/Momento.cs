using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UATP_Practice.PATTERNS
{
    // ----------------------------------------------------------------------------------------------------------------------------------
    // The Memento Pattern is like taking a snapshot of an object's state, so you can restore it later if needed.
    // It involves three main actors: the Originator, the Memento, and the Caretaker.
    //
    // - The Originator is the object that has some internal state that you want to save and restore.
    //   It knows how to save its current state into a Memento and can restore its state from a Memento.
    //
    // - The Memento is like a snapshot or a token that stores the state of the Originator.
    //   It provides methods to retrieve the saved state but doesn't allow direct modification.
    //   It's used to hold the state temporarily.
    //
    // - The Caretaker is responsible for storing and managing the Mementos.
    //   It asks the Originator to save its state into a Memento and keeps track of the Mementos.
    //   When needed, it can give the Memento back to the Originator to restore its state.
    //
    // So, the Memento Pattern allows you to save the state of an object into a separate object (the Memento)
    // and later restore it if needed. It's useful when you want to capture and restore the state of an object
    // without exposing its internal details.
    // ----------------------------------------------------------------------------------------------------------------------------------
    // Let's consider a scenario of a text-based game where the player can save and load their progress. The Memento Pattern can be used
    // to implement a save and load functionality.
    // ----------------------------------------------------------------------------------------------------------------------------------

    // ------------------------------------------------------------------------------------
    // GameMemento class: This class represents the Memento in the Memento Pattern. It
    // stores the state of the Game object. In our example, it has properties Level and
    // Score to store the level and score of the game. The memento is immutable once created.
    // ------------------------------------------------------------------------------------

    // Memento class
    public class GameMemento
    {
        public int Level { get; }
        public int Score { get; }

        public GameMemento(int level, int score)
        {
            Level = level;
            Score = score;
        }
    }

    // ------------------------------------------------------------------------------------
    // Game class: This class is the Originator in the Memento Pattern. It represents the
    // game state and functionality. It has private fields _level and _score to store the
    // current level and score of the game. The PlayLevel method simulates playing a level
    // by updating the level and score. The Save method creates a memento object with the
    // current state of the game, and the Restore method sets the state of the game from
    // a given memento object.
    // ------------------------------------------------------------------------------------

    // Originator class
    public class CoolGame
    {
        private int _level;
        private int _score;

        public CoolGame(int level, int score)
        {
            _level = level;
            _score = score;
        }

        public void PlayLevel(int level, int score)
        {
            _level = level;
            _score = score;
            Console.WriteLine($"Playing level {_level}, Score: {_score}");
        }

        public GameMemento Save()
        {
            return new GameMemento(_level, _score);
        }

        public void Restore(GameMemento memento)
        {
            _level = memento.Level;
            _score = memento.Score;
            Console.WriteLine($"Restored level {_level}, Score: {_score}");
        }
    }

    // ------------------------------------------------------------------------------------
    // GameHistory class: This class acts as the Caretaker in the Memento Pattern. It is
    // responsible for managing the game mementos. It has a private field _memento to store
    // the memento. The SaveMemento method is used to save a memento object, and the
    // LoadMemento method retrieves the saved memento.
    // ------------------------------------------------------------------------------------

    // Caretaker class
    public class GameHistory
    {
        private GameMemento _memento;

        public void SaveMemento(GameMemento memento)
        {
            _memento = memento;
            Console.WriteLine("Game progress saved.");
        }

        public GameMemento LoadMemento()
        {
            Console.WriteLine("Game progress loaded.");
            return _memento;
        }
    }
}
