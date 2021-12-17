using System;
using System.Collections.Generic;
using System.Text;

namespace FaeRealm.EventSystem
{
    /// <summary>
    /// The core of the EventSystem
    /// 
    /// Our first 'Event' will be assigned here,  thereby all events will precede it, and many events can point back to it.
    /// </summary>
    class Event
    {
        private string text;
        private EventFunction[] progression;

        //Conditions are assigned to Events
        public Event(string text, EventFunction[] Progression) 
        {
            this.text = text;
            this.progression = Progression;
        }
    }
}
