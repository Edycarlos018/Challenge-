using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class Komodo_Cafe
    {
        public string CafeName { get; set; }
        public List<MenuContent> MenuContentList { get; set; }

        public Komodo_Cafe(string komodo, List<MenuContent> menuContentList )
        {
            CafeName = komodo;
            MenuContentList = menuContentList;
        }
        public Komodo_Cafe()
        {

        }
    }
}
