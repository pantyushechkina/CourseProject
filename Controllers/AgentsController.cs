using CourseProject.Models.DbModels;
using CourseProject.Models.SortedModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Controllers
{
    public class AgentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        CourseContext db = new CourseContext();
        public async Task<IActionResult> AgentsList()
        {
            var agents = from a in db.Agents
                         join t in db.TypesAgent
                         on a.Type equals t.Id
                         join p in db.TypesPayment
                         on a.Payment equals p.Id
                         select new AgentSorted
                         {
                             Id = a.Id,
                             FirstName = a.FirstName,
                             LastName = a.LastName,
                             Type = t.Type,
                             Payment = p.Type
                         };
            return View(await agents.ToListAsync());
        }
    }
}
