using PTMicroservicios.Models;

namespace PTMicroservicios.Data
{
    public static class PrepDb
    {
        public static void PreparaData(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (context != null)
                {
                    SeedData(context);
                }
                else
                {
                    Console.WriteLine("---> No se puedo obtener el contexto, PrepDB");
                }


            }
        }

        private static void SeedData(AppDbContext context)
        {
            if (!context.Personas.Any())
            {
                Console.WriteLine("---> llenando informacion.....");
                context.Personas.AddRange(
                    new Persona()
                    {
                        Nombre = "Carlos Perez",
                        Genero = "M",
                        Identificacion = 0,
                        Edad = 28,
                        Direccion = "Av Junin 3-56",
                        Telefono = "315-760 1234"
                    },
                    new Persona()
                    {
                        Nombre = "Marta Gonzalez",
                        Genero = "F",
                        Identificacion = 0,
                        Edad = 24,
                        Direccion = "Av El Dorado 67-25",
                        Telefono = "315-760 1277"
                    },
                    new Persona()
                    {
                        Nombre = "Arturo Vasquez",
                        Genero = "M",
                        Edad = 44,
                        Identificacion = 0,
                        Direccion = "Av Circunvalar 76-45",
                        Telefono = "315-760 0034"
                    });
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("--> ya tenemos informacion");
            }
        }
    }
}