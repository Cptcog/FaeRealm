using System;
using System.Collections.Generic;
using System.Text;

namespace FaeRealm.EventSystem
{
    internal class Condition
    {
        /// <summary>
        /// Conditions are requirements for events to trigger or options to be opened up. 
        /// Typically these will be in arrays
        /// </summary>
        private bool hold;
        private Event affect;

        public Condition(Event affect)
        {
            this.hold = false;
            this.affect = affect;
        }

        public Event ConditionMet()
        {
            this.hold = true;
            return affect;
        }
    }
}
