namespace PrjClinica
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txid = new Guna.UI2.WinForms.Guna2TextBox();
            this.btedit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btdelete = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btsalvar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txbusca = new Guna.UI2.WinForms.Guna2TextBox();
            this.txespecialidade = new Guna.UI2.WinForms.Guna2TextBox();
            this.txdtformacao = new Guna.UI2.WinForms.Guna2TextBox();
            this.txcrm = new Guna.UI2.WinForms.Guna2TextBox();
            this.txnome = new Guna.UI2.WinForms.Guna2TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.IndicateFocus = true;
            this.guna2Button1.Location = new System.Drawing.Point(1031, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(35, 34);
            this.guna2Button1.TabIndex = 132;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txid
            // 
            this.txid.Animated = true;
            this.txid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txid.BorderColor = System.Drawing.Color.Transparent;
            this.txid.BorderRadius = 7;
            this.txid.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txid.DefaultText = "";
            this.txid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txid.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.txid.ForeColor = System.Drawing.Color.Black;
            this.txid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txid.Location = new System.Drawing.Point(32, 197);
            this.txid.Name = "txid";
            this.txid.PasswordChar = '\0';
            this.txid.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txid.PlaceholderText = "ID";
            this.txid.SelectedText = "";
            this.txid.Size = new System.Drawing.Size(69, 33);
            this.txid.TabIndex = 131;
            // 
            // btedit
            // 
            this.btedit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btedit.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btedit.Image = ((System.Drawing.Image)(resources.GetObject("btedit.Image")));
            this.btedit.ImageOffset = new System.Drawing.Point(0, 0);
            this.btedit.ImageRotate = 0F;
            this.btedit.ImageSize = new System.Drawing.Size(40, 40);
            this.btedit.Location = new System.Drawing.Point(263, 481);
            this.btedit.Name = "btedit";
            this.btedit.PressedState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Vertical;
            this.btedit.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btedit.Size = new System.Drawing.Size(57, 50);
            this.btedit.TabIndex = 129;
            this.btedit.Click += new System.EventHandler(this.btedit_Click);
            // 
            // btdelete
            // 
            this.btdelete.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btdelete.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btdelete.Image = ((System.Drawing.Image)(resources.GetObject("btdelete.Image")));
            this.btdelete.ImageOffset = new System.Drawing.Point(0, 0);
            this.btdelete.ImageRotate = 0F;
            this.btdelete.ImageSize = new System.Drawing.Size(40, 40);
            this.btdelete.Location = new System.Drawing.Point(365, 481);
            this.btdelete.Name = "btdelete";
            this.btdelete.PressedState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Vertical;
            this.btdelete.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btdelete.Size = new System.Drawing.Size(57, 50);
            this.btdelete.TabIndex = 128;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btsalvar
            // 
            this.btsalvar.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btsalvar.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btsalvar.Image = ((System.Drawing.Image)(resources.GetObject("btsalvar.Image")));
            this.btsalvar.ImageOffset = new System.Drawing.Point(0, 0);
            this.btsalvar.ImageRotate = 0F;
            this.btsalvar.ImageSize = new System.Drawing.Size(40, 40);
            this.btsalvar.Location = new System.Drawing.Point(144, 481);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.PressedState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Vertical;
            this.btsalvar.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btsalvar.Size = new System.Drawing.Size(57, 50);
            this.btsalvar.TabIndex = 127;
            this.btsalvar.Click += new System.EventHandler(this.btsalvar_Click);
            // 
            // txbusca
            // 
            this.txbusca.BackColor = System.Drawing.Color.Transparent;
            this.txbusca.BorderColor = System.Drawing.Color.Transparent;
            this.txbusca.BorderRadius = 7;
            this.txbusca.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txbusca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbusca.DefaultText = "";
            this.txbusca.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbusca.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbusca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbusca.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbusca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbusca.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.txbusca.ForeColor = System.Drawing.Color.Black;
            this.txbusca.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbusca.IconLeft = ((System.Drawing.Image)(resources.GetObject("txbusca.IconLeft")));
            this.txbusca.Location = new System.Drawing.Point(553, 89);
            this.txbusca.Name = "txbusca";
            this.txbusca.PasswordChar = '\0';
            this.txbusca.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txbusca.PlaceholderText = "Buscar medicos";
            this.txbusca.SelectedText = "";
            this.txbusca.Size = new System.Drawing.Size(286, 33);
            this.txbusca.TabIndex = 126;
            this.txbusca.TextChanged += new System.EventHandler(this.txbusca_TextChanged);
            // 
            // txespecialidade
            // 
            this.txespecialidade.Animated = true;
            this.txespecialidade.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txespecialidade.BorderColor = System.Drawing.Color.Transparent;
            this.txespecialidade.BorderRadius = 7;
            this.txespecialidade.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txespecialidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txespecialidade.DefaultText = "";
            this.txespecialidade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txespecialidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txespecialidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txespecialidade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txespecialidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txespecialidade.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.txespecialidade.ForeColor = System.Drawing.Color.Black;
            this.txespecialidade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txespecialidade.Location = new System.Drawing.Point(32, 403);
            this.txespecialidade.Name = "txespecialidade";
            this.txespecialidade.PasswordChar = '\0';
            this.txespecialidade.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txespecialidade.PlaceholderText = "Especialidade";
            this.txespecialidade.SelectedText = "";
            this.txespecialidade.Size = new System.Drawing.Size(286, 33);
            this.txespecialidade.TabIndex = 119;
            // 
            // txdtformacao
            // 
            this.txdtformacao.Animated = true;
            this.txdtformacao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txdtformacao.BorderColor = System.Drawing.Color.Transparent;
            this.txdtformacao.BorderRadius = 7;
            this.txdtformacao.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txdtformacao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txdtformacao.DefaultText = "";
            this.txdtformacao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txdtformacao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txdtformacao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txdtformacao.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txdtformacao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txdtformacao.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.txdtformacao.ForeColor = System.Drawing.Color.Black;
            this.txdtformacao.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txdtformacao.Location = new System.Drawing.Point(32, 350);
            this.txdtformacao.Name = "txdtformacao";
            this.txdtformacao.PasswordChar = '\0';
            this.txdtformacao.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txdtformacao.PlaceholderText = "Data de Formação";
            this.txdtformacao.SelectedText = "";
            this.txdtformacao.Size = new System.Drawing.Size(163, 33);
            this.txdtformacao.TabIndex = 117;
            this.txdtformacao.TextChanged += new System.EventHandler(this.txdtformacao_TextChanged);
            // 
            // txcrm
            // 
            this.txcrm.Animated = true;
            this.txcrm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txcrm.BorderColor = System.Drawing.Color.Transparent;
            this.txcrm.BorderRadius = 7;
            this.txcrm.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txcrm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txcrm.DefaultText = "";
            this.txcrm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txcrm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txcrm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txcrm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txcrm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txcrm.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.txcrm.ForeColor = System.Drawing.Color.Black;
            this.txcrm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txcrm.Location = new System.Drawing.Point(32, 298);
            this.txcrm.Name = "txcrm";
            this.txcrm.PasswordChar = '\0';
            this.txcrm.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txcrm.PlaceholderText = "CRM";
            this.txcrm.SelectedText = "";
            this.txcrm.Size = new System.Drawing.Size(183, 33);
            this.txcrm.TabIndex = 116;
            // 
            // txnome
            // 
            this.txnome.Animated = true;
            this.txnome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txnome.BorderColor = System.Drawing.Color.Black;
            this.txnome.BorderRadius = 7;
            this.txnome.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txnome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txnome.DefaultText = "";
            this.txnome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txnome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txnome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txnome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txnome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txnome.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.txnome.ForeColor = System.Drawing.Color.Black;
            this.txnome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txnome.Location = new System.Drawing.Point(32, 247);
            this.txnome.Name = "txnome";
            this.txnome.PasswordChar = '\0';
            this.txnome.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txnome.PlaceholderText = "Nome";
            this.txnome.SelectedText = "";
            this.txnome.Size = new System.Drawing.Size(286, 33);
            this.txnome.TabIndex = 115;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(553, 128);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(492, 338);
            this.listView1.TabIndex = 113;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 55);
            this.label2.TabIndex = 130;
            this.label2.Text = "Cadastro";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BorderRadius = 15;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(23, 128);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(506, 338);
            this.guna2PictureBox1.TabIndex = 114;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 55);
            this.label1.TabIndex = 112;
            this.label1.Text = "Medicos";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1066, 550);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.txid);
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btsalvar);
            this.Controls.Add(this.txbusca);
            this.Controls.Add(this.txespecialidade);
            this.Controls.Add(this.txdtformacao);
            this.Controls.Add(this.txcrm);
            this.Controls.Add(this.txnome);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox txid;
        private Guna.UI2.WinForms.Guna2ImageButton btedit;
        private Guna.UI2.WinForms.Guna2ImageButton btdelete;
        private Guna.UI2.WinForms.Guna2ImageButton btsalvar;
        private Guna.UI2.WinForms.Guna2TextBox txbusca;
        private Guna.UI2.WinForms.Guna2TextBox txespecialidade;
        private Guna.UI2.WinForms.Guna2TextBox txdtformacao;
        private Guna.UI2.WinForms.Guna2TextBox txcrm;
        private Guna.UI2.WinForms.Guna2TextBox txnome;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
    }
}