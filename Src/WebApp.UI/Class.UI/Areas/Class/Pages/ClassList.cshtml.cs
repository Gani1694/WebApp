using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppModels;

namespace Class.UI.Areas.Class.Pages
{
    public class ClassListModel : PageModel
    {
        public List<ClassModel>? classes { get; set; }
        public async Task OnGet()
        {
            await GetClassList();
        }
        private async Task GetClassList()
        {
            await Task.Run(()=> classes = new List<ClassModel>()
            {
                new ClassModel(){ClassId = 1,ClassName="LKG",CreatedBy="Anil",CreatedOn=DateTime.Now},
                new ClassModel(){ClassId = 2,ClassName="UKG",CreatedBy="Anil kumar",CreatedOn=DateTime.Now},
                new ClassModel(){ClassId = 2,ClassName="HKG",CreatedBy="Anil kumar",CreatedOn=DateTime.Now},
                 new ClassModel(){ClassId = 1,ClassName="LKG",CreatedBy="Anil",CreatedOn=DateTime.Now},
                new ClassModel(){ClassId = 2,ClassName="UKG",CreatedBy="Anil kumar",CreatedOn=DateTime.Now},
                new ClassModel(){ClassId = 2,ClassName="HKG",CreatedBy="Anil kumar",CreatedOn=DateTime.Now},
                 new ClassModel(){ClassId = 1,ClassName="LKG",CreatedBy="Anil",CreatedOn=DateTime.Now},
                new ClassModel(){ClassId = 2,ClassName="UKG",CreatedBy="Anil kumar",CreatedOn=DateTime.Now},
                new ClassModel(){ClassId = 2,ClassName="HKG",CreatedBy="Anil kumar",CreatedOn=DateTime.Now},
                 new ClassModel(){ClassId = 1,ClassName="LKG",CreatedBy="Anil",CreatedOn=DateTime.Now},
                new ClassModel(){ClassId = 2,ClassName="UKG",CreatedBy="Anil kumar",CreatedOn=DateTime.Now},
                new ClassModel(){ClassId = 2,ClassName="HKG",CreatedBy="Anil kumar",CreatedOn=DateTime.Now},
                 new ClassModel(){ClassId = 1,ClassName="LKG",CreatedBy="Anil",CreatedOn=DateTime.Now},
                new ClassModel(){ClassId = 2,ClassName="UKG",CreatedBy="Anil kumar",CreatedOn=DateTime.Now},
                new ClassModel(){ClassId = 2,ClassName="HKG",CreatedBy="Anil kumar",CreatedOn=DateTime.Now}, new ClassModel(){ClassId = 1,ClassName="LKG",CreatedBy="Anil",CreatedOn=DateTime.Now},
                new ClassModel(){ClassId = 2,ClassName="UKG",CreatedBy="Anil kumar",CreatedOn=DateTime.Now},
                new ClassModel(){ClassId = 2,ClassName="HKG",CreatedBy="Anil kumar",CreatedOn=DateTime.Now},
                 new ClassModel(){ClassId = 1,ClassName="LKG",CreatedBy="Anil",CreatedOn=DateTime.Now},
                new ClassModel(){ClassId = 2,ClassName="UKG",CreatedBy="Anil kumar",CreatedOn=DateTime.Now},
                new ClassModel(){ClassId = 2,ClassName="HKG",CreatedBy="Anil kumar",CreatedOn=DateTime.Now},
                 new ClassModel(){ClassId = 1,ClassName="LKG",CreatedBy="Anil",CreatedOn=DateTime.Now},
                new ClassModel(){ClassId = 2,ClassName="UKG",CreatedBy="Anil kumar",CreatedOn=DateTime.Now},
                new ClassModel(){ClassId = 2,ClassName="HKG",CreatedBy="Anil kumar",CreatedOn=DateTime.Now},
                 new ClassModel(){ClassId = 1,ClassName="LKG",CreatedBy="Anil",CreatedOn=DateTime.Now},
                new ClassModel(){ClassId = 2,ClassName="UKG",CreatedBy="Anil kumar",CreatedOn=DateTime.Now},
                new ClassModel(){ClassId = 2,ClassName="HKG",CreatedBy="Anil kumar",CreatedOn=DateTime.Now},
                 new ClassModel(){ClassId = 1,ClassName="LKG",CreatedBy="Anil",CreatedOn=DateTime.Now},
                new ClassModel(){ClassId = 2,ClassName="UKG",CreatedBy="Anil kumar",CreatedOn=DateTime.Now},
                new ClassModel(){ClassId = 2,ClassName="HKG",CreatedBy="Anil kumar",CreatedOn=DateTime.Now}
            });
        }
    }
}
