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
        //Metodo para cerrar la aplicacion si se cierra el buscador. (Alvaro)
      /*  protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Application.Exit();

        }*/

        private void buscarPokemonPorNombre(object sender, EventArgs e)
        {
            /* Este metodo lee el texto que se escribe en el TextBox y al pulsa el boton devuelve la info recogida del mismo en la pantalla de la pokedex.(Alvaro)
             * Si el nombre se escribe mal e muestra un mensaje que informa del error. Si la busqueda es correcta la ventana se cierra.
             */
            String nombrePokemon = textBox1.Text;
            pokemonPorNombre = miConexion.getPokemonPorNombre(nombrePokemon);
            if (pokemonPorNombre.Rows.Count == 0)
            {
                label1.Text = "Error, escribe el nombre correctamente.";
            }
            else
            {
                VentanaPrincipal.idActual = int.Parse(pokemonPorNombre.Rows[0]["id"].ToString());
                this.mainForm.enseñaPokemon(VentanaPrincipal.idActual);
                this.Hide();
            }

        }
    }
}
