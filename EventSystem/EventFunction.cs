using FaeRealm.EventSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace FaeRealm
{
    /// <summary>
    /// Event Function is List for Events, assigning adjacent Events and holding conditionals
    /// 
    /// requirements are the list of conditions in order to activate the event
    /// 
    /// Progression is the pointers to the next node (event) whereby the player would move to 
    /// (if their event function requirements are met)
    /// </summary>
    class EventFunction
    {
        Condition[] requirements;
        
        public EventFunction(Condition[] requirements)
        {
            this.requirements = requirements;
        }
    }
}
