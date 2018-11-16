using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_8
{
    class SmartInsurranceRepository
    {
        private List<SmartInsuranceContent> _smartInsuranceContentList = new List<SmartInsuranceContent>();

        public void AddSmartInsuranceContentToList(SmartInsuranceContent content)
        {
        _smartInsuranceContentList.Add(content);
        }
        public List<SmartInsuranceContent> GetSmartInsuranceContentList()
        {
            return _smartInsuranceContentList;
        }

        public void RemoveMenuContentFromList(SmartInsuranceContent content)
        {
            _smartInsuranceContentList.Remove(content);

        }
    }
}
