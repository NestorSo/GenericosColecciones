using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PjControlRegistroLibros
{
    public partial class frmLibros : Form
    {

        static int contador;
        public frmLibros()
        {
            InitializeComponent();
        }

        private void frmLibros_Load(object sender, EventArgs e)
        {
            lblNumero.Text = GenerarNumero();

        }
        Func<string> GenerarNumero = () =>
         {
             contador++;
             return contador.ToString("0000");
         };

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Valida() == "")
            {
                //Capturamos los datos 
                double costo = getCosto();
                string categoria = getCategoria();
                double descuento = AsignaDescuento(categoria, costo);
                double precioVenta = CalcularPrecioVenta(costo, descuento);


                //imprimiendo 
                ImprtimirRegistro(descuento, precioVenta);
            }
            else
                MessageBox.Show("El error se encuentra en : " + Valida());
        }

        private void ImprtimirRegistro(double descuento, double precioVenta)
        {
            ListViewItem fila = new ListViewItem(getNumero().ToString());
            fila.SubItems.Add(getTitulo());
            fila.SubItems.Add(getCategoria());
            fila.SubItems.Add(getCosto().ToString("0.00"));
            fila.SubItems.Add(descuento.ToString("0.00"));
            fila.SubItems.Add(precioVenta.ToString("0.00"));
            lvLibros.Items.Add(fila);
        }

        Func<double, double, double> CalcularPrecioVenta =(costo,descuento) =>  costo-descuento    ;
        Func<string, double, double> AsignaDescuento = (categoria, costo) =>
          {
              double descuento = 0;
              switch (categoria)
              {
                  case "Gestion": descuento = 10.0 / 100 * costo;break;
                  case "Ingenieria": descuento = 12.0 / 100 * costo;break;
                  case "Programacion": descuento = 20.0 / 100 * costo;break;
                  case "Base De Datos": descuento = 15.0 / 100 * costo;break;
              }
              return descuento;
          }; 
        // Metodos que capturan los datos 
        private int getNumero()
        {
            return int.Parse(lblNumero.Text);   
        }
        private string getTitulo()
        {
            return txtTitulo.Text;  
        }
        private string getCategoria()
        {
            return cboCategoria.Text;   
        }

        private double getCosto()
        {
            return double.Parse(txtCosto.Text); 
        }

        private string Valida()
        {
            if (txtTitulo.Text.Trim().Length == 0)
            {
                txtTitulo.Focus();
                return "titulo del libro";
            }
            else if (cboCategoria.SelectedIndex == -1)
            {
                cboCategoria.Focus();
                return "categoria del libro";
            }
            else if(txtCosto.Text.Trim().Length == 0)
            {
                txtCosto.Focus();
                return "costo del libro ";
            }
            return "";
        }
    }
}
