namespace LibraryManagementSystem2
{
    partial class Frmbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmbook));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtISBN = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lable = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dgv = new Guna.UI.WinForms.GunaDataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAuthor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPublisher = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtBookName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategoryId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CategoryId = new System.Windows.Forms.Label();
            this.txtAvailableCopies = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1271, 123);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(1221, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 47);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(567, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "BOOKS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(391, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Library Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 763);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1271, 10);
            this.panel2.TabIndex = 22;
            // 
            // txtISBN
            // 
            this.txtISBN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtISBN.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtISBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtISBN.HintForeColor = System.Drawing.Color.Empty;
            this.txtISBN.HintText = "";
            this.txtISBN.isPassword = false;
            this.txtISBN.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtISBN.LineIdleColor = System.Drawing.Color.Gray;
            this.txtISBN.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtISBN.LineThickness = 3;
            this.txtISBN.Location = new System.Drawing.Point(305, 362);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(4);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(175, 37);
            this.txtISBN.TabIndex = 37;
            this.txtISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtISBN.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged);
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.ForeColor = System.Drawing.Color.Black;
            this.lable.Location = new System.Drawing.Point(10, 504);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(255, 37);
            this.lable.TabIndex = 36;
            this.lable.Text = "AvailableCopies";
            this.lable.Click += new System.EventHandler(this.label7_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(197, 705);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 55);
            this.button4.TabIndex = 35;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // dgv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.Location = new System.Drawing.Point(549, 140);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(689, 531);
            this.dgv.TabIndex = 34;
            this.dgv.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv.ThemeStyle.HeaderStyle.Height = 25;
            this.dgv.ThemeStyle.ReadOnly = false;
            this.dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv.ThemeStyle.RowsStyle.Height = 24;
            this.dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(360, 634);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 55);
            this.button3.TabIndex = 33;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(197, 634);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 55);
            this.button2.TabIndex = 32;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(36, 634);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 55);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAuthor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAuthor.HintForeColor = System.Drawing.Color.Empty;
            this.txtAuthor.HintText = "";
            this.txtAuthor.isPassword = false;
            this.txtAuthor.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtAuthor.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAuthor.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtAuthor.LineThickness = 3;
            this.txtAuthor.Location = new System.Drawing.Point(305, 230);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(175, 37);
            this.txtAuthor.TabIndex = 29;
            this.txtAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAuthor.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox4_OnValueChanged);
            // 
            // txtPublisher
            // 
            this.txtPublisher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPublisher.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPublisher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPublisher.HintForeColor = System.Drawing.Color.Empty;
            this.txtPublisher.HintText = "";
            this.txtPublisher.isPassword = false;
            this.txtPublisher.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPublisher.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPublisher.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPublisher.LineThickness = 3;
            this.txtPublisher.Location = new System.Drawing.Point(305, 298);
            this.txtPublisher.Margin = new System.Windows.Forms.Padding(4);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(175, 37);
            this.txtPublisher.TabIndex = 28;
            this.txtPublisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPublisher.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox3_OnValueChanged);
            // 
            // txtBookName
            // 
            this.txtBookName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBookName.HintForeColor = System.Drawing.Color.Empty;
            this.txtBookName.HintText = "";
            this.txtBookName.isPassword = false;
            this.txtBookName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtBookName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtBookName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtBookName.LineThickness = 3;
            this.txtBookName.Location = new System.Drawing.Point(305, 177);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(175, 37);
            this.txtBookName.TabIndex = 27;
            this.txtBookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBookName.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(10, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 37);
            this.label5.TabIndex = 26;
            this.label5.Text = "Publisher";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 37);
            this.label4.TabIndex = 25;
            this.label4.Text = "Author";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 37);
            this.label3.TabIndex = 24;
            this.label3.Text = "BookName";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoryId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCategoryId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCategoryId.HintForeColor = System.Drawing.Color.Empty;
            this.txtCategoryId.HintText = "";
            this.txtCategoryId.isPassword = false;
            this.txtCategoryId.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCategoryId.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCategoryId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCategoryId.LineThickness = 3;
            this.txtCategoryId.Location = new System.Drawing.Point(305, 432);
            this.txtCategoryId.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(175, 37);
            this.txtCategoryId.TabIndex = 39;
            this.txtCategoryId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CategoryId
            // 
            this.CategoryId.AutoSize = true;
            this.CategoryId.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryId.ForeColor = System.Drawing.Color.Black;
            this.CategoryId.Location = new System.Drawing.Point(10, 432);
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.Size = new System.Drawing.Size(185, 37);
            this.CategoryId.TabIndex = 38;
            this.CategoryId.Text = "CategoryId";
            // 
            // txtAvailableCopies
            // 
            this.txtAvailableCopies.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAvailableCopies.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAvailableCopies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAvailableCopies.HintForeColor = System.Drawing.Color.Empty;
            this.txtAvailableCopies.HintText = "";
            this.txtAvailableCopies.isPassword = false;
            this.txtAvailableCopies.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtAvailableCopies.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAvailableCopies.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtAvailableCopies.LineThickness = 3;
            this.txtAvailableCopies.Location = new System.Drawing.Point(305, 504);
            this.txtAvailableCopies.Margin = new System.Windows.Forms.Padding(4);
            this.txtAvailableCopies.Name = "txtAvailableCopies";
            this.txtAvailableCopies.Size = new System.Drawing.Size(175, 37);
            this.txtAvailableCopies.TabIndex = 40;
            this.txtAvailableCopies.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(10, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 37);
            this.label8.TabIndex = 41;
            this.label8.Text = "ISBN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(10, 573);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 37);
            this.label9.TabIndex = 42;
            this.label9.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.HintForeColor = System.Drawing.Color.Empty;
            this.txtPrice.HintText = "";
            this.txtPrice.isPassword = false;
            this.txtPrice.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPrice.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPrice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPrice.LineThickness = 3;
            this.txtPrice.Location = new System.Drawing.Point(305, 573);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(175, 37);
            this.txtPrice.TabIndex = 43;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(10, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 37);
            this.label6.TabIndex = 44;
            this.label6.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtId.HintForeColor = System.Drawing.Color.Empty;
            this.txtId.HintText = "";
            this.txtId.isPassword = false;
            this.txtId.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtId.LineIdleColor = System.Drawing.Color.Gray;
            this.txtId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtId.LineThickness = 3;
            this.txtId.Location = new System.Drawing.Point(305, 126);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(175, 37);
            this.txtId.TabIndex = 45;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Frmbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1271, 773);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAvailableCopies);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(this.CategoryId);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmbook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookTbl";
            this.Load += new System.EventHandler(this.BookTbl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtISBN;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Button button4;
        private Guna.UI.WinForms.GunaDataGridView dgv;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAdd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAuthor;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPublisher;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBookName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCategoryId;
        private System.Windows.Forms.Label CategoryId;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAvailableCopies;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtId;
    }
}