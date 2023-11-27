using Ejemplo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Runtime.InteropServices;

namespace Ejemplo.Controllers
{
    public class FriendController : Controller
    {


        // POST /Friends/Create
        [HttpPost]
        public IActionResult Create(Friend friend)
        {
            // Validate and update the model
            return View();
        }

        // DELETE /Friends/Delete/665
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            // Delete the friend
            return View();
        }

        // GET /Controller/GetSomething
        [NonAction]
        public string GetSomething()
        {
            return string.Empty;
        }


        [ActionName("Delete")]
        public IActionResult Remove(int id)
        {
            return View(); //Se devuelve la vista Delete.cshtml
        }


        // Default route: {controller}/{action}/{id}

        // GET /product/edit/884
        public IActionResult Edit(int id)
        {
            // "id" contains 884
            return View();
        }

        public IActionResult View(string id, 
                                  [DefaultParameterValue(false)] bool fullDetail,
                                  [DefaultParameterValue(1)] int currentPage)



        {
            return Content("id=" + id +
            ", fullDetail=" + fullDetail + ", currentPage=" + currentPage);
        }


        public ActionResult Upload(IFormFile myFile)
        {
            string path = "C:/"; // Ruta donde queremos guardar el fichero
            return Content("Ok, file uploaded");
        }

        //public IActionResult Update(Friend friend)
        //{
        //    return Content(friend.Name + ", " +
        //    friend.Age + ", " + "Tlf: " + friend.Description);
        //}

        public IActionResult Update(Student student)
        {
            return Content(student.Name + ", " +
            student.Age + ", " +
            "Phone: " + student.Phone + ", " +
            "Street: " + student.Address.Street + ", " + "Zip code: " + student.Address.ZipCode);
        }

        public class TestController : Controller
        {
            public ActionResult Array(string[] text)
            {
                return Content(string.Join(", ", text));
            }
        }


        public ActionResult Update([Bind(Exclude"Username,Password")] User u)
        {
            return View();        
        }

        public IActionResult ChangePassword(User user)
        {
            // Validar y actualizar el modelo
            return View();
        }

        [HttpPost]
        public ActionResult Update(Friend friend)
        {
            if (!User.Identity.IsAuthenticated)
            {
                ModelState.AddModelError("", "Operation is not authorized");
            }

            if (!ModelState.IsValid)
            {
                return View("Edit", friend);
            }
            // Actualiza el modelo y devuelve
            // una vista al usuario
            return View();
        }

        public IActionResult Index()
        {
            ProductsCatalog catalog = new ProductsCatalog();
            List<Product> products = catalog.GetProducts();
            return View(products);
        }

        public ActionResult BestSellers(int year)
        {

            Session["Carrito"] as List<Product>;

            ProductsCatalog catalog = new ProductCatalog();
            List<Product> products = catalog.GetBestSellersByYear(year);
            return View(products);
        }

    }
}
