using System;
using System.Collections.Generic;
using System.Text;

namespace FaeRealm.Character
{
    internal class Equipment
    {
        private string name { get; }
        private string description { get; }
        private CharacterBody.EquipmentType type { get; }

        public Equipment(string name, string description, CharacterBody.EquipmentType type) 
        {
            this.name = name;
            this.description = description;
            this.type = type;
        }


    }
}
