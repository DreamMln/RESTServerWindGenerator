using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTServerWindGenerator.Models
{
    public class Wind
    {
        public int ID { get; set; }
        public int Speed { get; set; }
        public string Direction { get; set; }

        public Wind()
        {
            //default
        }
        public Wind(int id, int speed, string direction)
        {
            ID = id;
            Speed = speed;
            Direction = direction;
        }
    }
}
