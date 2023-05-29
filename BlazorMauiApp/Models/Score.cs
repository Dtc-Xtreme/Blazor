using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMauiApp.Models
{
    public class Score
    {
        public Score(int home, int visitor)
        {
            Home = home;
            Visitor = visitor;
        }

        public int Home { get; set; }
        public int Visitor { get; set; }

        public bool Won
        {
            get
            {
                return Home == 13 ? true : false;
            }
        }
        public int Points
        {
            get { return Home - Visitor; }
        }

        public override string ToString()
        {
            return Home + " / " + Visitor;
        }
    }
}
