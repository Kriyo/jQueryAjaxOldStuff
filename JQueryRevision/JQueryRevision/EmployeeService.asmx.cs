using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace JQueryRevision
{
    /// <summary>
    /// Summary description for EmployeeService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)] 
    [System.Web.Script.Services.ScriptService]
    public class EmployeeService : System.Web.Services.WebService
    {

        [Serializable]
        public class Employee
        {
            public string FullName { get; set; }
            public string ID { get; set; }
            public string Title { get; set; }
            public string Department { get; set; }
            public Employee() { }
            public Employee(string empID)
            {
                //simulate employee lookup
                this.ID = empID;
                this.Title = "Keeper Of The Whereabouts";
                this.Department = "Dept of Really Hustling Things Along";
                this.FullName = "Tristram Shandy";
            }
        }
        [WebMethod]
        public Employee GetEmployeeById(string EmployeeId)
        {
            return new Employee(EmployeeId);
        }
    }
}
