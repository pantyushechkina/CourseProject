using CourseProject.Models.DbModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        CourseContext db = new CourseContext();
        public async Task<IActionResult> CustomerList()
        {
            return View(await db.Customers.ToListAsync());
        }
        public IActionResult Create() => View();
        [HttpPost]
        public async Task<IActionResult> Create(string firstName, string lastName, string address, string phoneNum, DateTime dateBirth, string passport)
        {
            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) 
                && !string.IsNullOrEmpty(address) && !string.IsNullOrEmpty(phoneNum)
                && !string.IsNullOrEmpty(passport)) 
            {
                using(CourseContext db = new CourseContext())
                {
                    Customer customer = new Customer(firstName,lastName,dateBirth,phoneNum,address,passport);
                    db.Customers.Add(customer);
                    db.SaveChanges();
                }
                //IdentityResult result = await _roleManager.CreateAsync(new IdentityRole(name));
                //if (result.Succeeded)
                //{
                //    return RedirectToAction("Index");
                //}
                //else
                //{
                //    foreach (var error in result.Errors)
                //    {
                //        ModelState.AddModelError(string.Empty, error.Description);
                //    }
                //}
            }
            return View();
        }
    }
}
