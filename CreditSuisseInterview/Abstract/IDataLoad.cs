using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisseInterview
{
    public interface IDataLoad
    {
        List<Trade> LoadData(string filePath);

    }
}
