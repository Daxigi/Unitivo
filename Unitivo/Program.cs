using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Unitivo.Formularios;
using Unitivo.Formularios.Vendedor;
using Unitivo.Modelos;
using Unitivo.Presentacion;
using Unitivo.Presentacion.Administrador;
using Unitivo.Properties;
using Unitivo.Recursos;

namespace Unitivo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
        string stringConection = Resources.DB_ConnectionString;
            DbContextOptionsBuilder<UnitivoContext> optionsBuilder = new();
            UnitivoContext unitivoContext = new(optionsBuilder.UseSqlServer(stringConection).Options);
            Contexto.dbContexto = unitivoContext;
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}