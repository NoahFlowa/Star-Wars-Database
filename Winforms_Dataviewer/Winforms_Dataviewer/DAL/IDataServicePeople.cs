using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winforms_Dataviewer
{
    public interface IDataServicePeople
    {
        List<StarWarsPeople> ReadAll();
        void WriteAll(List<StarWarsPeople> starWarsPeople);
    }
}
