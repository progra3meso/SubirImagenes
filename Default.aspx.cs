using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SubirImagenes
{
    public partial class _Default : Page
    {
        private void GuardarJson(List<Producto> productos)
        {
            string json = JsonConvert.SerializeObject(productos);
            string archivo = Server.MapPath("Productos.json");
            System.IO.File.WriteAllText(archivo, json);
        }

        private List<Producto> LeerJson()
        {
            List<Producto> productos = new List<Producto>();
            string archivo = Server.MapPath("Productos.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            productos = JsonConvert.DeserializeObject<List<Producto>>(json);

            return productos;

        }   

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubir_Click(object sender, EventArgs e)
        {
            List<Producto> productos = new List<Producto>();
            productos = LeerJson();

            Producto producto = new Producto();            
            producto.Descripcion = TextBoxDescripcion.Text;
            string archivo = "~/imagenes/" + FileUploadImagen.FileName;
            producto.Imagen = archivo;

            string archivoOrigen = Path.GetFileName(FileUploadImagen.FileName);

            try
            {
                FileUploadImagen.SaveAs(Server.MapPath("~/imagenes/") + archivoOrigen);
                LabelEstado.Text = "Exitosamente Subido";
            }
            catch (Exception ex)
            {
                LabelEstado.Text = "No se pudo subir, se generó el siguiente error:  " + ex.Message;
            }
                       
            productos.Add(producto);
           

            GuardarJson(productos);

        }

        protected void ButtonMostrar_Click(object sender, EventArgs e)
        {
            List<Producto> productos = new List<Producto>();
            productos = LeerJson();

            GridViewProductos.DataSource = productos;
            GridViewProductos.DataBind();

        }
    }
}