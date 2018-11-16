using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4
{
     class BadgeIdRepository
    {
        List<string> _listofBadgeId = new List<string>();

        public void AddBadgeIdToList(string content)
        {
            _listofBadgeId.Add(content);
        }

        public List<string> GetContentIdList()
        {
            return _listofBadgeId;
        }

        public void RemoveDoorFromList(string content)
        {
            _listofBadgeId.Remove(content);

        }

        public bool CheckAnswer(string input)
        {
                switch (input)
                {
                    case "y":
                        return true;
                    default:
                        return false;
                }
        }
    }
}
