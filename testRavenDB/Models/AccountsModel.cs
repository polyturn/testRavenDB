using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testRavenDB.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateJoined { get; set; }
        public Position Position { get; set; }
        public Department Department { get; set; }
    }
    public class Position
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class Department
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}