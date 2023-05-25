using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SubirImagenes
{
    public class Producto
    {
        string descripcion;
        string imagen;

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Imagen { get => imagen; set => imagen = value; }
    }
}