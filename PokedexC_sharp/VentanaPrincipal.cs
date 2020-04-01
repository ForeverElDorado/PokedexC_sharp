﻿using System;
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

        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
        int idActual = 1; //el pokemon que estamos viendo

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
            enseñaPokemon();
        }

        private void Derecha_Click(object sender, EventArgs e)
        {
            idActual++;
            if (idActual >= 151)
            {
                idActual = 151;
            }
            misPokemons = miConexion.getPokemonPorId(idActual);
            enseñaPokemon();
          
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
            VentanaSeleccionPokemon eligePokemon = new VentanaSeleccionPokemon();
            eligePokemon.ShowDialog();

            //MessageBox.Show(eligePokemon.idSeleccionado.ToString());
            idActual = eligePokemon.idSeleccionado;
            misPokemons = miConexion.getPokemonPorId(idActual);
            enseñaPokemon();
        }
        //Metodo que muestra toda la informacion de los pokemons segun el Id del contador.
        public void enseñaPokemon()
        {
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            AreaPokemon.Text = misPokemons.Rows[0]["habitat"].ToString();
            Tipo1Pokemon.Text = misPokemons.Rows[0]["tipo1"].ToString();
            Tipo2Pokemon.Text = misPokemons.Rows[0]["tipo2"].ToString();
            IdPokemon.Text = misPokemons.Rows[0]["id"].ToString();
            Ataque1Pokemon.Text = misPokemons.Rows[0]["movimiento1"].ToString();
            Ataque2Pokemon.Text = misPokemons.Rows[0]["movimiento2"].ToString();
            Ataque3Pokemon.Text = misPokemons.Rows[0]["movimiento3"].ToString();
            Ataque4Pokemon.Text = misPokemons.Rows[0]["movimiento4"].ToString();
            EspeciePokemon.Text = misPokemons.Rows[0]["especie"].ToString();
            DescripcionPokemon.Text = misPokemons.Rows[0]["descripcion"].ToString();
            imagenPokemon.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }
    }
}
