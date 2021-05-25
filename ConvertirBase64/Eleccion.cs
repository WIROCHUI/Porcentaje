using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertirBase64
{
    public partial class Eleccion : Form
    {
        public Eleccion()
        {
            InitializeComponent();
        }

        //DATABASE
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        //Herencia
        OpenFileDialog open = new OpenFileDialog();
        int int_Registros;
        string strResultado = String.Empty;
        decimal porcentajePeruLibre;
        decimal porcentajeFuerzaPopular;
        decimal porcentajeNulo;
        decimal porcentajeBlanco;
        decimal porcentajeInpugnados;

        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            txtPrimero.Text = "";
            txtSegundo.Text = "";
            txtBlanco.Text = "";
            txtInpugnado.Text = "";
            txtNulo.Text = "";
            txtPorcentajeBlanco.Text = "";
            txtPorcentajeDos.Text = "";
            txtPorcentajeInpugnado.Text = "";
            txtPorcentajeUno.Text = "";
            txtPorcentajeNulo.Text = "";
            txtTotales.Text = "";
            lblPorcentajeTotal.Text = "...";
            btnReporte.Enabled = true;
        }

        private void txtTotales_TextChanged(object sender, EventArgs e)
        {

        }

        private Boolean validarCampoVacio()
        {
            Boolean valor = true;

            if (txtPrimero.Text == null || txtPrimero.Text == "")
            {
                MessageBox.Show("hacen falta campos por llenar");
                valor = false;
            }
            if (txtSegundo.Text == null || txtSegundo.Text == "")
            {
                MessageBox.Show("hacen falta campos por llenar");
                valor = false;
            }
            if (txtNulo.Text == null || txtNulo.Text == "")
            {
                MessageBox.Show("hacen falta campos por llenar");
                valor = false;
            }
            if (txtBlanco.Text == null || txtBlanco.Text == "")
            {
                MessageBox.Show("hacen falta campos por llenar");
                valor = false;
            }
            if (txtInpugnado.Text == null || txtInpugnado.Text == "")
            {
                MessageBox.Show("hacen falta campos por llenar");
                valor = false;
            }
            return valor;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!validarCampoVacio())
            {
               // MessageBox.Show("Validacion boton");
                return;
            }
            

            decimal votoPeruLibre = decimal.Parse(txtPrimero.Text);
            decimal votoFuerzaPopular = decimal.Parse(txtSegundo.Text);
            decimal votoNulo = decimal.Parse(txtNulo.Text);
            decimal votoBlanco = decimal.Parse(txtBlanco.Text);
            decimal votoInpugnado = decimal.Parse(txtInpugnado.Text);
            decimal totalVotos = votoPeruLibre + votoFuerzaPopular + votoNulo + votoBlanco + votoInpugnado;
            txtTotales.Text = totalVotos.ToString();
                    
            porcentajePeruLibre = decimal.Round((votoPeruLibre / totalVotos) * 100, 2);
            porcentajeFuerzaPopular = decimal.Round((votoFuerzaPopular / totalVotos) * 100, 2);
            porcentajeNulo = decimal.Round((votoNulo / totalVotos) * 100, 2);
            porcentajeBlanco = decimal.Round((votoBlanco / totalVotos) * 100, 2);
            porcentajeInpugnados = decimal.Round((votoInpugnado / totalVotos) * 100, 2);

            decimal porTotal = porcentajePeruLibre + porcentajeFuerzaPopular + porcentajeNulo + porcentajeBlanco + porcentajeInpugnados;

            txtPorcentajeUno.Text = porcentajePeruLibre.ToString();
            txtPorcentajeDos.Text = porcentajeFuerzaPopular.ToString();
            txtPorcentajeNulo.Text = porcentajeNulo.ToString();
            txtPorcentajeBlanco.Text = porcentajeBlanco.ToString();
            txtPorcentajeInpugnado.Text = porcentajeInpugnados.ToString();

            lblPorcentajeTotal.Text = porTotal.ToString();
            btnReporte.Enabled = true;
        }

       

        private void iTalk_Button_12_Click(object sender, EventArgs e)
        {
            if (txtPorcentajeUno.Text == String.Empty || txtPorcentajeDos.Text == String.Empty)
            {
                MessageBox.Show("Debe generar el codigo o Falta nombre");
            }
            else
            {
               Insertar(porcentajePeruLibre, porcentajeFuerzaPopular, porcentajeNulo, porcentajeBlanco, porcentajeInpugnados);
                //txtResultado.Text = String.Empty;
            }

            ReporteGeneral rg = new ReporteGeneral();
            rg.Show();
        }

        private void txtPorcentajeNulo_TextChanged(object sender, EventArgs e)
        {

        }


        private String Insertar(decimal decPerLibre, decimal decFuePopular, decimal decBlanco, decimal decNulo, decimal decInpugnado)
        {
            SqlCommand cmd = new SqlCommand("SP_ACTUALIZAR_VOTOS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DC_PE_LIBRE", decPerLibre);
            cmd.Parameters.AddWithValue("@DC_FU_POPULAR", decFuePopular);
            cmd.Parameters.AddWithValue("@DC_NULO", decNulo);
            cmd.Parameters.AddWithValue("@DC_BLANCO", decBlanco);
            cmd.Parameters.AddWithValue("@DC_INPUGNADO", decInpugnado);
            conexion.Open();
            try
            {
                int_Registros = cmd.ExecuteNonQuery();
                if (int_Registros > 0)
                {
                    //strResultado = "Se guardo el codigo Base64";
                }
                else
                {
                    //strResultado = "No se guardo el codigo Base64";
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

        private void txtPrimero_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero.SoloNumeros(e);
        }

        private void txtSegundo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero.SoloNumeros(e);
        }

        private void txtNulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero.SoloNumeros(e);
        }

        private void txtBlanco_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero.SoloNumeros(e);
        }

        private void txtInpugnado_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero.SoloNumeros(e);
        }

        private void txtInpugnado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTest_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero.SoloNumeros(e);
        }
    }
}
