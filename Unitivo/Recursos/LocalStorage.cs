using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitivo.Models;

namespace Unitivo.Sessions
{
    public static class LocalStorage
    {
        public static List<Producto>? productos { get; set; } 

        public static List<Talle>? talles { get; set; }

        public static List<Categorium>? categorias { get; set; }
    }
}
