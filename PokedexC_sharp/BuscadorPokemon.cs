using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokedexC_sharp
{
    public partial class BuscadorPokemon : Form
    {
        Conexion miConexion = new Conexion();
        DataTable pokemonPorNombre = new DataTable();
        DataTable pokemonPorId= new DataTable();
        VentanaPrincipal VP = new VentanaPrincipal();
        private VentanaPrincipal mainForm = null;
        public BuscadorPokemon(Form callingForm)
        {
            mainForm = callingForm as VentanaPrincipal;
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Application.Exit();

        }

        private void buscarPokemonPorNombre(object sender, EventArgs e)
        {
            String nombrePokemon = textBox1.Text;
            pokemonPorNombre = miConexion.getPokemonPorNombre(nombrePokemon);
            if (pokemonPorNombre.Rows.Count == 0)
            {
                label1.Text = "El Pokemon escrito no existe, por favor intentalo de nuevo";
            }
            else
            {
                VentanaPrincipal.idActual = int.Parse(pokemonPorNombre.Rows[0]["id"].ToString());
                this.mainForm.enseñaPokemon(VentanaPrincipal.idActual);
                this.Hide();
            }

        }
        /*
        private void buscarPokemonPorId(object sender, EventArgs e)
        {
            int idPokemon = textBox2.Text;
            pokemonPorId = miConexion.getPokemonPorId(idPokemon);
            if (pokemonPorNombre.Rows.Count == 0)
            {
                label1.Text = "El Pokemon escrito no existe, por favor intentalo de nuevo";
            }
            else
            {
                VentanaPrincipal.idActual = int.Parse(pokemonPorNombre.Rows[0]["id"].ToString());
                this.mainForm.enseñaPokemon(VentanaPrincipal.idActual);
                this.Hide();
            }

        }*/
    }
}
