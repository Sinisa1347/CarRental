using CarRentalWeb.Pages.Data;
using CarRentalWeb.Pages.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarRentalWeb.Pages.AvailableCars
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category Category { get; set; }
        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public void OnGet(int id)// uzima od stranice Edit.cshtml
        {
            Category = _db.Category.Find(id);
            TempData["warning"] = "You are about to edit the listed car";


        }


        public async Task <IActionResult> OnPost ()//vrsi objavu tj POST podataka
        {
            if(ModelState.IsValid)
            {
                _db.Category.Update(Category);
                await _db.SaveChangesAsync();
                TempData["success"]="Category edited successfully";
                return RedirectToPage("../AvailableCars/Index");
            }
            return Page();
            

        }
    }
}
