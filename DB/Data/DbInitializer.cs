using DB.Models;

namespace DB.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DbFacturacionContext context)
        {
            if (context.Roles.Any()) return;

            var roles = new List<Rol>
            {
                new Rol
                {
                    Nombre = "SuperAdmin",
                    EsActivo = true,
                    FechaRegistro = DateTime.Now,
                    CreadoPor = "SuperAdmin"
                },
                 new Rol
                {
                    Nombre = "AdminPais",
                    EsActivo = true,
                    FechaRegistro = DateTime.Now,
                    CreadoPor = "SuperAdmin"
                },
                 new Rol
                {
                    Nombre = "AdminEmpresa",
                    EsActivo = true,
                    FechaRegistro = DateTime.Now,
                    CreadoPor = "SuperAdmin"
                },
                 new Rol
                {
                    Nombre = "AdminPuesto",
                    EsActivo = true,
                    FechaRegistro = DateTime.Now,
                    CreadoPor = "SuperAdmin"
                },
                 new Rol
                {
                    Nombre = "Cajero",
                    EsActivo = true,
                    FechaRegistro = DateTime.Now,
                    CreadoPor = "SuperAdmin"
                },

            };

            context.Roles.AddRange(roles);
            context.SaveChanges();
        }
    }
}
