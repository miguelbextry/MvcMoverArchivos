using System.IO;


namespace MvcMoverArchivos.Helpers
{
    public static class HelperFiles
    {
        public static void MoverUbicacion1()
        {
            string origen = Path.Combine("wwwroot", "media", "ubicacion2", "pikachu.jpg");
            string destino = Path.Combine("wwwroot", "media", "ubicacion1", "pikachu.jpg");
            File.Move(origen, destino);
        }

        public static void MoverUbicacion2()
        {
            string origen = Path.Combine("wwwroot", "media", "ubicacion1", "pikachu.jpg");
            string destino = Path.Combine("wwwroot", "media", "ubicacion2", "pikachu.jpg");
            File.Move(origen, destino);
        }
        public static void CopiarUbicacion1()
        {
            string origen = Path.Combine("wwwroot", "media", "ubicacion1", "word.docx");
            string destino = Path.Combine("wwwroot", "media", "ubicacion2", "word.docx");
            File.Copy(origen, destino);
        }

        public static void CopiarUbicacion2()
        {
            string origen = Path.Combine("wwwroot", "media", "ubicacion2", "word.docx");
            string destino = Path.Combine("wwwroot", "media", "ubicacion1", "word.docx");
            File.Copy(origen, destino);
        }

    }
}
