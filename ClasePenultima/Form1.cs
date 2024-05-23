using ClasePenultima.Data.DataAcces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClasePenultima
{

    public partial class Form1 : Form
    {

        //Para que se vea bonito na mas

        private string[] razasDragonBall = {
            "Android",
            "Bio-Android",
            "Humana",
            "Humano",
            "Majin",
            "Namekuseijin",
            "Saiyajin",
            "Saiyajin/Humano",
            "Saiyajin/Saiyajin"
        };
        private PersonajeDb personaje;

        //Creo el bojeto cuando arranca el forms

        public Form1()
        {
            InitializeComponent();
            personaje = new PersonajeDb();
        }

        //Reviso que se haya conectado o no

        private void buttonNueva_Click(object sender, EventArgs e)
        {
            if(personaje.probarConexion())
            {
                MessageBox.Show("Si se pudo 🧐🧐");
            }
            else
            {
                MessageBox.Show("Nel Pastel 🦁🦁");
            }
        }

        //Cargo la base de datos

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            dataGridViewPersonajes.DataSource=personaje.LeerPersonajes();
        }

        //Inserto personajes

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string raza = textBoxRaza.Text;
            string descipcion = textBoxDPJ.Text;
            DateTime fechacrea = DateTime.Now;
            int nivelPoder = (int)numericUpDownNivelDePoder.Value;
            int respuesta = personaje.CrearPersonaje(nombre, raza, nivelPoder,descipcion);
            if(respuesta > 0)
            {
                MessageBox.Show("Se creó correctamente");
                dataGridViewPersonajes.DataSource = personaje.LeerPersonajes();
                textBoxNombre.Clear();
                textBoxRaza.Clear();
                textBoxDPJ.Clear();
                numericUpDownNivelDePoder.ResetText();
            }
            else
            {
                MessageBox.Show("Hubo un error al crear persona");
            }
        }

        //Para que se vea bonito na mas

        private void Form1_Load(object sender, EventArgs e)
        {
            //Le meto datos a la combo box
            comboBoxRazas.Items.AddRange(razasDragonBall);
        }

        //Elimino algun personaje por medio de su id

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxID.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor en el campo de ID.");
                textBoxID.Focus(); // Devolver el foco al TextBox
            }
            else
            {
                int id = int.Parse(textBoxID.Text);
                personaje.eliminar(id);
                MessageBox.Show("Se elimino el personaje correctamente");
                dataGridViewPersonajes.DataSource = personaje.LeerPersonajes();
            }
        }

        //Busca por historia y por id

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxID.Text))
            { 
                int id = int.Parse(textBoxID.Text);
                dataGridViewPersonajes.DataSource = personaje.Buscar(id);
                textBoxID.Clear();
            }
            else if (!string.IsNullOrWhiteSpace(textBoxDPJ.Text))
            {
                string historia= textBoxDPJ.Text;
                dataGridViewPersonajes.DataSource = personaje.Buscar(historia);
                textBoxDPJ.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un valor en el campo de ID o en el campo de Descripción.");
                textBoxID.Focus(); // Devolver el foco al TextBox
            }
        }

        //Busca por fecha

        private void buttonBuscarF_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = dateTimePickerEnetrada.Value;
            DateTime fecha2 = dateTimePickerSalida.Value;
            dataGridViewPersonajes.DataSource = personaje.Buscarfecha(fecha1,fecha2);
        }

        //Le da un proposito de vida al comboBox

        private void comboBoxRazas_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxRaza.Text = comboBoxRazas.SelectedItem.ToString();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string raza = textBoxRaza.Text;
            string descipcion = textBoxDPJ.Text;
            int nivelPoder = (int)numericUpDownNivelDePoder.Value;
            if (!string.IsNullOrWhiteSpace(textBoxID.Text))
            {
                int id = int.Parse(textBoxID.Text);
                MessageBox.Show("Actualizo Correctamente");
                personaje.ActulizarPJ(id, nombre, raza, nivelPoder, descipcion);
                dataGridViewPersonajes.DataSource = personaje.LeerPersonajes();
                textBoxID.Clear();
                textBoxNombre.Clear();
                textBoxRaza.Clear();
                textBoxDPJ.Clear();
                numericUpDownNivelDePoder.ResetText();
            }
            else
            {
                MessageBox.Show("Ingrese la ID del personaje");
                textBoxID.Focus(); // Devolver el foco al TextBox
            }
        }
    }
}
