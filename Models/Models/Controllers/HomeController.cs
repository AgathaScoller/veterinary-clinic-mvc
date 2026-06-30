using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        List<Customer> customers = new()
        {
            new Customer(1, "Arthur Ferreira", "857.032.950-41", "arthur@email.com", "Madruga"),
            new Customer(2, "Bill Gates", "039.618.250-09", "bill@microsoft.com", "Bug"),
            new Customer(3, "Ada Lovelace", "800.777.920-50", "ada@email.com", "Byron"),
            new Customer(4, "Linus Torvalds", "933.622.400-03", "linus@linux.org", "Penguin"),
            new Customer(5, "Grace Hopper", "911.702.988-00", "grace@email.com", "Loboc")
        };

        List<Supplier> suppliers = new()
        {
            new Supplier(1, "Pet Supplies Inc.", "14.182.102/0001-80", "contact@petsupplies.com"),
            new Supplier(2, "Happy Pets", "15.836.698/0001-57", "info@happypets.com"),
            new Supplier(3, "Animal Care Ltd.", "40.810.224/0001-83", "sales@animalcare.com"),
            new Supplier(4, "Vet Solutions", "87.945.350/0001-09", "support@vetsolutions.com"),
            new Supplier(5, "Forever Pets", "18.760.614/0001-37", "contact@foreverpets.com")
        };

        ViewBag.Customers = customers;
        ViewBag.Suppliers = suppliers;

        return View();
    }
}
