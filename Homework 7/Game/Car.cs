using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    abstract class Car
    {
        private string _name;
        public string Name => _name;

        private int _position;
        public int Position => _position;
        abstract public int Speed { get; }

        public Car(string name)
        {
            _name = name;
        }

        public void SetPosition(int position)
        {
            _position = position;
        }

        public void Move()
        {
            _position += Speed;
        }

        public void ShowPosition()
        {
            Console.WriteLine($"Car position {_name}: {Position}");
        }
    }
}
