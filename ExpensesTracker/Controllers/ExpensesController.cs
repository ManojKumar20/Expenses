using ExpensesTracker.Data;
using ExpensesTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExpensesTracker.Controllers
{
    public class ExpensesController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ExpensesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<ExpenseModel> objExpenseList = _db.ExpenseTracker.ToList();
            return View(objExpenseList);
        }

        public IActionResult ExpenseOperation()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Viewing()
        {
            List<ExpenseModel> objExpenseList = _db.ExpenseTracker.ToList();
            return View(objExpenseList);
        }

        [HttpPost]
        public IActionResult Create(ExpenseModel exp)
        {
            _db.ExpenseTracker.Add(exp);
            _db.SaveChanges();
            return RedirectToAction("ExpenseOperation");
        }
    }
}
