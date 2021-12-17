using System.Collections.Generic;
using System.Windows;

namespace FaeRealm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    ///below is the Encounter class structure for the entire program. 
    //From the beginning, the player begins in the first encounter (character building) which will give them options and data to pass to strings or key presses.
    //it passes to the first 'room' that the player interacts with (displaying an image and options), and then the player chooses options as 'event's unfold'
    ///both rooms and events are structurally Encounters
    public class Encounter //encounters are the superclass structure for both events and rooms
    {
        private string text;
        private List<Condition> conditions;
        private Image visual;
        
        //TODO CHANGE TO LIST
        public Encounter(Condition conditions, string text)//for making choices only
        {
            this.conditions = conditions;//display choices in text (hitting keys)
            this.text = text;
        }

        //TODO CHANGE TO LIST
        public Encounter(Condition[] conditions, int conditionsLength, Image visual, string text) //for rooms
        {
            this.conditions = conditions;
            //assign conditions and choices to the same array. conditionsLength is where the 'if statements' (conditions) end and the choices begin
            this.text = text;
            //display choices within text
            this.visual = visual;
            //display image
        }

    }
    
    public class Image //passing for encounter Rooms
    {

    }

}
