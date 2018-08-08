using System;
using System.Web.Mvc;
using CRUDUsingDapper.Models;
using CRUDUsingDapper.Repository;
namespace CRUDUsingMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee/GetAllEmpDetails
        public ActionResult GetAllEmpDetails()
        {
            EmpRepository empRepo = new EmpRepository();
            return View(empRepo.GetAllEmployees());
        }

        // GET: Employee/AddEmployee
        public ActionResult AddEmployee()
        {
            return View();
        }

        // POST: Employee/AddEmployee
        [HttpPost]
        public ActionResult AddEmployee(EmpModel Emp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmpRepository empRepo = new EmpRepository();
                    empRepo.AddEmployee(Emp);
                    ViewBag.Message = "Records added successfully.";
                }
                return View();
            }
            catch(Exception e)
            {
                ViewBag.Message = e.Message;
                return View();
            }
        }

        // GET: Bind controls to Update details
        public ActionResult EditEmpDetails(int id)
        {
            EmpRepository empRepo = new EmpRepository();
            return View(empRepo.GetAllEmployees().Find(emp => emp.Empid == id));
        }

        // POST:Update the details into database
        [HttpPost]
        public ActionResult EditEmpDetails(int id, EmpModel obj)
        {
            try
            {
                EmpRepository empRepo = new EmpRepository();
                empRepo.UpdateEmployee(obj);
                return RedirectToAction("GetAllEmpDetails");
            }
            catch
            {
                return View();
            }
        }

        // GET: Delete  Employee details by id
        public ActionResult DeleteEmp(int id)
        {
            try
            {
                EmpRepository empRepo = new EmpRepository();
                if (empRepo.DeleteEmployee(id))
                {
                    ViewBag.AlertMsg = "Employee details deleted successfully";
                }
                return RedirectToAction("GetAllEmpDetails");
            }
            catch
            {
                return RedirectToAction("GetAllEmpDetails");
            }
        }
    }
}