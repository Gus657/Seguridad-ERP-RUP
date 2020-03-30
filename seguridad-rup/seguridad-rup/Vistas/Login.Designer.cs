namespace seguridad_rup.Vistas
{
	partial class Frm_Login
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Pnl_TituloLogin = new System.Windows.Forms.Panel();
			this.Lbl_TituloLogin = new System.Windows.Forms.Label();
			this.Lbl_Usuario = new System.Windows.Forms.Label();
			this.Lbl_Clave = new System.Windows.Forms.Label();
			this.Btn_ingresar = new System.Windows.Forms.Button();
			this.Btn_limpiar = new System.Windows.Forms.Button();
			this.Txt_Usuarios = new System.Windows.Forms.TextBox();
			this.Txt_Clave = new System.Windows.Forms.TextBox();
			this.Cmb_Lenguajes = new System.Windows.Forms.ComboBox();
			this.Lnk_olvideClave = new System.Windows.Forms.LinkLabel();
			this.Pnl_TituloLogin.SuspendLayout();
			this.SuspendLayout();
			// 
			// Pnl_TituloLogin
			// 
			this.Pnl_TituloLogin.BackColor = System.Drawing.Color.Turquoise;
			this.Pnl_TituloLogin.Controls.Add(this.Cmb_Lenguajes);
			this.Pnl_TituloLogin.Controls.Add(this.Lbl_TituloLogin);
			this.Pnl_TituloLogin.Location = new System.Drawing.Point(-1, -1);
			this.Pnl_TituloLogin.Name = "Pnl_TituloLogin";
			this.Pnl_TituloLogin.Size = new System.Drawing.Size(414, 89);
			this.Pnl_TituloLogin.TabIndex = 0;
			this.Pnl_TituloLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
			// 
			// Lbl_TituloLogin
			// 
			this.Lbl_TituloLogin.AutoSize = true;
			this.Lbl_TituloLogin.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lbl_TituloLogin.Location = new System.Drawing.Point(175, 29);
			this.Lbl_TituloLogin.Name = "Lbl_TituloLogin";
			this.Lbl_TituloLogin.Size = new System.Drawing.Size(69, 33);
			this.Lbl_TituloLogin.TabIndex = 0;
			this.Lbl_TituloLogin.Text = "FRM";
			this.Lbl_TituloLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Lbl_Usuario
			// 
			this.Lbl_Usuario.AutoSize = true;
			this.Lbl_Usuario.Location = new System.Drawing.Point(23, 107);
			this.Lbl_Usuario.Name = "Lbl_Usuario";
			this.Lbl_Usuario.Size = new System.Drawing.Size(66, 21);
			this.Lbl_Usuario.TabIndex = 1;
			this.Lbl_Usuario.Text = "Usuario";
			this.Lbl_Usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Lbl_Usuario.Click += new System.EventHandler(this.Label1_Click);
			// 
			// Lbl_Clave
			// 
			this.Lbl_Clave.AutoSize = true;
			this.Lbl_Clave.Location = new System.Drawing.Point(21, 159);
			this.Lbl_Clave.Name = "Lbl_Clave";
			this.Lbl_Clave.Size = new System.Drawing.Size(103, 21);
			this.Lbl_Clave.TabIndex = 2;
			this.Lbl_Clave.Text = "Contraseña";
			this.Lbl_Clave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Btn_ingresar
			// 
			this.Btn_ingresar.Location = new System.Drawing.Point(65, 207);
			this.Btn_ingresar.Name = "Btn_ingresar";
			this.Btn_ingresar.Size = new System.Drawing.Size(107, 37);
			this.Btn_ingresar.TabIndex = 3;
			this.Btn_ingresar.Text = "button1";
			this.Btn_ingresar.UseVisualStyleBackColor = true;
			this.Btn_ingresar.Click += new System.EventHandler(this.Btn_ingresar_Click);
			// 
			// Btn_limpiar
			// 
			this.Btn_limpiar.Location = new System.Drawing.Point(260, 207);
			this.Btn_limpiar.Name = "Btn_limpiar";
			this.Btn_limpiar.Size = new System.Drawing.Size(107, 37);
			this.Btn_limpiar.TabIndex = 4;
			this.Btn_limpiar.Text = "button2";
			this.Btn_limpiar.UseVisualStyleBackColor = true;
			// 
			// Txt_Usuarios
			// 
			this.Txt_Usuarios.AcceptsReturn = true;
			this.Txt_Usuarios.Location = new System.Drawing.Point(134, 104);
			this.Txt_Usuarios.Name = "Txt_Usuarios";
			this.Txt_Usuarios.Size = new System.Drawing.Size(263, 27);
			this.Txt_Usuarios.TabIndex = 1;
			// 
			// Txt_Clave
			// 
			this.Txt_Clave.Location = new System.Drawing.Point(134, 155);
			this.Txt_Clave.Name = "Txt_Clave";
			this.Txt_Clave.PasswordChar = '■';
			this.Txt_Clave.Size = new System.Drawing.Size(263, 27);
			this.Txt_Clave.TabIndex = 2;
			this.Txt_Clave.TextChanged += new System.EventHandler(this.Txt_Clave_TextChanged);
			// 
			// Cmb_Lenguajes
			// 
			this.Cmb_Lenguajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Cmb_Lenguajes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Cmb_Lenguajes.FormattingEnabled = true;
			this.Cmb_Lenguajes.ItemHeight = 17;
			this.Cmb_Lenguajes.Items.AddRange(new object[] {
            "ESP",
            "ENG"});
			this.Cmb_Lenguajes.Location = new System.Drawing.Point(5, 9);
			this.Cmb_Lenguajes.Name = "Cmb_Lenguajes";
			this.Cmb_Lenguajes.Size = new System.Drawing.Size(64, 25);
			this.Cmb_Lenguajes.TabIndex = 6;
			this.Cmb_Lenguajes.Text = "LANG";
			this.Cmb_Lenguajes.SelectedIndexChanged += new System.EventHandler(this.Cmb_Lenguajes_SelectedIndexChanged);
			this.Cmb_Lenguajes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox1_KeyPress);
			// 
			// Lnk_olvideClave
			// 
			this.Lnk_olvideClave.AutoSize = true;
			this.Lnk_olvideClave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lnk_olvideClave.Location = new System.Drawing.Point(120, 266);
			this.Lnk_olvideClave.Name = "Lnk_olvideClave";
			this.Lnk_olvideClave.Size = new System.Drawing.Size(162, 17);
			this.Lnk_olvideClave.TabIndex = 5;
			this.Lnk_olvideClave.TabStop = true;
			this.Lnk_olvideClave.Text = "Olvidé mí Contraseña...";
			// 
			// Frm_Login
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(409, 292);
			this.Controls.Add(this.Lnk_olvideClave);
			this.Controls.Add(this.Txt_Clave);
			this.Controls.Add(this.Txt_Usuarios);
			this.Controls.Add(this.Btn_limpiar);
			this.Controls.Add(this.Btn_ingresar);
			this.Controls.Add(this.Lbl_Clave);
			this.Controls.Add(this.Lbl_Usuario);
			this.Controls.Add(this.Pnl_TituloLogin);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.Name = "Frm_Login";
			this.Opacity = 0.95D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bienvenido";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Frm_Login_Load);
			this.Pnl_TituloLogin.ResumeLayout(false);
			this.Pnl_TituloLogin.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel Pnl_TituloLogin;
		private System.Windows.Forms.Label Lbl_TituloLogin;
		private System.Windows.Forms.Label Lbl_Usuario;
		private System.Windows.Forms.Label Lbl_Clave;
		private System.Windows.Forms.Button Btn_ingresar;
		private System.Windows.Forms.Button Btn_limpiar;
		private System.Windows.Forms.TextBox Txt_Usuarios;
		private System.Windows.Forms.TextBox Txt_Clave;
		private System.Windows.Forms.ComboBox Cmb_Lenguajes;
		private System.Windows.Forms.LinkLabel Lnk_olvideClave;
	}
}