using RESTServerWindGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTServerWindGenerator.Managers
{
    public class WindGeneratorsManager : IWindGeneratorsManager
    {
        private static int _nextID = 1;
        private static List<Wind> _windGeneratorList = new List<Wind>()
        {
            new Wind() { ID = _nextID++, Speed = 300, Direction = "N" },
            new Wind() { ID = _nextID++, Speed = 400, Direction = "V" },
            new Wind() { ID = _nextID++, Speed = 500, Direction = "S" },
            new Wind() { ID = _nextID++, Speed = 600, Direction = "E" },
            new Wind() { ID = _nextID++, Speed = 700, Direction = "SV" },
        };

        public IEnumerable<Wind> GetAll()
        {
            List<Wind> result = new List<Wind>(_windGeneratorList);
            return result;
        }

        //filter
        public IEnumerable<Wind> GetFilter(int filter)
        {
            IEnumerable<Wind> result = _windGeneratorList.Where(x => x.Speed >= filter);
            return result;
        }

        public Wind AddWind(Wind addWind)
        {
            if (addWind == null)
            {
                return null;
            }
            //ellers
            addWind.ID = _nextID++;
            _windGeneratorList.Add(addWind);
            return addWind;
        }
    }
}
