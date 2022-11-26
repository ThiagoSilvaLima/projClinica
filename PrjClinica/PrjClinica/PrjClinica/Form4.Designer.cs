namespace PrjClinica
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txnome = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txcpf = new Guna.UI2.WinForms.Guna2TextBox();
            this.txdtnascto = new Guna.UI2.WinForms.Guna2TextBox();
            this.txsexo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txcidade = new Guna.UI2.WinForms.Guna2TextBox();
            this.txendereco = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtipo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txuf = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txbairro = new Guna.UI2.WinForms.Guna2TextBox();
            this.txcell = new Guna.UI2.WinForms.Guna2TextBox();
            this.txemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbusca = new Guna.UI2.WinForms.Guna2TextBox();
            this.btsalvar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btdelete = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btedit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txid = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pacientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(547, 128);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(492, 338);
            this.listView1.TabIndex = 26;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BorderRadius = 15;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(17, 128);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(506, 338);
            this.guna2PictureBox1.TabIndex = 90;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // txnome
            // 
            this.txnome.Animated = true;
            this.txnome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txnome.BorderColor = System.Drawing.Color.Transparent;
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
            this.txnome.Location = new System.Drawing.Point(26, 247);
            this.txnome.Name = "txnome";
            this.txnome.PasswordChar = '\0';
            this.txnome.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txnome.PlaceholderText = "Nome";
            this.txnome.SelectedText = "";
            this.txnome.Size = new System.Drawing.Size(286, 33);
            this.txnome.TabIndex = 91;
            this.txnome.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged_1);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // txcpf
            // 
            this.txcpf.Animated = true;
            this.txcpf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txcpf.BorderColor = System.Drawing.Color.Transparent;
            this.txcpf.BorderRadius = 7;
            this.txcpf.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txcpf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txcpf.DefaultText = "";
            this.txcpf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txcpf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txcpf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txcpf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txcpf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txcpf.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.txcpf.ForeColor = System.Drawing.Color.Black;
            this.txcpf.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txcpf.Location = new System.Drawing.Point(318, 247);
            this.txcpf.Name = "txcpf";
            this.txcpf.PasswordChar = '\0';
            this.txcpf.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txcpf.PlaceholderText = "CPF";
            this.txcpf.SelectedText = "";
            this.txcpf.Size = new System.Drawing.Size(183, 33);
            this.txcpf.TabIndex = 92;
            this.txcpf.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged_2);
            // 
            // txdtnascto
            // 
            this.txdtnascto.Animated = true;
            this.txdtnascto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txdtnascto.BorderColor = System.Drawing.Color.Transparent;
            this.txdtnascto.BorderRadius = 7;
            this.txdtnascto.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txdtnascto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txdtnascto.DefaultText = "";
            this.txdtnascto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txdtnascto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txdtnascto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txdtnascto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txdtnascto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txdtnascto.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.txdtnascto.ForeColor = System.Drawing.Color.Black;
            this.txdtnascto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txdtnascto.Location = new System.Drawing.Point(26, 286);
            this.txdtnascto.Name = "txdtnascto";
            this.txdtnascto.PasswordChar = '\0';
            this.txdtnascto.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txdtnascto.PlaceholderText = "Data de Nascimento";
            this.txdtnascto.SelectedText = "";
            this.txdtnascto.Size = new System.Drawing.Size(163, 33);
            this.txdtnascto.TabIndex = 93;
            this.txdtnascto.TextChanged += new System.EventHandler(this.txdtnascto_TextChanged);
            // 
            // txsexo
            // 
            this.txsexo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txsexo.BorderColor = System.Drawing.Color.Transparent;
            this.txsexo.BorderRadius = 7;
            this.txsexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txsexo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txsexo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txsexo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txsexo.ForeColor = System.Drawing.Color.Black;
            this.txsexo.ItemHeight = 30;
            this.txsexo.Items.AddRange(new object[] {
            "M",
            "S",
            "O"});
            this.txsexo.Location = new System.Drawing.Point(195, 286);
            this.txsexo.Name = "txsexo";
            this.txsexo.Size = new System.Drawing.Size(83, 36);
            this.txsexo.TabIndex = 94;
            this.txsexo.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // txcidade
            // 
            this.txcidade.Animated = true;
            this.txcidade.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txcidade.BorderColor = System.Drawing.Color.Transparent;
            this.txcidade.BorderRadius = 7;
            this.txcidade.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txcidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txcidade.DefaultText = "";
            this.txcidade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txcidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txcidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txcidade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txcidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txcidade.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.txcidade.ForeColor = System.Drawing.Color.Black;
            this.txcidade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txcidade.Location = new System.Drawing.Point(26, 327);
            this.txcidade.Name = "txcidade";
            this.txcidade.PasswordChar = '\0';
            this.txcidade.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txcidade.PlaceholderText = "Cidade";
            this.txcidade.SelectedText = "";
            this.txcidade.Size = new System.Drawing.Size(222, 33);
            this.txcidade.TabIndex = 96;
            this.txcidade.TextChanged += new System.EventHandler(this.txcidade_TextChanged);
            // 
            // txendereco
            // 
            this.txendereco.Animated = true;
            this.txendereco.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txendereco.BorderColor = System.Drawing.Color.Transparent;
            this.txendereco.BorderRadius = 7;
            this.txendereco.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txendereco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txendereco.DefaultText = "";
            this.txendereco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txendereco.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txendereco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txendereco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txendereco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txendereco.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.txendereco.ForeColor = System.Drawing.Color.Black;
            this.txendereco.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txendereco.Location = new System.Drawing.Point(201, 372);
            this.txendereco.Name = "txendereco";
            this.txendereco.PasswordChar = '\0';
            this.txendereco.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txendereco.PlaceholderText = "Bairro";
            this.txendereco.SelectedText = "";
            this.txendereco.Size = new System.Drawing.Size(289, 33);
            this.txendereco.TabIndex = 97;
            this.txendereco.TextChanged += new System.EventHandler(this.txendereco_TextChanged);
            // 
            // txtipo
            // 
            this.txtipo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtipo.BorderColor = System.Drawing.Color.Transparent;
            this.txtipo.BorderRadius = 7;
            this.txtipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtipo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtipo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtipo.ForeColor = System.Drawing.Color.Black;
            this.txtipo.ItemHeight = 30;
            this.txtipo.Items.AddRange(new object[] {
            "rua",
            "avenida ",
            "alameda",
            "vicinal",
            "estrada"});
            this.txtipo.Location = new System.Drawing.Point(26, 369);
            this.txtipo.Name = "txtipo";
            this.txtipo.Size = new System.Drawing.Size(169, 36);
            this.txtipo.TabIndex = 98;
            this.txtipo.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged_1);
            // 
            // txuf
            // 
            this.txuf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txuf.BorderColor = System.Drawing.Color.Transparent;
            this.txuf.BorderRadius = 7;
            this.txuf.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txuf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txuf.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txuf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txuf.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txuf.ForeColor = System.Drawing.Color.Black;
            this.txuf.ItemHeight = 30;
            this.txuf.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "SC",
            "MG",
            "RS",
            "RN",
            "BA",
            "PA"});
            this.txuf.Location = new System.Drawing.Point(254, 327);
            this.txuf.Name = "txuf";
            this.txuf.Size = new System.Drawing.Size(66, 36);
            this.txuf.TabIndex = 99;
            this.txuf.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged_2);
            // 
            // txbairro
            // 
            this.txbairro.Animated = true;
            this.txbairro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txbairro.BorderColor = System.Drawing.Color.Transparent;
            this.txbairro.BorderRadius = 7;
            this.txbairro.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txbairro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbairro.DefaultText = "";
            this.txbairro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbairro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbairro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbairro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbairro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbairro.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.txbairro.ForeColor = System.Drawing.Color.Black;
            this.txbairro.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbairro.Location = new System.Drawing.Point(326, 330);
            this.txbairro.Name = "txbairro";
            this.txbairro.PasswordChar = '\0';
            this.txbairro.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txbairro.PlaceholderText = "Endereço";
            this.txbairro.SelectedText = "";
            this.txbairro.Size = new System.Drawing.Size(187, 33);
            this.txbairro.TabIndex = 100;
            this.txbairro.TextChanged += new System.EventHandler(this.txbairro_TextChanged);
            // 
            // txcell
            // 
            this.txcell.Animated = true;
            this.txcell.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txcell.BorderColor = System.Drawing.Color.Transparent;
            this.txcell.BorderRadius = 7;
            this.txcell.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txcell.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txcell.DefaultText = "";
            this.txcell.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txcell.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txcell.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txcell.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txcell.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txcell.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.txcell.ForeColor = System.Drawing.Color.Black;
            this.txcell.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txcell.Location = new System.Drawing.Point(320, 415);
            this.txcell.Name = "txcell";
            this.txcell.PasswordChar = '\0';
            this.txcell.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txcell.PlaceholderText = "Celular";
            this.txcell.SelectedText = "";
            this.txcell.Size = new System.Drawing.Size(193, 33);
            this.txcell.TabIndex = 101;
            this.txcell.TextChanged += new System.EventHandler(this.txcell_TextChanged);
            // 
            // txemail
            // 
            this.txemail.Animated = true;
            this.txemail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txemail.BorderColor = System.Drawing.Color.Transparent;
            this.txemail.BorderRadius = 7;
            this.txemail.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txemail.DefaultText = "";
            this.txemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txemail.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.txemail.ForeColor = System.Drawing.Color.Black;
            this.txemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txemail.Location = new System.Drawing.Point(28, 415);
            this.txemail.Name = "txemail";
            this.txemail.PasswordChar = '\0';
            this.txemail.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txemail.PlaceholderText = "Insira seu e-mail";
            this.txemail.SelectedText = "";
            this.txemail.Size = new System.Drawing.Size(282, 33);
            this.txemail.TabIndex = 102;
            this.txemail.TextChanged += new System.EventHandler(this.txemail_TextChanged);
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
            this.txbusca.Location = new System.Drawing.Point(547, 89);
            this.txbusca.Name = "txbusca";
            this.txbusca.PasswordChar = '\0';
            this.txbusca.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txbusca.PlaceholderText = "Buscar pacientes";
            this.txbusca.SelectedText = "";
            this.txbusca.Size = new System.Drawing.Size(286, 33);
            this.txbusca.TabIndex = 103;
            this.txbusca.TextChanged += new System.EventHandler(this.txbusca_TextChanged);
            // 
            // btsalvar
            // 
            this.btsalvar.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btsalvar.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btsalvar.Image = ((System.Drawing.Image)(resources.GetObject("btsalvar.Image")));
            this.btsalvar.ImageOffset = new System.Drawing.Point(0, 0);
            this.btsalvar.ImageRotate = 0F;
            this.btsalvar.ImageSize = new System.Drawing.Size(40, 40);
            this.btsalvar.Location = new System.Drawing.Point(138, 481);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.PressedState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Vertical;
            this.btsalvar.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btsalvar.Size = new System.Drawing.Size(57, 50);
            this.btsalvar.TabIndex = 105;
            this.btsalvar.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // btdelete
            // 
            this.btdelete.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btdelete.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btdelete.Image = ((System.Drawing.Image)(resources.GetObject("btdelete.Image")));
            this.btdelete.ImageOffset = new System.Drawing.Point(0, 0);
            this.btdelete.ImageRotate = 0F;
            this.btdelete.ImageSize = new System.Drawing.Size(40, 40);
            this.btdelete.Location = new System.Drawing.Point(359, 481);
            this.btdelete.Name = "btdelete";
            this.btdelete.PressedState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Vertical;
            this.btdelete.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btdelete.Size = new System.Drawing.Size(57, 50);
            this.btdelete.TabIndex = 106;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btedit
            // 
            this.btedit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btedit.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btedit.Image = ((System.Drawing.Image)(resources.GetObject("btedit.Image")));
            this.btedit.ImageOffset = new System.Drawing.Point(0, 0);
            this.btedit.ImageRotate = 0F;
            this.btedit.ImageSize = new System.Drawing.Size(40, 40);
            this.btedit.Location = new System.Drawing.Point(257, 481);
            this.btedit.Name = "btedit";
            this.btedit.PressedState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Vertical;
            this.btedit.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btedit.Size = new System.Drawing.Size(57, 50);
            this.btedit.TabIndex = 107;
            this.btedit.Click += new System.EventHandler(this.btedit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 55);
            this.label2.TabIndex = 109;
            this.label2.Text = "Cadastro";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.txid.Location = new System.Drawing.Point(26, 197);
            this.txid.Name = "txid";
            this.txid.PasswordChar = '\0';
            this.txid.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txid.PlaceholderText = "ID";
            this.txid.SelectedText = "";
            this.txid.Size = new System.Drawing.Size(69, 33);
            this.txid.TabIndex = 110;
            this.txid.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged_3);
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
            this.guna2Button1.Location = new System.Drawing.Point(1022, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(35, 34);
            this.guna2Button1.TabIndex = 111;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1057, 563);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.txid);
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btsalvar);
            this.Controls.Add(this.txbusca);
            this.Controls.Add(this.txemail);
            this.Controls.Add(this.txcell);
            this.Controls.Add(this.txbairro);
            this.Controls.Add(this.txuf);
            this.Controls.Add(this.txtipo);
            this.Controls.Add(this.txendereco);
            this.Controls.Add(this.txcidade);
            this.Controls.Add(this.txsexo);
            this.Controls.Add(this.txdtnascto);
            this.Controls.Add(this.txcpf);
            this.Controls.Add(this.txnome);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Cadastro";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txnome;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txcpf;
        private Guna.UI2.WinForms.Guna2ComboBox txsexo;
        private Guna.UI2.WinForms.Guna2TextBox txdtnascto;
        private Guna.UI2.WinForms.Guna2TextBox txendereco;
        private Guna.UI2.WinForms.Guna2TextBox txcidade;
        private Guna.UI2.WinForms.Guna2ComboBox txtipo;
        private Guna.UI2.WinForms.Guna2ComboBox txuf;
        private Guna.UI2.WinForms.Guna2TextBox txbairro;
        private Guna.UI2.WinForms.Guna2TextBox txemail;
        private Guna.UI2.WinForms.Guna2TextBox txcell;
        private Guna.UI2.WinForms.Guna2TextBox txbusca;
        private Guna.UI2.WinForms.Guna2ImageButton btsalvar;
        private Guna.UI2.WinForms.Guna2ImageButton btedit;
        private Guna.UI2.WinForms.Guna2ImageButton btdelete;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txid;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}