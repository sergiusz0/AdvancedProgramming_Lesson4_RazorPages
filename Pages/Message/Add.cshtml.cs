using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zadanie_4.Data;
using Zadanie_4.Models;

namespace Zadanie_4.Pages.Message
{
    [Authorize]
    public class AddModel : PageModel
    {
        private readonly KomDbContext komDbContext;
        [BindProperty]
        public AddKomunikat AddMessageRequest { get; set; }

        public AddModel(KomDbContext komDbContext)
        {
            this.komDbContext = komDbContext;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var Message = new Komunikat()
            {
                MesText = AddMessageRequest.MesText,
                Recipient = AddMessageRequest.Recipient,
                User = this.User.Identity.Name

            };
            komDbContext.messages.Add(Message);
            komDbContext.SaveChanges();

            return RedirectToPage("History");
        }
    }
}
