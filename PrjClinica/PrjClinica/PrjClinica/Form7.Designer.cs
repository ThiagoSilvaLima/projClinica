namespace PrjClinica
{
    partial class Form7
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txid = new Guna.UI2.WinForms.Guna2TextBox();
            this.btedit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btdelete = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btsalvar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txbusca = new Guna.UI2.WinForms.Guna2TextBox();
            this.txmedico = new Guna.UI2.WinForms.Guna2TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txpaciente = new Guna.UI2.WinForms.Guna2TextBox();
            this.txdt = new Guna.UI2.WinForms.Guna2TextBox();
            this.txhr = new Guna.UI2.WinForms.Guna2TextBox();
            this.txmotivo = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.guna2Button1.Location = new System.Drawing.Point(1023, -1);
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
            this.txid.Location = new System.Drawing.Point(28, 209);
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
            this.btedit.Location = new System.Drawing.Point(258, 480);
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
            this.btdelete.Location = new System.Drawing.Point(360, 480);
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
            this.btsalvar.Location = new System.Drawing.Point(139, 480);
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
            this.txbusca.Location = new System.Drawing.Point(548, 88);
            this.txbusca.Name = "txbusca";
            this.txbusca.PasswordChar = '\0';
            this.txbusca.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txbusca.PlaceholderText = "Buscar agendamentos";
            this.txbusca.SelectedText = "";
            this.txbusca.Size = new System.Drawing.Size(286, 33);
            this.txbusca.TabIndex = 126;
            this.txbusca.TextChanged += new System.EventHandler(this.txbusca_TextChanged);
            // 
            // txmedico
            // 
            this.txmedico.Animated = true;
            this.txmedico.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txmedico.BorderColor = System.Drawing.Color.Transparent;
            this.txmedico.BorderRadius = 7;
            this.txmedico.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txmedico.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txmedico.DefaultText = "";
            this.txmedico.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txmedico.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txmedico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txmedico.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txmedico.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txmedico.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.txmedico.ForeColor = System.Drawing.Color.Black;
            this.txmedico.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txmedico.Location = new System.Drawing.Point(28, 365);
            this.txmedico.Name = "txmedico";
            this.txmedico.PasswordChar = '\0';
            this.txmedico.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txmedico.PlaceholderText = "Medico";
            this.txmedico.SelectedText = "";
            this.txmedico.Size = new System.Drawing.Size(222, 33);
            this.txmedico.TabIndex = 119;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(548, 127);
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
            this.label2.Location = new System.Drawing.Point(172, 127);
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
            this.guna2PictureBox1.Location = new System.Drawing.Point(18, 127);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(506, 338);
            this.guna2PictureBox1.TabIndex = 114;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 55);
            this.label1.TabIndex = 112;
            this.label1.Text = "Agendamentos";
            // 
            // txpaciente
            // 
            this.txpaciente.Animated = true;
            this.txpaciente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txpaciente.BorderColor = System.Drawing.Color.Transparent;
            this.txpaciente.BorderRadius = 7;
            this.txpaciente.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txpaciente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txpaciente.DefaultText = "";
            this.txpaciente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txpaciente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txpaciente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txpaciente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txpaciente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txpaciente.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.txpaciente.ForeColor = System.Drawing.Color.Black;
            this.txpaciente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txpaciente.Location = new System.Drawing.Point(28, 326);
            this.txpaciente.Name = "txpaciente";
            this.txpaciente.PasswordChar = '\0';
            this.txpaciente.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txpaciente.PlaceholderText = "Paciente";
            this.txpaciente.SelectedText = "";
            this.txpaciente.Size = new System.Drawing.Size(286, 33);
            this.txpaciente.TabIndex = 115;
            // 
            // txdt
            // 
            this.txdt.Animated = true;
            this.txdt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txdt.BorderColor = System.Drawing.Color.Transparent;
            this.txdt.BorderRadius = 7;
            this.txdt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txdt.DefaultText = "";
            this.txdt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txdt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txdt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txdt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txdt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txdt.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.txdt.ForeColor = System.Drawing.Color.Black;
            this.txdt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txdt.Location = new System.Drawing.Point(28, 248);
            this.txdt.Name = "txdt";
            this.txdt.PasswordChar = '\0';
            this.txdt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txdt.PlaceholderText = "Data";
            this.txdt.SelectedText = "";
            this.txdt.Size = new System.Drawing.Size(163, 33);
            this.txdt.TabIndex = 117;
            this.txdt.TextChanged += new System.EventHandler(this.txdt_TextChanged);
            // 
            // txhr
            // 
            this.txhr.Animated = true;
            this.txhr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txhr.BorderColor = System.Drawing.Color.Transparent;
            this.txhr.BorderRadius = 7;
            this.txhr.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txhr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txhr.DefaultText = "";
            this.txhr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txhr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txhr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txhr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txhr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txhr.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.txhr.ForeColor = System.Drawing.Color.Black;
            this.txhr.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txhr.Location = new System.Drawing.Point(28, 287);
            this.txhr.Name = "txhr";
            this.txhr.PasswordChar = '\0';
            this.txhr.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txhr.PlaceholderText = "Hora";
            this.txhr.SelectedText = "";
            this.txhr.Size = new System.Drawing.Size(163, 33);
            this.txhr.TabIndex = 133;
            this.txhr.TextChanged += new System.EventHandler(this.txhr_TextChanged);
            // 
            // txmotivo
            // 
            this.txmotivo.Animated = true;
            this.txmotivo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txmotivo.BorderColor = System.Drawing.Color.Transparent;
            this.txmotivo.BorderRadius = 7;
            this.txmotivo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txmotivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txmotivo.DefaultText = "";
            this.txmotivo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txmotivo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txmotivo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txmotivo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txmotivo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txmotivo.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.txmotivo.ForeColor = System.Drawing.Color.Black;
            this.txmotivo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txmotivo.Location = new System.Drawing.Point(28, 404);
            this.txmotivo.Name = "txmotivo";
            this.txmotivo.PasswordChar = '\0';
            this.txmotivo.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txmotivo.PlaceholderText = "Motivo";
            this.txmotivo.SelectedText = "";
            this.txmotivo.Size = new System.Drawing.Size(222, 33);
            this.txmotivo.TabIndex = 134;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1057, 563);
            this.Controls.Add(this.txmotivo);
            this.Controls.Add(this.txhr);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.txid);
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btsalvar);
            this.Controls.Add(this.txbusca);
            this.Controls.Add(this.txmedico);
            this.Controls.Add(this.txdt);
            this.Controls.Add(this.txpaciente);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox txid;
        private Guna.UI2.WinForms.Guna2ImageButton btedit;
        private Guna.UI2.WinForms.Guna2ImageButton btdelete;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ImageButton btsalvar;
        private Guna.UI2.WinForms.Guna2TextBox txbusca;
        private Guna.UI2.WinForms.Guna2TextBox txmedico;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txpaciente;
        private Guna.UI2.WinForms.Guna2TextBox txdt;
        private Guna.UI2.WinForms.Guna2TextBox txhr;
        private Guna.UI2.WinForms.Guna2TextBox txmotivo;
    }
}