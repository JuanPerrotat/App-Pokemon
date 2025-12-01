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
using Negocio;

namespace winform_app
{
    public partial class frmAltaPokemon : Form
    {
        public frmAltaPokemon()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "¿Estás seguro de que querés cancelar?",
            "Confirmar cancelación",
             MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Acción de cancelar: cerrar formulario o volver atrás
                this.Close();  // o cerrar un panel, limpiar campos, etc.
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Pokemon nuevoPokemon = new Pokemon();
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                nuevoPokemon.Numero = int.Parse(txtbNumero.Text);
                nuevoPokemon.Nombre = txtbNombrePokemon.Text;
                nuevoPokemon.Descripcion = txtbDescripcionPokemon.Text;
                nuevoPokemon.UrlImagen = txtImagen.Text;
                nuevoPokemon.Tipo = (Elemento)cboTipo.SelectedItem;
                nuevoPokemon.Debilidad = (Elemento)cboDebilidad.SelectedItem;


                negocio.agregar(nuevoPokemon);
                MessageBox.Show("Agregado exitosamente", "Advertencia");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaPokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();
            try
            {
                cboTipo.DataSource = elementoNegocio.listar();
                cboDebilidad.DataSource = elementoNegocio.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagen.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxPokemon.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxPokemon.Load("https://fissac.com/wp-content/uploads/2020/11/placeholder.png");
            }
        }
    }
}
