using CarRentalWeb.Pages.Data;
using CarRentalWeb.Pages.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarRentalWeb.Pages.AvailableCars
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category Category { get; set; }
        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public void OnGet(int id)
        {
            Category = _db.Category.Find(id);
            TempData["error"] = "You are about to delete the car from car list";
        }


        public async Task <IActionResult> OnPost ()
        {

            _db.Category.Remove(Category);
            await _db.SaveChangesAsync();
            TempData["success"]="Category deleted successfully";
            return RedirectToPage("../AvailableCars/Index");

            return Page();
            

        }
    }
}
