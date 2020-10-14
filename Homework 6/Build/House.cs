using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build
{
    internal class House
    {
        private Basement _basement = new Basement();
        private Walls[] _walls = new Walls[4];
        private Window[] _windows = new Window[4];
        private Door _door = new Door();
        private Roof _roof = new Roof();
        public House()
        {
            for(int i = 0; i < _walls.Length; i++)
            {
                _walls[i] = new Walls();
            }
            for (int i = 0; i < _windows.Length; i++)
            {
                _windows[i] = new Window();
            }
        }
        public Basement Basement => _basement;
        public Walls[] Walls => _walls;
        public Window[] Windows => _windows;
        public Door Door => _door;
        public Roof Roof => _roof;

        public bool IsFinished
        {
            get
            {
                if(!_basement.BuildIsFinished)
                {
                    return false;
                }
                if(!_door.BuildIsFinished)
                {
                    return false;
                }
                if(!_roof.BuildIsFinished)
                {
                    return false;
                }

                for(int i = 0; i < _walls.Length; i++)
                {
                    if(!_walls[i].BuildIsFinished)
                    {
                        return false;
                    }
                }
                for(int i = 0; i < _windows.Length; i++)
                {
                    if(!_windows[i].BuildIsFinished)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }

}
