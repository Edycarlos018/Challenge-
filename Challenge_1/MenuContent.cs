using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class MenuContent : IEquatable<MenuContent>
    {
        public bool Equals(MenuContent other)
        {
            if (other == null) return false;
            return (this.ItemNumber.Equals(other.ItemNumber));
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            MenuContent objAsPart = obj as MenuContent;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public override int GetHashCode()
        {
            return ItemNumber;
        }

        public int ItemNumber { get; set; }
        public string MenuName { get; set; }
        public string MenuDescription { get; set; }
        public string MenuIngredients { get; set; }
        public int MenuPrice { get; set; }

        public MenuContent(int itemnumber, string menuname, string menudescription, string menuingredients, int menuprice)
        {
            ItemNumber = itemnumber;
            MenuName = menuname;
            MenuDescription = menudescription;
            MenuIngredients = menuingredients;
            MenuPrice = menuprice;
        }
        public MenuContent()
        {

        }
      
    }


}

