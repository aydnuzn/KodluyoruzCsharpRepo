using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_ToDoApp
{
    public class Card
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int AssignedPerson { get; set; }
        public CardSize Size { get; set; }
        public CardLine Line { get; set; }
    }
}
