using System.Diagnostics.CodeAnalysis;
using Core.Aspects;

namespace Entities
{
    public interface IEmployee
    {
        void Add(int id, string firstName, string lastName);
        void Update(int id, string firstName, string lastName);
    }
    public class Employee : IEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DefensiveProgrammingAspect(Priority = 1)]
        [InterceptionAspect(Priority = 2)]
        public virtual void Add(int id, string firstName, string lastName)
        {
            //Console.WriteLine($"\t id: {id} \n\t FirstName: {firstName} \n\t LastName: {lastName}");
            Console.WriteLine("Added");
        }
        public virtual void Update(int id, string firstName, string lastName)
        {
            Console.WriteLine("Updated");
        }
    }
}
