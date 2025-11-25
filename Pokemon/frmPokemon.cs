using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class frmPokemon : Form
    {
        private List<Pokemon> listaPokemon;
        public frmPokemon()
        {
            InitializeComponent();
        }

        private void frmPokemon_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            listaPokemon = negocio.listar();
            dgvPokemons.DataSource = listaPokemon;
            cargarImagen(listaPokemon[0].UrlImagen);
        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
                Pokemon pokemonSeleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
                cargarImagen(pokemonSeleccionado.UrlImagen) ;                    
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbPokemon.Load(imagen);
            }
            catch (Exception ex)
            {
                pbPokemon.Load("https://fissac.com/wp-content/uploads/2020/11/placeholder.png");
                MessageBox.Show("No se ha encontrando la imagen.", "Adveretencia");
            }
        }
    }
}
