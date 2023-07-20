using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace UATP_Practice.PATTERNS
{
    // ----------------------------------------------------------------------------------------------------------------------------------
    //  Let's consider an example of an employee leave approval system within an organization.Imagine an organization with multiple
    //  levels of management, including a team lead, a department manager, and a CEO.When an employee submits a leave request, it
    //  needs to go through a chain of approval starting from the team lead, then to the department manager, and finally to the CEO.
    // ----------------------------------------------------------------------------------------------------------------------------------

    // ------------------------------------------------------------------------------------
    // Create an abstract base class or interface called "LeaveApprover" that defines a
    // method to handle leave requests and maintain a reference to the next approver in the
    // chain.
    // ------------------------------------------------------------------------------------

    public abstract class LeaveApprover
    {
        protected LeaveApprover NextApprover;

        public void SetNextApprover(LeaveApprover nextApprover)
        {
            NextApprover = nextApprover;
        }

        public abstract void ProcessLeaveRequest(LeaveRequest leaveRequest);
    }

    // ------------------------------------------------------------------------------------
    // Implement concrete classes for each level of management, such as "TeamLead,"
    // "DepartmentManager," and "CEO." Each class should inherit from the "LeaveApprover"
    // base class or implement the "LeaveApprover" interface.
    // ------------------------------------------------------------------------------------
    // In each concrete class, implement the handling logic for leave requests. If an
    // approver can handle the request, they do so. Otherwise, they pass it to the next
    // approver in the chain.
    // ------------------------------------------------------------------------------------
    // Set up the chain by linking the instances of the concrete classes together in the
    // desired order, representing the hierarchical order of approval.
    // ------------------------------------------------------------------------------------
    // When a leave request is submitted, it is passed to the first approver in the chain
    // (the team lead). If the team lead can't handle it, they pass it to the next approver
    // (department manager), and so on until it reaches the final approver (CEO)
    // or until it is successfully handled at any level.
    // ------------------------------------------------------------------------------------

    // Concrete class representing a Team Lead approver
    public class TeamLead : LeaveApprover
    {
        public override void ProcessLeaveRequest(LeaveRequest leaveRequest)
        {
            if (leaveRequest.Days <= 3)
            {
                Console.WriteLine("Leave request approved by Team Lead");
            }
            else if (NextApprover != null)
            {
                Console.WriteLine("Leave request to long to be approved by Team Lead, sending to Department Mamanger.");
                NextApprover.ProcessLeaveRequest(leaveRequest);
            }
        }
    }

    // Concrete class representing a Department Manager approver
    public class DepartmentManager : LeaveApprover
    {
        public override void ProcessLeaveRequest(LeaveRequest leaveRequest)
        {
            if (leaveRequest.Days <= 7)
            {
                Console.WriteLine("Leave request approved by Department Manager");
            }
            else if (NextApprover != null)
            {
                Console.WriteLine("Leave request to long to be approved by Department Manager, sending to CEO.");
                NextApprover.ProcessLeaveRequest(leaveRequest);
            }
        }
    }

    // Concrete class representing a CEO approver
    public class CEO : LeaveApprover
    {
        public override void ProcessLeaveRequest(LeaveRequest leaveRequest)
        {
            Console.WriteLine("Leave request approved by CEO");
        }
    }

    // Class representing a leave request
    public class LeaveRequest
    {
        public int Days { get; set; }

        public LeaveRequest(int days)
        {
            Days = days;
        }
    }

    // ----------------------------------------------------------------------------------------------------------------------------------
    // This design pattern allows for flexibility and dynamic handling of requests as the chain can be easily modified or extended without
    // affecting the client code or the other classes in the chain. By implementing the Chain of Responsibility pattern, the organization
    // can achieve a clear separation of responsibilities among different levels of management.It also allows for easy customization and
    // scaling of the approval process without tightly coupling the requestors and the approvers, promoting better maintainability and
    // extensibility of the system.
    // ----------------------------------------------------------------------------------------------------------------------------------
}
