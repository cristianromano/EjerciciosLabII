using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace Hospital
{
    public partial class Form1 : Form
    {
               
        private Medico miMedico;

        public Medico MiMedico
        {
            get { return miMedico; }
            set { miMedico = value; }
        }

        public Form1()
        {
            InitializeComponent();
        

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            int dni;
            if (int.TryParse(this.txtDni.Text, out dni) && this.cmbEspecialidad.SelectedIndex != -1)
                miMedico = new Medico(this.txtNombre.Text,
                    this.txtApellido.Text, dni, 
                    this.cmbEspecialidad.SelectedItem.ToString() );

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtNombre.Text = "Jorge";
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }
    }
}
