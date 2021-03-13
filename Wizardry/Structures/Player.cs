using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wizardry.Structures
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Is_Active { get; set; }
        public bool Is_LessActive { get; set; }
        public int ArmyPower { get; set; }

        public Player() { }

        public Player(Player o)
        {
            this.Id = o.Id;
            this.Name = o.Name;
            this.Is_Active = o.Is_Active;
            this.Is_LessActive = o.Is_LessActive;
            this.ArmyPower = o.ArmyPower;
        }
    }
}
