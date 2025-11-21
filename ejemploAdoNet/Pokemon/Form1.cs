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
            pbPokemon.Load(listaPokemon[0].UrlImagen);
        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon pokemonSeleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
            pbPokemon.Load(pokemonSeleccionado.UrlImagen);
        }
    }
}
