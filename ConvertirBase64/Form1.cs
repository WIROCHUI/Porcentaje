using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertirBase64
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //DATABASE
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        //Herencia
        OpenFileDialog open = new OpenFileDialog();
        string strOperacion = String.Empty;
        string strResultado = String.Empty;
        int int_Registros;
        

        private void bt_seleccionar_Click(object sender, EventArgs e)
        {
            //OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();

            txt_ruta.Text = open.FileName;
        }

        private void archiboB_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            string ruta = txt_ruta.Text;
            try { 
            byte[] archivoBytes = System.IO.File.ReadAllBytes(ruta);
            string archivoBase64 = Convert.ToBase64String(archivoBytes);
            txtResultado.Text = archivoBase64;
            this.timer1.Start();                
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Byarchivo_Click(object sender, EventArgs e)
        {
            string archivoBase64 = txtResultado.Text;
            try { 
            byte[] archivoBytes = Convert.FromBase64String(archivoBase64);
            System.IO.File.WriteAllBytes(txt_ruta.Text, archivoBytes);
            MessageBox.Show("Archivo creado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(80);
            if(progressBar1.Value == progressBar1.Maximum)
            {
                this.timer1.Stop();          
            }
        }

        private void btn_AbrirNuevoArchivo_Click(object sender, EventArgs e)
        {
            //OpenFileDialog heredado
            open.ShowDialog();
            txt_ruta.Text = open.FileName;
            progressBar1.Visible = false;
        }

        private void btnDecoDesdeTxt_Click(object sender, EventArgs e)
        {
            if (txtbusqueda.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar información");
            }
            else
            {
                decodificatabla();
            }
        }

        //private void btnGuardarB_Click(object sender, EventArgs e)
        //{
        //    if (txtResultado.Text == String.Empty && txtNombre.Text == String.Empty)
        //    {
        //        MessageBox.Show("Debe generar el codigo o Falta nombre");
        //    }
        //    else
        //    {
        //            //MessageBox.Show(Insertar( txtResultado.Text));
        //            //txtResultado.Text = String.Empty;

        //    }
        //}
        String Insertar(string strDescripcion, string strNombreArchivo)
        {
            //SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlCommand cmd = new SqlCommand("sp_guardarcodigo", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", strNombreArchivo);
            cmd.Parameters.AddWithValue("@Pdescripcion", strDescripcion);
            conexion.Open();
            try
            {
                int_Registros = cmd.ExecuteNonQuery();
                if (int_Registros > 0)
                {
                    strResultado = "Se guardo el codigo Base64";
                }
                else
                {
                    strResultado = "No se guardo el codigo Base64";
                }

            }
            catch (Exception ex)
            {
                strResultado = "Error en insertar Base64";
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
                conexion.Dispose();

            }
            return strResultado;
        }

        public void decodificatabla()
        {
            string buscartb = "select * from tb_archivo where id_archivo='" + txtbusqueda.Text + "'";
            SqlCommand cmd = new SqlCommand(buscartb, conexion);
            conexion.Open();
            SqlDataReader leer = cmd.ExecuteReader();
            try
            {
                if (leer.Read() == true)
                {
                    string archivoBase64 = leer["nombre_archivo"].ToString();
                    byte[] archivoBytes = Convert.FromBase64String(archivoBase64);
                    System.IO.File.WriteAllBytes(txt_ruta.Text, archivoBytes);
                    MessageBox.Show("Archivo creado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Debe agregar direccion");
            }
            finally
            {
                conexion.Close();
            }

        }

        private void txtbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void btnGuardaCodigo_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == String.Empty || txtNombre.Text == String.Empty)
            {
                MessageBox.Show("Debe generar el codigo o Falta nombre");
            }
            else
            {
                MessageBox.Show(Insertar(txtNombre.Text, txtResultado.Text));
                txtResultado.Text = String.Empty;
                txtNombre.Text = String.Empty;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
