using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Security.Claims;

namespace Zadanie_4.Pages
{
    public class loginModel : PageModel
    {
        [BindProperty]
        public Cred Cred { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            if (Cred.UserName == "admin@email.com" && Cred.Password == "admin")
            {
                var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name, "Admin"),
                    new Claim(ClaimTypes.Email, "Admin@mywebsite.com")
                };
                var identity = new ClaimsIdentity(claims, "MyCookieAuth");
                ClaimsPrincipal claimsPrincipal = new(identity);

                await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);

                return RedirectToPage("/Index");
            }
            
            if (Cred.UserName == "Ania@email.com" && Cred.Password == "qwerty")
            {
                var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name, "Ania"),
                    new Claim(ClaimTypes.Email, "Ania@email.com")
                };
                var identity = new ClaimsIdentity(claims, "MyCookieAuth");
                ClaimsPrincipal claimsPrincipal = new(identity);

                await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);

                return RedirectToPage("/Index");
            }
            
            if (Cred.UserName == "Marcin@email.com" && Cred.Password == "qwerty")
            {
                var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name, "Marcin"),
                    new Claim(ClaimTypes.Email, "Marcin@email.com")
                };
                var identity = new ClaimsIdentity(claims, "MyCookieAuth");
                ClaimsPrincipal claimsPrincipal = new(identity);

                await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);

                return RedirectToPage("/Index");
            }
            
            if (Cred.UserName == "Jan@email.com" && Cred.Password == "qwerty")
            {
                var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name, "Jan"),
                    new Claim(ClaimTypes.Email, "Jan@email.com")
                };
                var identity = new ClaimsIdentity(claims, "MyCookieAuth");
                ClaimsPrincipal claimsPrincipal = new(identity);

                await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);

                return RedirectToPage("/Index");
            }
            return Page();
        }    
    }

    public class Cred 
    {
        [Required]
        [Display(Name = "Name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
