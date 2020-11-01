using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    delegate void SetStart(int startPosition);
    delegate void Go();
    delegate void Show();
    internal class Game
    {
        private List<Car> _cars;
        private SetStart _setStart;
        private Go _go;
        private Show _show;

        public Game()
        {
            _cars = new List<Car>();
        }
        public void AddRace(Car car)
        {
            _cars.Add(car);
            _setStart += car.SetPosition;
            _go += car.Move;
            _show += car.ShowPosition;
        }
        public void OnStart()
        {
            _setStart(0);
        }

        public void Go()
        {
            for (int i = 1; i <= 100; i++)
            {
                _go();
                for(int j = 0; j < _cars.Count; j++)
                {
                    if(_cars[j].Position >= 100)
                    {
                        Console.WriteLine($"Winner {_cars[j].Name}");
                        return;
                    }
                }
                _show();
            }
        }

    }
}
