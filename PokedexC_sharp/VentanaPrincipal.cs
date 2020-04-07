using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokedexC_sharp
{
    public partial class VentanaPrincipal : Form
    {
        //Writtten and Directed By Alvaro garcia.
        //Tarda uno segundos al iniciarla por primera vez.
        //El boton de la pokedex abierta es la Tabla de los pokemons.

        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
        public static int idActual = 1; //el pokemon que estamos viendo

        public VentanaPrincipal()
        {
            InitializeComponent();
         
        }

        private Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }

        private void Izquierda_Click(object sender, EventArgs e)
        {
            idActual--;
            if(idActual <= 0)
            {
                idActual = 1;
            }
            misPokemons = miConexion.getPokemonPorId(idActual);
            enseñaPokemon(idActual);
        }

        private void Derecha_Click(object sender, EventArgs e)
        {
            idActual++;
            if (idActual >= 151)
            {
                idActual = 151;
            }
            misPokemons = miConexion.getPokemonPorId(idActual);
            enseñaPokemon(idActual);
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          //  nombrePokemon.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            //imagenPokemon.Image = convierteBlobAImagen((byte[])dataGridView1.Rows[e.RowIndex].Cells["imagen"].Value);
            
        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           // String nombre = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
           // String id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();

           // MessageBox.Show(miConexion.actualizaPokemon(id, nombre) );

        }

        private void botonTablaPokemon(object sender, EventArgs e)
        {
            //Este boton muestra el DATA GRID VIEW que recoge la info de todos los pokemons de la base de datos.
            VentanaSeleccionPokemon eligePokemon = new VentanaSeleccionPokemon();
            eligePokemon.ShowDialog();

            //MessageBox.Show(eligePokemon.idSeleccionado.ToString());
            idActual = eligePokemon.idSeleccionado;
            misPokemons = miConexion.getPokemonPorId(idActual);
            enseñaPokemon(idActual);
        }
        //Metodo que muestra toda la informacion de los pokemons segun el Id del contador.
        public void enseñaPokemon(int id)
        {
            /* Este metodo reduce la cantidad de codigo de los botones permitiendo agrupar todo en el mismo.
             * Este metodo lee el Id Actual y muestra la info del mismo pokemon con esa id.(Alvaro)
             */
            misPokemons = miConexion.getPokemonPorId(id);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            AreaPokemon.Text = "Area: " + misPokemons.Rows[0]["habitat"].ToString();
            Tipo1Pokemon.Text = "Tipo 1: " + misPokemons.Rows[0]["tipo1"].ToString();
            Tipo2Pokemon.Text = "Tipo 2: " + misPokemons.Rows[0]["tipo2"].ToString();
            IdPokemon.Text = "Nº: " + misPokemons.Rows[0]["id"].ToString() + "º";
            Ataque1Pokemon.Text = "1.- " + misPokemons.Rows[0]["movimiento1"].ToString();
            Ataque2Pokemon.Text = "2.- " + misPokemons.Rows[0]["movimiento2"].ToString();
            Ataque3Pokemon.Text = "3.- " + misPokemons.Rows[0]["movimiento3"].ToString();
            Ataque4Pokemon.Text = "4.- " + misPokemons.Rows[0]["movimiento4"].ToString();
            EspeciePokemon.Text = "Especie: " + misPokemons.Rows[0]["especie"].ToString();
            DescripcionPokemon.Text = misPokemons.Rows[0]["descripcion"].ToString();
            imagenPokemon.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }

        private void buscador(object sender, EventArgs e)
        {
            //Abre la ventana del BuscadorPokemon(Alvaro)
            BuscadorPokemon ventana = new BuscadorPokemon(this);
            ventana.Show();
        }
    }
}
