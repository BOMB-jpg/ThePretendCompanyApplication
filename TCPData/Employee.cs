using System;
namespace TCPData
{
    //员工类的六个属性包括 id firstname LastName AnnualSalary IsManager
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal AnnualSalary { get; set; }
        public bool IsManager { get; set; }
        public int DepartmentId { get; set; }
    }
}
