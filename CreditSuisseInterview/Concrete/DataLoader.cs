using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisseInterview.Concrete
{
    public class DataLoader
    {
        private readonly IDataLoad _dataLoad;
        public DataLoader(IDataLoad dataLoad)
        {
            _dataLoad = dataLoad;
        }

        public List<Trade> Load(string filePath)
        {
            return _dataLoad.LoadData(filePath);
        }
    }
}
