using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using seguridad_rup.Vistas;

namespace Prueba_Seguridad
{
	public partial class Form1 : Form
	{
	
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Frm_Login login = new Frm_Login("1");
			login.Show();
		}
	}
}
