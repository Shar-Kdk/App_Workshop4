using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Workshop4
{
    internal class Player
    {
        public string PlayerName;
        public int Level;
        public int Health;

        // Default constructor
        public Player()
        {
            Console.WriteLine("Default constructor has been called");
        }

        // Parameterized constructor
        public Player(string playerName, int level, int health)
        {
            PlayerName = playerName;
            Level = level;
            Health = health;
        }

        public void Display()
        {
            Console.WriteLine($"Player: {PlayerName}, Level: {Level}, Health: {Health}");
        }
    }
}