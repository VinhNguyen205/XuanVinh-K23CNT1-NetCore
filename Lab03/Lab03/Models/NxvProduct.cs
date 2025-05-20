using Microsoft.AspNetCore.Mvc;

namespace lab3.Models
{
    public class NxvProduct : Controller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }
}
