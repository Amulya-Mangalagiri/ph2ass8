using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class AdvancedDbEntities
    {
        public IEnumerable<Employee> Employees { get; internal set; }
    }
}