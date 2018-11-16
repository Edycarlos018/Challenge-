using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class OutingRepository
    {
        List<OutingContent> _outingContentList = new List<OutingContent>();

        public void AddOutingContentToList(OutingContent content)
        {
            _outingContentList.Add(content);
        }
        public List<OutingContent> GetOutingContentList()
        {
            return _outingContentList;
        }
        public void RemoveOutingContentFromList(OutingContent content)
        {
            _outingContentList.Remove(content);
        }
        public decimal GetTotalOutingCost()
        {
            decimal totalEventCost = 0;
            foreach (OutingContent outing in _outingContentList)
            {
                totalEventCost += outing.EventCost;
            }
            return totalEventCost;
        }
    }
}
