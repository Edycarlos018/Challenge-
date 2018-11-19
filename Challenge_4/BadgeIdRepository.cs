using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4
{
    class BadgeRepository
    {
        List<string> doorList = new List<string>();
        Dictionary<int, List<string>> badgeID = new Dictionary<int, List<string>>();

        public void AddDoorToList(string door)
        {
            doorList.Add(door);
        }

        public void AddBadgeToDictionary(BadgeContent badge)
        {
            badgeID.Add(badge.IdNumber, badge.DoorList);
        }

        public List<string> GetList()
        {
            return doorList;
        }
        public void RemoveDoorFromBadge(string doorlistRemo)
        {
            doorList.Remove(doorlistRemo);
        }

        public Dictionary<int, List<string>> GetBadge()
        {
            return badgeID;
        }

        public void RemoveBadgeFromList(int badgeKey)
        {
            badgeID.Remove(badgeKey);
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
