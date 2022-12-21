using ConsoleApp1.Cafe;
using ConsoleApp1.Enums;
using ConsoleApp1.Extras;
using ConsoleApp1.Interfaces;
using ConsoleApp1.Propinas;
using ConsoleApp1.Propinas.tipoPropina;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2parcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bebida miCafe;


        public void validarPedido(EnumTipoCafe tipoCafe, EnumTipoExtra extra)
        {

            armarPedido(tipoCafe, extra);
            calcularPropina();
        }


        public void armarPedido(EnumTipoCafe tipoCafe, EnumTipoExtra extra)
        {


            switch (tipoCafe)
            {
                case EnumTipoCafe.Solo:
                    miCafe = new CafeSolo();
                    break;
                case EnumTipoCafe.Expresso:
                    miCafe = new CafeExpreso();
                    break;
                case EnumTipoCafe.Descafeinado:
                    miCafe = new CafeDescafeinado();
                    break;
                default:
                    break;

            }
            if (miCafe == null) { LbPedidos.Text = "Ningún café seleccionado"; lbPrecio.Text = "0"; return; }
            switch (extra)
            {
                case EnumTipoExtra.Leche:
                    miCafe = new Leche(miCafe);
                    break;
                case EnumTipoExtra.Canela:
                    miCafe = new Canela(miCafe);
                    break;
                case EnumTipoExtra.Crema:
                    miCafe = new Crema(miCafe);
                    break;
                default:
                    //No se agrega ningun extra;
                    break;
            }

            LbPedidos.Text = miCafe.getDescripcion();
            lbPrecio.Text = miCafe.getPrecio().ToString();
        }


        public void calcularPropina()
        {

            decimal monto = (decimal)miCafe.getPrecio() ;

            var date = DateTime.Now;
            var DateTime8 = date.Date.AddHours((date.Hour > 8) ? 24 + 8 : 8);
            var inicioDia = 7; var findia = 18;
            var tipoPropina = EnumTipoPropina.SinPropina;
            if (date.Hour >= inicioDia && date.Hour <= findia)
            {
                tipoPropina = EnumTipoPropina.Dia;

            }
            else
            {
                tipoPropina = EnumTipoPropina.Noche;
            }

            
            propinaContexto propinaCtxto = new propinaContexto();
            switch (tipoPropina)
            {
                case EnumTipoPropina.Dia:
                    propinaCtxto.setEstrategia(new Dia());
                    break;
                case EnumTipoPropina.Noche:
                    propinaCtxto.setEstrategia(new Noche());
                    break;
                case EnumTipoPropina.SinPropina:
                    propinaCtxto.setEstrategia(new SinPropina());
                    break;

            }
            decimal montoPropina = propinaCtxto.calcularPropina(monto);



            lbPropina.Text = montoPropina + "";



        }



        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PanelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            validarPedido(EnumTipoCafe.Expresso, EnumTipoExtra.SinExtra);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            validarPedido(EnumTipoCafe.NoCafe, EnumTipoExtra.Leche);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            validarPedido(EnumTipoCafe.NoCafe, EnumTipoExtra.Crema);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            validarPedido(EnumTipoCafe.NoCafe, EnumTipoExtra.Canela);
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            validarPedido(EnumTipoCafe.Solo, EnumTipoExtra.SinExtra);
        }

        private void btnDecafeinado_Click(object sender, EventArgs e)
        {
            validarPedido(EnumTipoCafe.Descafeinado, EnumTipoExtra.SinExtra);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {



        }
    }
}
