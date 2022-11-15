using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace Final
{
    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-QMJDLO6; database=Alumnos; integrated security=true");

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            conexion.Open();

            String Nom = Tbnom.Text;
            String Ape1 = Tbape1.Text;
            String Ape2 = Tbape2.Text;
            String id = TbID.Text;

            string cadena = "insert into Lista1 (Nombre, Apellido1, Apellido2, ID) values('" + Nom+ "', '" + Ape1 + "','" + Ape2 + "', '" + id + "')";
            SqlCommand cmd = new SqlCommand(cadena, conexion);
            cmd.ExecuteNonQuery();

            MessageBox.Show("los datos se guardaron correctamente");
            Tbnom.Text = "";
            Tbape1.Text = "";
            Tbape2.Text = "";
            TbID.Text = "";

            conexion.Close();

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            String Nom = Tbnom.Text;
            String Ape1 = Tbape1.Text;
            String Ape2 = Tbape2.Text;
            String id = TbID.Text;


            string cadena = "update Lista1 set Nombre = '" + Nom + "', Apellido1= '" + Ape1 + "', Apellido2='" + Ape2 + "' where ID= " + id;
            SqlCommand cmd = new SqlCommand(cadena, conexion);
            cmd.ExecuteNonQuery();
            MessageBox.Show("los datos se guardaron correctamente");
            Tbnom.Text = "";
            Tbape1.Text = "";
            Tbape2.Text = "";
            TbID.Text = "";
            conexion.Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string cod = TbID.Text;

            string cadena = "select Nombre, Apellido1, Apellido2 from Lista1 where ID=" + cod;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                MessageBox.Show ("El Alumno es: "+ registro["Nombre"].ToString() + " " + registro["Apellido1"].ToString() + " " + registro["Apellido2"].ToString());
                BtnBuscar.Enabled = true;
            }
            else
                MessageBox.Show("No existe el alumno");
            Tbnom.Text = "";
            Tbape1.Text = "";
            Tbape2.Text = "";
            TbID.Text = "";
            conexion.Close();

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string cod = TbID.Text;
            string cadena = "delete from Lista1 where ID=" + cod;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se elimino el alumno");
            }
            Tbnom.Text = "";
            Tbape1.Text = "";
            Tbape2.Text = "";
            TbID.Text = "";
        }
    } 
}
