using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.IO;
using System.Configuration;

namespace Catalogo_de_comercio
{
    public partial class AgregarArticulo : Form
    {
        private Articulos Articulo = null;
        private OpenFileDialog  archivo = null;
        public AgregarArticulo()
        {
            InitializeComponent();
        }

        public AgregarArticulo(Articulos Articulo)
        {
            InitializeComponent();
            this.Articulo = Articulo;
            Text = "Modificar Articulo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Articulos   nuevo = new Articulos();  
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (Articulo == null)
                {
                    Articulo = new Articulos();
                }
                Articulo.Nombre = txtbNombre.Text;
                Articulo.Codigo = txtbCodigo.Text;
                Articulo.Descripcion = txtbDescripcion.Text;
                Articulo.Precio = decimal.Parse(txtbPrecio.Text);
                Articulo.ImagenUrl = txtbImagen.Text;
                Articulo.Marca = (Marca)cboxMarca.SelectedItem;
                Articulo.Categoria = (Categoria)cboxCategoria.SelectedItem;

                if (Articulo.Id != 0)
                {
                    negocio.modificar(Articulo);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(Articulo);
                    MessageBox.Show("Agregado exitosamente");
                }

                if (archivo != null && !(txtbImagen.Text.ToLower().Contains("http"))) 
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.FileName);
                }
            


                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void AgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcanegocio = new MarcaNegocio();
            CategoriaNegocio categorianegocio = new CategoriaNegocio();

            try
            {
                cboxMarca.DataSource = marcanegocio.listar();
                cboxCategoria.ValueMember = "Id";
                cboxCategoria.DisplayMember = "Descripcion";
                cboxMarca.ValueMember = "Id";
                cboxMarca.DisplayMember = "Descripcion";
                cboxCategoria.DataSource = categorianegocio.listar();

                if (Articulo != null) 
                {
                    txtbCodigo.Text = Articulo.Codigo;
                    txtbNombre.Text = Articulo.Nombre;
                    txtbDescripcion.Text = Articulo.Descripcion;
                    txtbImagen.Text = Articulo.ImagenUrl;
                    txtbPrecio.Text = Articulo.Precio.ToString();
                    cboxMarca.SelectedValue = Articulo.Marca.Id;
                    cboxCategoria.SelectedValue = Articulo.Categoria.Id;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

       

        private void txtbImagen_TextChanged(object sender, EventArgs e)
        {

            cargarImagen(txtbImagen.Text);

         }
        public void cargarImagen(string imagen)
        {
            try
            {
                pboxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {

                pboxArticulo.Load("https://i0.wp.com/theperfectroundgolf.com/wp-content/uploads/2022/04/placeholder.png?fit=1200%2C800&ssl=1");
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
           OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg|png|*.png";
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txtbImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
               
            }
        }
    }
}
