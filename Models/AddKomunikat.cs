using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using Zadanie_4.Pages;


namespace Zadanie_4.Models
{
    public class AddKomunikat
    {
        public Guid Id { get; set; }
        public string User { get; set; }
        public string MesText { get; set; }
        public string Recipient { get; set; }
    }
}
