using Ejemplo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejemplo.Controllers
{
	public class HomeController : Controller
	{
		bool usuarioAutenticado = true;
		public IActionResult Index()
		{
			// Obtener el valor de la variable de aplicación para la cadena de conexión
			string? conexion = HttpContext.Items["conexion"].ToString();

			// Utilizar la cadena de conexión para obtener los datos de la base de datos
			// ...

			// Mostrar la página de inicio de la aplicación
			return View(datos);
		}

		public IActionResult Login(string usuario, string password)
		{
			// Verificar la autenticación del usuario

			if (usuarioAutenticado)
			{

				HttpContext.Session.SetString("[CLAVE]", "[VALOR]");



				// Establecer la variable de sesión para el nombre de usuario
				HttpContext.Session.SetString("usuario", usuario);

				// Redireccionar al usuario a la página de inicio
				return RedirectToAction("Index", "Home");
			}
			else
			{
				// Mostrar un mensaje de error y volver a la página de inicio de sesión
				ViewBag.Error = "Usuario o contraseña inválidos";
				return View();
			}
		}

		public IActionResult Perfil()
		{
			// Obtener el valor de la variable de sesión para el nombre de usuario


				string? VALOR = HttpContext.Session.GetString("[CLAVE]");





			// Utilizar el nombre de usuario para obtener los datos del perfil del usuario
			// ...

			// Mostrar la página de perfil del usuario
			return View(perfilUsuario);
		}

	}
}


