using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seguridad_rup.Vistas
{
	public partial class Frm_Login : Form
	{
		string modulo = "";
		string mensajeFallo = "";
		string mensajePermiso = "";
		public Frm_Login(string mod)
		{
			modulo = mod;
			InitializeComponent();
		}

		void ESP_Selecionado() {
			Lbl_Usuario.Text = "Usuario";
			Lbl_Clave.Text = "Contraseña";
			Btn_ingresar.Text = "Entrar";
			Btn_limpiar.Text = "Limpiar";
			Lnk_olvideClave.Text = "Olvidé mí contrseña...";
			mensajeFallo = "El usuario o contraseña no existe.";
			mensajePermiso = "No posee permisos sobre este Modulo.";
		}

		void ENG_Selecionado()
		{
			Lbl_Usuario.Text = "User";
			Lbl_Clave.Text = "Pass";
			Btn_ingresar.Text = "Accept";
			Btn_limpiar.Text = "Clean";
			Lnk_olvideClave.Text = "Maybe I Forgot my Pass...";
			mensajeFallo = "The User or pass doesn't exist";
			mensajePermiso = "You don't have permissions on this module.";
		}
		private void Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void Label1_Click(object sender, EventArgs e)
		{

		}

		private void ComboBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void Cmb_Lenguajes_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (Cmb_Lenguajes.Text.ToString())
			{
				case "ESP":
					ESP_Selecionado();
					break;
				case "ENG":
					ENG_Selecionado();
					break;
				default:
					break;
			}
			
		}

		private void Frm_Login_Load(object sender, EventArgs e)
		{
			ESP_Selecionado();
		}

		private void Btn_ingresar_Click(object sender, EventArgs e)
		{
			SQL_Login loginSQL = new SQL_Login();
			String succes = loginSQL.Ingresar(Txt_Usuarios.Text.ToString(), Txt_Clave.Text.ToString(), modulo);
			if (succes == "Exito")
			{
				this.Visible = false;
			}
			else if (succes == "Fallo")
			{
				MessageBox.Show(mensajePermiso);
			}
			else {
				MessageBox.Show(mensajeFallo);
			}
			
		}

		private void Txt_Clave_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
