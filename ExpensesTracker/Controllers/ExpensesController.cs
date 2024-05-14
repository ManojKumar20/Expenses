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

        [HttpPost]
        public IActionResult Create(ExpenseModel exp)
        {
            try
            {
                _db.ExpenseTracker.Add(exp);
                _db.SaveChanges();
                TempData["success"] = "Expenses added successfully";
                return RedirectToAction("ExpenseOperation");
            }
            catch (Exception ex)
            {
                TempData["error"] = "Failed to add expense";
                return BadRequest();
            }
        }

        public IActionResult Viewing()
        {
            List<ExpenseModel> objExpenseList = _db.ExpenseTracker.ToList();
            return View(objExpenseList);
        }

        public IActionResult Update()
        {
            List<ExpenseModel> objExpenseList = _db.ExpenseTracker.ToList();
            return View(objExpenseList);
        }

        public IActionResult Edit(int? id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }
            ExpenseModel? expenseModel = _db.ExpenseTracker.Find(id);
            return View(expenseModel);
        }

        [HttpPost]
        public IActionResult Edit(ExpenseModel exp)
        {
            try
            {
                _db.ExpenseTracker.Update(exp);
                _db.SaveChanges();
                TempData["success"] = "Expenses updated successfully";
                return RedirectToAction("ExpenseOperation");
            }
            catch(Exception ex)
            {
                TempData["error"] = "Failed to update expense";
                return BadRequest();
            }
        }

        public IActionResult Delete()
        {
            List<ExpenseModel> objExpenseList = _db.ExpenseTracker.ToList();
            return View(objExpenseList);
        }

        //public IActionResult Remove(int? id)
        //{
        //    if (id == 0 || id == null)
        //    {
        //        return NotFound();
        //    }
        //    ExpenseModel? expenseModel = _db.ExpenseTracker.Find(id);
        //    return View(expenseModel);
        //}

        //[HttpPost,ActionName("Remove")]
        public IActionResult Remove(int? id)
        {
            try
            {
                ExpenseModel? obj = _db.ExpenseTracker.Find(id);
                if (obj == null)
                {
                    return NotFound();
                }
                _db.ExpenseTracker.Remove(obj);
                _db.SaveChanges();
                TempData["success"] = "Expenses deleted successfully";
                return RedirectToAction("ExpenseOperation");
            }
            catch (Exception ex)
            {
                TempData["error"] = "Failed to delete expense";
                return BadRequest();
            }
        }
    }
}
