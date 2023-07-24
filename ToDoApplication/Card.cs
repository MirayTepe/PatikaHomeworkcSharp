using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApplication
{
    // Enum for card sizes
    public enum CardSize
    {
        XS = 1,
        S,
        M,
        L,
        XL
    }

    // Sample class to represent a card
    public class Card
    {
     
        public string Title { get; set; }
        public string Content { get; set; }
        public int AssignedTo { get; set; }
        public CardSize Size { get; set; }
        public string Line { get; set; }

       
    }
}
