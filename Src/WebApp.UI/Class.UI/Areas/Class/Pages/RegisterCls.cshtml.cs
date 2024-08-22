using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppModels;

namespace Class.UI.Areas.Class.Pages
{
    public class RegisterClsModel : PageModel
    {
        [BindProperty]
        public ClassModel ClassModel { get; set; }
        public async Task OnGetAsync()
        {
            ClassModel=new ClassModel();

            await Task.Delay(10);
        }
        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var model=ClassModel;

            return Page();
        }
    }
}
