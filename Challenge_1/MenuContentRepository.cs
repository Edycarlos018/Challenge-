using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class MenuContentRepository
    {
       private List<MenuContent> _menuContentList = new List<MenuContent>();

        public void AddMenuContentToList(MenuContent content)
        {
            _menuContentList.Add(content);
        }
        public List<MenuContent> GetMenuContentList()
        {
            return _menuContentList;
        }

        public void RemoveMenuContentFromList(MenuContent content)
        {
            _menuContentList.Remove(content);
         
        }
    }
}
