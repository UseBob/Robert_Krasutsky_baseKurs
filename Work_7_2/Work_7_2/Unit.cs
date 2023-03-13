using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Work_7_2
{
    public delegate void Move(char move);
    abstract class Unit
    {
        event Move MoveForward;
        event Move MoveBack;
        event Move MoveLeft;
        event Move MoveRight;

        public abstract int BaseDamage { get; set; }

        public string UnitSex { get; set; }
        
        public string UnitClass { get; set; }

        public string UnitRace { get; set; }

        public string UnitMove;

        public void SubscribeToMove(Unit unit)
        {
            MoveForward += unit.Move;
            MoveBack += unit.Move;
            MoveLeft += unit.Move;
            MoveRight += unit.Move;
        }
        public void Move(char move)
        {
            switch(move)
            {
                case 'w':
                    Console.WriteLine("Шагает по прямой");
                    break;
                case 's':
                    Console.WriteLine("Развернулись назад");
                    break;
                case 'a':
                    Console.WriteLine("Повернули на лево");
                    break;
                case 'd':
                    Console.WriteLine("Повернули на право");
                    break;
            }
        }
        public abstract int Attack();
    }
}
