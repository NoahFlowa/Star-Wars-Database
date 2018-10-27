using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winforms_Dataviewer
{
    public interface IDataServicePlanets
    {
        List<StarWarsPlanets> ReadAll();
        void WriteAll(List<StarWarsPlanets> starWarsPlanets);
    }
}
