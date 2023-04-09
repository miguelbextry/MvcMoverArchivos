using Microsoft.AspNetCore.Mvc;
using MvcMoverArchivos.Helpers;

namespace MvcMoverArchivos.Controllers
{
    public class ImagenesController : Controller
    {
        public IActionResult Imagenes()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Imagenes(IFormFile archivo)
        {
            string filename = archivo.FileName;
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "media", "ubicacion1", filename);
            using (Stream stream = new FileStream(path, FileMode.Create))
            {
                await archivo.CopyToAsync(stream);
            }
            ViewData["GUARDADO"] = "Archivo guardado correctamente";
            return View();
        }

        public IActionResult MoverUbicacion1()
        {
            HelperFiles.MoverUbicacion1();
            return RedirectToAction("Imagenes");
        }
        public IActionResult MoverUbicacion2()
        {
            HelperFiles.MoverUbicacion2();
            return RedirectToAction("Imagenes");
        }

        public IActionResult CopiarUbicacion1()
        {
            HelperFiles.CopiarUbicacion1();
            return RedirectToAction("Imagenes");
        }
        public IActionResult CopiarUbicacion2()
        {
            HelperFiles.CopiarUbicacion2();
            return RedirectToAction("Imagenes");
        }

    }
}

