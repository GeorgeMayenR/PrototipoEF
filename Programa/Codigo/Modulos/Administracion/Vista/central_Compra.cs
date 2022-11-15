using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComprasVista
{
    public partial class central_Compra : Form
    {
       Seguridad_Controlador.Controlador cnseg = new Seguridad_Controlador.Controlador();
        public central_Compra()
        {
            InitializeComponent();
            customizeDesing();
            /*
            Button [] apps = { btnCliente, btnProveedores, btnPedidos,btnVentas, btnFactura, btnComisiones, btnCompraOrden, btnCompra,
                btnListado, btnMovientosClientes, btnMoviemientosProveedor, btnCotizaciones,btnClientesCaja, btnProveedorCaja
            };
            cnseg.deshabilitarApps(apps);

            cnseg.getAccesoApp(3001, apps[0]);
            cnseg.getAccesoApp(3002, apps[1]);
            cnseg.getAccesoApp(3111, apps[2]);
            cnseg.getAccesoApp(3108, apps[3]);
            cnseg.getAccesoApp(3107, apps[4]);
            cnseg.getAccesoApp(3106, apps[5]);
            cnseg.getAccesoApp(3109, apps[6]);
            cnseg.getAccesoApp(3110, apps[7]);
            cnseg.getAccesoApp(3102, apps[8]);
            cnseg.getAccesoApp(3112, apps[9]);
            cnseg.getAccesoApp(3113, apps[10]);
            cnseg.getAccesoApp(3103, apps[11]);
            cnseg.getAccesoApp(3104, apps[12]);*/

        }
        private void customizeDesing()
        {
            //Metodo para cubrir los paneles
            panelCompras.Visible = false;
            panelClientes.Visible = false;
            panel1.Visible = false;
           
        }

        private void hideSubMenu()
        {
            if (panelCompras.Visible == true)
                panelCompras.Visible = false;
            if (panelClientes.Visible == true)
                panelClientes.Visible = false;
            if (panel1.Visible == true)
                panel1.Visible = false;
            

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = true;
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            
            showSubMenu(panelCompras);

        }

       
        private void btnClient_Click(object sender, EventArgs e)
        {
            showSubMenu(panelClientes);
        }


        private void btnComprobantesClientes_Click(object sender, EventArgs e)
        {
            Bitacora bt = new Bitacora();
            bt.Show();
            
        }

   
   

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            showSubMenu(panel1);
        }

     


        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Departamento D = new Departamento();
            D.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Puesto P = new Puesto();
            P.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Departamento D = new Departamento();
            D.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Puesto P = new Puesto();
            P.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Ayuda Ay = new Ayuda();
            Ay.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ReporteBitacora Rb = new ReporteBitacora();
            Rb.Show();
        }
    }
}
