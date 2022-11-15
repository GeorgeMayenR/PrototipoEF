using ComprasControlador;
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
    public partial class Bitacora : Form
    {
        string emp = "tbl_bitacoradeeventos";
        //Estamos instanciando
        csContralador cn = new csContralador();
        public Bitacora()
        {
            InitializeComponent();
        }
        public void actualizardatagriew()
        {
            //le pasamos el parametro de la tabla a consultar
            DataTable dt = cn.llenarTbl(emp);
            dataGridView1.DataSource = dt;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "3001";
            TextBox[] Grupotextbox = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8};
            TextBox[] Idtextbox = { textBox1 };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "colchoneria");
        }
    }
}
