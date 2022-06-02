using RESTServerWindGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTServerWindGenerator.Managers
{
    public class WindGeneratorDB : IWindGeneratorsManager
    {
        //DENNE ANVENDES DA INFO WIND NU TILFØJES OG HENTES FRA DB
        //Remeber the Context from the constructor as it is used in all/most methods
        //ref windContext
        private WindContext _context;

        //The constructor takes a Context from whoever initialized it
        public WindGeneratorDB(WindContext context)
        {
            _context = context;
        }

        public IEnumerable<Wind> GetAll()
        {
            //LINQ
            IEnumerable<Wind> winds =
                from wind in _context.Wind 
                select wind;

            //converts the DbSet to a List
            return winds;
        }

        //filter
        public IEnumerable<Wind> GetFilter(int filter)
        {
            IEnumerable<Wind> winds =
                                from wind in _context.Wind
                                where wind.Speed >= filter
                                select wind;

            //converts the DbSet to a List with filter
            return winds;
        }
        //Add/Post
        //Setting the Id to 0, so the database doesn't try to insert the
        //ID from the caller
        //it should be the database that assigns the Id's - ID'et er auto increment
        public Wind AddWind(Wind addWind)
        {
            //ID fra DB
            addWind.ID = 0;
            _context.Wind.Add(addWind);
            //save changes, so that everything is saved to DB
            _context.SaveChanges();
            //return the added item
            return addWind;
        }
    }
}
