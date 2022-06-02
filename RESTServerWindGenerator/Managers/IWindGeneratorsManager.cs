using RESTServerWindGenerator.Models;
using System.Collections.Generic;

namespace RESTServerWindGenerator.Managers
{
    public interface IWindGeneratorsManager
    {
        //hvorfor er det smart at have et interface
        //In Object oriented programming languages in short an interface is
        //en kontrakt specifikation.
        //Et Interface betyder "a point where two systems, subjects,
        //organizations, etc and interact."
        //An interface is the smallest, thinnest, and least complicated thing you can
        //couple your code to. And I hope you know by now that loosely coupled code is good.
        //interface is a contractual obligation to implement certain methods, properties and
        //events. The compelling benefit of a statically typed language is that the
        //compiler can verify that a contract which your code relies upon is actually met.
        //Interfaces are useful for the following: Capturing similarities among unrelated
        //classes without artificially forcing a class relationship.

        //This interface was extracted from the ItemsManager class
        //Nothing has been added manually

        Wind AddWind(Wind addWind);
        IEnumerable<Wind> GetAll();
        IEnumerable<Wind> GetFilter(int filter);
    }
}