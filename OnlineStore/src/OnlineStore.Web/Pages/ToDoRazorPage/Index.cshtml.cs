using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineStore.Core.Entities;
using OnlineStore.SharedKernel.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineStore.Web.Pages.ToDoRazorPage
{
    public class IndexModel : PageModel
    {
        private readonly IRepository _repository;

        public List<ToDoItem> ToDoItems { get; set; }

        public IndexModel(IRepository repository)
        {
            _repository = repository;
        }

        public async Task OnGetAsync()
        {
            ToDoItems = await _repository.ListAsync<ToDoItem>();
        }
    }
}
