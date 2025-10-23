using ExpenseTracker.DtoModels;
using ExpenseTracker.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly IFinanceService service;
        public ExpenseController(IFinanceService _service)
        {
            service = _service;
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new ExpenseDto();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Add(ExpenseDto model)
        {
            if (!ModelState.IsValid)
            {
                model = new ExpenseDto();
                 View(model);
            }
            service.AddAsync(model);
            return  RedirectToAction("Index","Home");
        }
    }
}
