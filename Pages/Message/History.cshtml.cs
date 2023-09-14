using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zadanie_4.Data;
using Zadanie_4.Models;

namespace Zadanie_4.Pages.Message
{
    [Authorize]
    public class HistoryModel : PageModel
    {
        private readonly KomDbContext komDb;
        public List<Komunikat> listt { get; set; }

        public HistoryModel(KomDbContext komDb)
        {
            this.komDb = komDb;
        }
        public void OnGet() 
        {
            listt = komDb.messages.ToList();
        }
    }
}
