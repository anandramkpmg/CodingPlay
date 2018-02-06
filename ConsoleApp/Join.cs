using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Person
    {
        public string Name { get; set; }
    }

    class Pet
    {
        public string Name { get; set; }
        public Person Owner { get; set; }
    }

    public class JoinQuery
    {
        public static void Join()
        {
            Person magnus = new Person { Name = "Hedlund, Magnus" };
            Person terry = new Person { Name = "Adams, Terry" };
            Person charlotte = new Person { Name = "Weiss, Charlotte" };

            Pet barley = new Pet { Name = "Barley", Owner = terry };
            Pet boots = new Pet { Name = "Boots", Owner = terry };
            Pet whiskers = new Pet { Name = "Whiskers", Owner = charlotte };
            Pet daisy = new Pet { Name = "Daisy", Owner = magnus };

            List<Person> people = new List<Person> { magnus, terry, charlotte };
            List<Pet> pets = new List<Pet> { barley, boots, whiskers, daisy };

            var query = from p in people
                join pet in pets on p.Name equals pet.Owner.Name
                select new { pet.Name, PeopleName = p.Name };

            foreach (var q in query)
            {
                Console.WriteLine(q.PeopleName + ": "+ q.Name);
            }

            Console.ReadLine();

        }
    }

    public class AnotherQuery
    {
        class GpsDevice
        {
            public string Name;
            public bool IsActive;
        }

        class GpsManufacturer
        {
            public string Name;
            public GpsDevice[] Devices;
        }

        static List<GpsManufacturer> gpsManufacturers =
            new List<GpsManufacturer>
            {
                new GpsManufacturer
                {Name = "manf1",
                    Devices = new GpsDevice[]
                    {
                        new GpsDevice {Name = "device1", IsActive = true},
                        new GpsDevice {Name = "device2", IsActive = false}
                    }
                },
                new GpsManufacturer
                {Name = "manf2",
                    Devices = new GpsDevice[]
                    {
                        new GpsDevice {Name = "device1", IsActive = false},
                        new GpsDevice {Name = "device2", IsActive = false}
                    }
                },
                new GpsManufacturer
                    {Name = "manf3"}
            };

        public static void MaufactureHaveAlteastOneGps()
        {
            var manu = gpsManufacturers.Where(x => x.Devices != null && x.Devices.Any(d => d.IsActive));

            foreach (var m in manu)
            {
                Console.WriteLine(m.Name);
            }
        }

        public static void CountOfActiveManufactures()
        {
            var manu = gpsManufacturers.Count(x => x.Devices != null && x.Devices.Any(d => d.IsActive));

            Console.WriteLine(manu);
        }
    }
    
}
