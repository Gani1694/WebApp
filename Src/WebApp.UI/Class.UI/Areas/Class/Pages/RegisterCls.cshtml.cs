using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppModels;

namespace Class.UI.Areas.Class.Pages
{
    public class RegisterClsModel : PageModel
    {
        [BindProperty]
        public ClassModel? ClassModel { get; set; }
        public async Task OnGetAsync(int? Classid)
        {
            List<ClassModel> classes = new List<ClassModel>()
            {
                new ClassModel(){ClassId = 1,ClassName="LKG",CreatedBy="Anil",CreatedOn=DateTime.Now},
                new ClassModel(){ClassId = 2,ClassName="UKG",CreatedBy="Anil kumar",CreatedOn=DateTime.Now},
                new ClassModel(){ClassId = 2,ClassName="HKG",CreatedBy="Anil kumar",CreatedOn=DateTime.Now}
            };
            if (Classid == null)
            {
                ClassModel = new ClassModel();
            }
            else
            {
                ClassModel = classes.FirstOrDefault(id => id.ClassId == Classid);
            }

            await Task.Delay(10);
        }
        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var model=ClassModel;

            await Task.Delay(10);

            return Page();
        }
    }
}
