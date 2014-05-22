using EmployeeQuiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeQuiz.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Index(Employe emp)
        {

            //Creo el objeto del modelo de datos
            Payrolldm nomina = new Payrolldm(
                @"C:\Users\vladimir\Desktop\karime\Proll\EmployeeQuiz\Models\EmployeeDb.csv");

            //busco el empleado dado su id
            var empleado = nomina.GetEmployeById(emp.Id);



            return View("WorkerView", empleado);
        }




    }
}
