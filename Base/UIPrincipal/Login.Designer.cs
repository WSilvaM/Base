
namespace UIPrincipal
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtB_Usuario = new System.Windows.Forms.TextBox();
            this.txtB_Senha = new System.Windows.Forms.TextBox();
            this.lab_Usuario = new System.Windows.Forms.Label();
            this.lab_Senha = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.pictureBox1);
            this.GroupBox1.Controls.Add(this.btn_Login);
            this.GroupBox1.Controls.Add(this.lab_Senha);
            this.GroupBox1.Controls.Add(this.lab_Usuario);
            this.GroupBox1.Controls.Add(this.txtB_Senha);
            this.GroupBox1.Controls.Add(this.txtB_Usuario);
            this.GroupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.GroupBox1.Location = new System.Drawing.Point(21, 22);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(755, 389);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Login";
            // 
            // txtB_Usuario
            // 
            this.txtB_Usuario.Location = new System.Drawing.Point(111, 61);
            this.txtB_Usuario.Name = "txtB_Usuario";
            this.txtB_Usuario.Size = new System.Drawing.Size(224, 22);
            this.txtB_Usuario.TabIndex = 0;
            // 
            // txtB_Senha
            // 
            this.txtB_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB_Senha.Location = new System.Drawing.Point(111, 137);
            this.txtB_Senha.Name = "txtB_Senha";
            this.txtB_Senha.PasswordChar = '*';
            this.txtB_Senha.Size = new System.Drawing.Size(224, 24);
            this.txtB_Senha.TabIndex = 1;
            // 
            // lab_Usuario
            // 
            this.lab_Usuario.AutoSize = true;
            this.lab_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Usuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lab_Usuario.Location = new System.Drawing.Point(25, 63);
            this.lab_Usuario.Name = "lab_Usuario";
            this.lab_Usuario.Size = new System.Drawing.Size(74, 20);
            this.lab_Usuario.TabIndex = 2;
            this.lab_Usuario.Text = "Usuário";
            this.lab_Usuario.Click += new System.EventHandler(this.lab_Usuario_Click);
            // 
            // lab_Senha
            // 
            this.lab_Senha.AutoSize = true;
            this.lab_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Senha.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lab_Senha.Location = new System.Drawing.Point(38, 139);
            this.lab_Senha.Name = "lab_Senha";
            this.lab_Senha.Size = new System.Drawing.Size(61, 20);
            this.lab_Senha.TabIndex = 3;
            this.lab_Senha.Text = "Senha";
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Login.Location = new System.Drawing.Point(140, 191);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(173, 45);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(439, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibeUsuáriosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.usuáriosToolStripMenuItem.Text = "Login";
            // 
            // exibeUsuáriosToolStripMenuItem
            // 
            this.exibeUsuáriosToolStripMenuItem.Name = "exibeUsuáriosToolStripMenuItem";
            this.exibeUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.exibeUsuáriosToolStripMenuItem.Text = "Exibir Usuários";
            this.exibeUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.exibeUsuáriosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(422, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Registra Novo Usuário";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Label lab_Senha;
        private System.Windows.Forms.Label lab_Usuario;
        private System.Windows.Forms.TextBox txtB_Senha;
        private System.Windows.Forms.TextBox txtB_Usuario;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibeUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}