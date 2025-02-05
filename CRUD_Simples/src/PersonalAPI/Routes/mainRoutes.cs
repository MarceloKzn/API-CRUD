using PersonModels;

namespace Routes
{
    public static class mainRoute // lembrar que todo método apartir daqui é estático
    {
        public static void PersonRoutes(this WebApplication app)
        {
            app.MapGet("/Person", () => new PersonModel(name:"Marcelo"));  
        }
        public static void ServiceRoute(WebApplication app)
        {
            app.MapGet("/Services", () => "Serviços em Desenvolvimento");
        }
    }

}