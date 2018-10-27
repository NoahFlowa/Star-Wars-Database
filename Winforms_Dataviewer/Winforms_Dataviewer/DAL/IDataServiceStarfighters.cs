using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winforms_Dataviewer
{
    public interface IDataServiceStarfighters
    {
        List<StarWarsStarfighters> ReadAll();
        void WriteAll(List<StarWarsStarfighters> starWarsStarfighters);
    }
}
