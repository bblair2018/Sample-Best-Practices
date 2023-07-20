using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UATP_Practice.PATTERNS
{
    // ----------------------------------------------------------------------------------------------------------------------------------
    // Let's say you have a hierarchical structure of employees in an organization, where each employee can have subordinates. You want
    // to calculate the total salary of the organization by summing up the salaries of individual employees. In this case, you can use
    // the Composite Pattern to represent the hierarchical structure and perform operations on the entire structure as well as individual
    // elements.
    // ----------------------------------------------------------------------------------------------------------------------------------

    // ------------------------------------------------------------------------------------
    // First, define an abstract base class or interface that represents the common
    // operations for both individual employees and groups of employees:
    // ------------------------------------------------------------------------------------

    public abstract class EmployeeComponent
    {
        public string Name { get; set; }

        public abstract decimal GetSalary();
        public abstract void Add(EmployeeComponent component);
        public abstract void Remove(EmployeeComponent component);
    }

    // ------------------------------------------------------------------------------------
    // Next, implement the leaf node class that represents an individual employee:
    // ------------------------------------------------------------------------------------

    public class Employee : EmployeeComponent
    {
        public decimal Salary { get; set; }

        public override decimal GetSalary()
        {
            return Salary;
        }

        public override void Add(EmployeeComponent component)
        {
            // Cannot add components to a leaf node
            throw new NotImplementedException();
        }

        public override void Remove(EmployeeComponent component)
        {
            // Cannot remove components from a leaf node
            throw new NotImplementedException();
        }
    }

    // ------------------------------------------------------------------------------------
    // Then, implement the composite class that represents a group of employees:
    // ------------------------------------------------------------------------------------

    public class EmployeeGroup : EmployeeComponent
    {
        private List<EmployeeComponent> _subordinates = new List<EmployeeComponent>();

        public override decimal GetSalary()
        {
            decimal totalSalary = 0;
            foreach (var subordinate in _subordinates)
            {
                totalSalary += subordinate.GetSalary();
            }
            return totalSalary;
        }

        public override void Add(EmployeeComponent component)
        {
            _subordinates.Add(component);
        }

        public override void Remove(EmployeeComponent component)
        {
            _subordinates.Remove(component);
        }
    }

    // ----------------------------------------------------------------------------------------------------------------------------------
    // Overall, this example demonstrates the Composite pattern by creating an abstraction (EmployeeComponent) that represents individual
    // employees and groups of employees, providing a uniform interface to work with both leaf and composite nodes, and supporting recursive
    // operations on the hierarchy of employees.
    // ----------------------------------------------------------------------------------------------------------------------------------

}
