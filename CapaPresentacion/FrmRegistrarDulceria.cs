using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaDatos; 

namespace CapaPresentacion
{
    public partial class FrmRegistrarDulceria : Form
    {
        public int Idproducto = 0;
        public bool Insert = false;
        public bool Edit = false;
        int stockOriginal;

        public FrmRegistrarDulceria()
        {
            CustomUI.LoadDefaultStyle(this);
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                decimal precioCompra = Convert.ToDecimal(txtprecio.Text);
                decimal precioVenta = precioCompra * 1.10m;


                string textoCodigo = "DUL-" + (Insert ? txtnombre.Text.Replace(" ", "") : txtidproducto.Text);

                pictureBox1.Image = GeneradorCodigoBarras.Generar(textoCodigo);

                if (Insert)
                {
                    resp = CNDulceria.Guardar(
                        txtnombre.Text,
                        txttipo.Text,
                        precioVenta,
                        Convert.ToInt32(txtstock.Text),
                        textoCodigo
                    );

                    if (resp == "OK")
                    {
                        CNDulceria.RegistrarMovimiento(txtnombre.Text, "ENTRADA", Convert.ToInt32(txtstock.Text), Session.UsuarioActual, "Inventario Inicial");
                    }
                }
                else if (Edit)
                {
                    int stockNuevo = Convert.ToInt32(txtstock.Text);

                    resp = CNDulceria.Editar(
                        Convert.ToInt32(txtidproducto.Text),
                        txtnombre.Text,
                        txttipo.Text,
                        precioVenta,
                        stockNuevo,
                        textoCodigo
                    );

                    if (resp == "OK")
                    {
                        if (stockNuevo < stockOriginal)
                        {
                            int cantidadVendida = stockOriginal - stockNuevo;
                            CNDulceria.RegistrarMovimiento(txtnombre.Text, "SALIDA", cantidadVendida, "Cliente Público", "Venta en Mostrador");
                        }
                        else if (stockNuevo > stockOriginal)
                        {
                            int cantidadAgregada = stockNuevo - stockOriginal;
                            CNDulceria.RegistrarMovimiento(txtnombre.Text, "ENTRADA", cantidadAgregada, Session.UsuarioActual, "Ajuste Manual");
                        }
                    }
                }

                if (resp == "OK")
                {
                    MessageBox.Show("Registro guardado correctamente", "CineApp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new FrmInventarioDulceria().Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(resp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            new FrmInventarioDulceria().Show();
            this.Close();
        }

        private void FrmRegistrarDulceria_Load(object sender, EventArgs e)
        {
            if (Insert)
                btnguardar.Text = "Guardar";
            else if (Edit)
                btnguardar.Text = "Editar";

            if (Edit)
            {
                stockOriginal = Convert.ToInt32(txtstock.Text);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}