using System.Linq;

namespace LinqLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person("John", 18),
                new Person("Alex", 20),
                new Person("Maria", 36)
            };

            // Person? firstPerson = people.FirstOrDefault();
            var firstPerson = people.First();
            var lastPerson = people.LastOrDefault();

            Console.WriteLine(firstPerson.Name);
            Console.WriteLine(lastPerson);
        }
    }
}
