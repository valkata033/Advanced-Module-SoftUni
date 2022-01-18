using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            People = new List<Person>();
        }

        public List<Person> People { get; set; }
        
        public void AddMember(Person person)
        {
            People.Add(person);
        }

        public List<Person> GetOldestMember()
        {
            List<Person> oldestPerson = People
                .OrderBy(x => x.Age > 30).ToList();

            List<Person> list = new List<Person>();

            foreach (var item in oldestPerson.OrderBy(x => x.Name))
            {
                if (item.Age > 30)
                {
                    list.Add(item);
                }
            }

            return list;
        }
    }
}
