using CarRentalWeb.Pages.Data;
using CarRentalWeb.Pages.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarRentalWeb.Pages.AvailableCars
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category Category { get; set; }
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public void OnGet()
        {
            TempData["warning"] = "You are about to add a new car";
        }


        public async Task <IActionResult> OnPost ()
        {
            if(ModelState.IsValid)
            {
                await _db.Category.AddAsync(Category);
                await _db.SaveChangesAsync();
                TempData["success"] = "Category successfully created";
                return RedirectToPage("../AvailableCars/Index");
            }
            return Page();
            

        }
    }
}
