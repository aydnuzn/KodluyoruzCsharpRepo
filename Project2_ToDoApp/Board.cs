using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_ToDoApp
{
    public class Board
    {
        public List<Card> TodoLine { get; set; }
        public List<Card> InProgress { get; set; }
        public List<Card> Done { get; set; }

    }
}
