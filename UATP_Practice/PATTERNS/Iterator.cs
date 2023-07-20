using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UATP_Practice.PATTERNS
{
    // ------------------------------------------------------------------------------------
    // FullTimeEmployee class representing a full-time employee in the organization
    // ------------------------------------------------------------------------------------

    /// <summary>
    /// FullTimeEmployee class, which represents a full-time employee in the organization. The class includes properties for name, position, and salary.
    /// </summary>
    public class FullTimeEmployee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
    }

    // ------------------------------------------------------------------------------------
    // Organization class implementing IEnumerable
    // ------------------------------------------------------------------------------------

    /// <summary>
    /// The Organization class remains the same, implementing the IEnumerable interface. 
    /// It creates an array of FullTimeEmployee objects and returns an instance of the 
    /// OrganizationIterator class from the GetEnumerator method.
    /// </summary>
    public class Organization : IEnumerable
    {
        private FullTimeEmployee[] _employees;

        public Organization()
        {
            _employees = new FullTimeEmployee[3];
            _employees[0] = new FullTimeEmployee { Name = "John Doe", Position = "Manager", Salary = 5000 };
            _employees[1] = new FullTimeEmployee { Name = "Jane Smith", Position = "Developer", Salary = 4000 };
            _employees[2] = new FullTimeEmployee { Name = "Mike Johnson", Position = "Designer", Salary = 3500 };
        }

        public IEnumerator GetEnumerator()
        {
            return new OrganizationIterator(_employees);
        }
    }

    // ------------------------------------------------------------------------------------
    // Iterator class for the Organization
    // ------------------------------------------------------------------------------------

    /// <summary>
    /// The OrganizationIterator class is also updated to work with FullTimeEmployee objects. 
    /// It maintains a current index while iterating over the employee array, and the Current 
    /// property returns the FullTimeEmployee at the current index.
    /// </summary>
    public class OrganizationIterator : IEnumerator
    {
        private FullTimeEmployee[] _employees;
        private int _currentIndex;

        public OrganizationIterator(FullTimeEmployee[] employees)
        {
            _employees = employees;
            _currentIndex = -1;
        }

        public bool MoveNext()
        {
            _currentIndex++;
            return _currentIndex < _employees.Length;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }

        public object Current
        {
            get
            {
                if (_currentIndex >= 0 && _currentIndex < _employees.Length)
                    return _employees[_currentIndex];
                throw new InvalidOperationException();
            }
        }
    }

    // ----------------------------------------------------------------------------------------------------------------------------------
    // In summary, while using a List or array for iteration is often sufficient, the Iterator Pattern provides benefits when you require
    // better abstraction, flexibility, multiple iterations, concurrent iteration, lazy evaluation, or compliance with design principles.
    // It is particularly useful when dealing with complex data structures, implementing custom collection types, or when you anticipate
    // changing requirements that may affect the way you iterate over the collection.
    // ----------------------------------------------------------------------------------------------------------------------------------
}
