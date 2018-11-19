using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    class GreetRepository
    {
         List<GreetContent> _newGreetContentList = new List<GreetContent>();
        public void AddGreetContentToList (GreetContent content)
        {
            _newGreetContentList.Add(content);
        }
        public List<GreetContent> GetGreetContentList()
        {
            return _newGreetContentList;
        }
        public void RemoveGreetContent (GreetContent content)
        {
            _newGreetContentList.Remove(content);
        }
    }
}
