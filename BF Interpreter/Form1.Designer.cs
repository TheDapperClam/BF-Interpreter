namespace BF_Interpreter {
    partial class InterpreterForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose ();
            }
            base.Dispose ( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.components = new System.ComponentModel.Container();
            this.inputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runButton = new System.Windows.Forms.Button();
            this.byteTextBox0 = new System.Windows.Forms.TextBox();
            this.byteTextBox1 = new System.Windows.Forms.TextBox();
            this.byteTextBox2 = new System.Windows.Forms.TextBox();
            this.byteTextBox3 = new System.Windows.Forms.TextBox();
            this.byteTextBox4 = new System.Windows.Forms.TextBox();
            this.byteTextBox5 = new System.Windows.Forms.TextBox();
            this.byteTextBox6 = new System.Windows.Forms.TextBox();
            this.byteTextBox7 = new System.Windows.Forms.TextBox();
            this.byteTextBox8 = new System.Windows.Forms.TextBox();
            this.byteTextBox9 = new System.Windows.Forms.TextBox();
            this.byteTextBox10 = new System.Windows.Forms.TextBox();
            this.byteTextBox11 = new System.Windows.Forms.TextBox();
            this.byteTextBox12 = new System.Windows.Forms.TextBox();
            this.byteTextBox13 = new System.Windows.Forms.TextBox();
            this.byteTextBox26 = new System.Windows.Forms.TextBox();
            this.byteTextBox25 = new System.Windows.Forms.TextBox();
            this.byteTextBox24 = new System.Windows.Forms.TextBox();
            this.byteTextBox23 = new System.Windows.Forms.TextBox();
            this.byteTextBox22 = new System.Windows.Forms.TextBox();
            this.byteTextBox21 = new System.Windows.Forms.TextBox();
            this.byteTextBox20 = new System.Windows.Forms.TextBox();
            this.byteTextBox19 = new System.Windows.Forms.TextBox();
            this.byteTextBox18 = new System.Windows.Forms.TextBox();
            this.byteTextBox17 = new System.Windows.Forms.TextBox();
            this.byteTextBox16 = new System.Windows.Forms.TextBox();
            this.byteTextBox15 = new System.Windows.Forms.TextBox();
            this.byteTextBox14 = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.interpreterTimer = new System.Windows.Forms.Timer(this.components);
            this.pauseButton = new System.Windows.Forms.Button();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.interpretationSpeedTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputRichTextBox
            // 
            this.inputRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputRichTextBox.BackColor = System.Drawing.Color.Black;
            this.inputRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputRichTextBox.ForeColor = System.Drawing.Color.White;
            this.inputRichTextBox.Location = new System.Drawing.Point(0, 107);
            this.inputRichTextBox.Name = "inputRichTextBox";
            this.inputRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.inputRichTextBox.Size = new System.Drawing.Size(990, 424);
            this.inputRichTextBox.TabIndex = 0;
            this.inputRichTextBox.Text = "";
            this.inputRichTextBox.TextChanged += new System.EventHandler(this.inputRichTextBox_TextChanged);
            this.inputRichTextBox.Enter += new System.EventHandler(this.inputRichTextBox_Enter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(990, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator3,
            this.openToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(111, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(111, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.toolStripSeparator4,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.manualToolStripMenuItem.Text = "&Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(111, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // runButton
            // 
            this.runButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.runButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.runButton.FlatAppearance.BorderSize = 0;
            this.runButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runButton.Location = new System.Drawing.Point(0, 70);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(990, 37);
            this.runButton.TabIndex = 31;
            this.runButton.Text = "&Run";
            this.runButton.UseVisualStyleBackColor = false;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // byteTextBox0
            // 
            this.byteTextBox0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.byteTextBox0.BackColor = System.Drawing.Color.Red;
            this.byteTextBox0.ForeColor = System.Drawing.Color.White;
            this.byteTextBox0.Location = new System.Drawing.Point(237, 36);
            this.byteTextBox0.Name = "byteTextBox0";
            this.byteTextBox0.ReadOnly = true;
            this.byteTextBox0.Size = new System.Drawing.Size(28, 20);
            this.byteTextBox0.TabIndex = 2;
            this.byteTextBox0.TabStop = false;
            this.byteTextBox0.Text = "0";
            this.byteTextBox0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // byteTextBox1
            // 
            this.byteTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.byteTextBox1.BackColor = System.Drawing.Color.Black;
            this.byteTextBox1.ForeColor = System.Drawing.Color.White;
            this.byteTextBox1.Location = new System.Drawing.Point(264, 36);
            this.byteTextBox1.Name = "byteTextBox1";
            this.byteTextBox1.ReadOnly = true;
            this.byteTextBox1.Size = new System.Drawing.Size(28, 20);
            this.byteTextBox1.TabIndex = 3;
            this.byteTextBox1.TabStop = false;
            this.byteTextBox1.Text = "0";
            this.byteTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // byteTextBox2
            // 
            this.byteTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.byteTextBox2.BackColor = System.Drawing.Color.Black;
            this.byteTextBox2.ForeColor = System.Drawing.Color.White;
            this.byteTextBox2.Location = new System.Drawing.Point(291, 36);
            this.byteTextBox2.Name = "byteTextBox2";
            this.byteTextBox2.ReadOnly = true;
            this.byteTextBox2.Size = new System.Drawing.Size(28, 20);
            this.byteTextBox2.TabIndex = 4;
            this.byteTextBox2.TabStop = false;
            this.byteTextBox2.Text = "0";
            this.byteTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // byteTextBox3
            // 
            this.byteTextBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.byteTextBox3.BackColor = System.Drawing.Color.Black;
            this.byteTextBox3.ForeColor = System.Drawing.Color.White;
            this.byteTextBox3.Location = new System.Drawing.Point(318, 36);
            this.byteTextBox3.Name = "byteTextBox3";
            this.byteTextBox3.ReadOnly = true;
            this.byteTextBox3.Size = new System.Drawing.Size(28, 20);
            this.byteTextBox3.TabIndex = 5;
            this.byteTextBox3.TabStop = false;
            this.byteTextBox3.Text = "0";
            this.byteTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // byteTextBox4
            // 
            this.byteTextBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.byteTextBox4.BackColor = System.Drawing.Color.Black;
            this.byteTextBox4.ForeColor = System.Drawing.Color.White;
            this.byteTextBox4.Location = new System.Drawing.Point(345, 36);
            this.byteTextBox4.Name = "byteTextBox4";
            this.byteTextBox4.ReadOnly = true;
            this.byteTextBox4.Size = new System.Drawing.Size(28, 20);
            this.byteTextBox4.TabIndex = 6;
            this.byteTextBox4.TabStop = false;
            this.byteTextBox4.Text = "0";
            this.byteTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // byteTextBox5
            // 
            this.byteTextBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.byteTextBox5.BackColor = System.Drawing.Color.Black;
            this.byteTextBox5.ForeColor = System.Drawing.Color.White;
            this.byteTextBox5.Location = new System.Drawing.Point(372, 36);
            this.byteTextBox5.Name = "byteTextBox5";
            this.byteTextBox5.ReadOnly = true;
            this.byteTextBox5.Size = new System.Drawing.Size(28, 20);
            this.byteTextBox5.TabIndex = 7;
            this.byteTextBox5.TabStop = false;
            this.byteTextBox5.Text = "0";
            this.byteTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // byteTextBox6
            // 
            this.byteTextBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.byteTextBox6.BackColor = System.Drawing.Color.Black;
            this.byteTextBox6.ForeColor = System.Drawing.Color.White;
            this.byteTextBox6.Location = new System.Drawing.Point(399, 36);
            this.byteTextBox6.Name = "byteTextBox6";
            this.byteTextBox6.ReadOnly = true;
            this.byteTextBox6.Size = new System.Drawing.Size(28, 20);
            this.byteTextBox6.TabIndex = 8;
            this.byteTextBox6.TabStop = false;
            this.byteTextBox6.Text = "0";
            this.byteTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // byteTextBox7
            // 
            this.byteTextBox7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.byteTextBox7.BackColor = System.Drawing.Color.Black;
            this.byteTextBox7.ForeColor = System.Drawing.Color.White;
            this.byteTextBox7.Location = new System.Drawing.Point(426, 36);
            this.byteTextBox7.Name = "byteTextBox7";
            this.byteTextBox7.ReadOnly = true;
            this.byteTextBox7.Size = new System.Drawing.Size(28, 20);
            this.byteTextBox7.TabIndex = 9;
            this.byteTextBox7.TabStop = false;
            this.byteTextBox7.Text = "0";
            this.byteTextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // byteTextBox8
            // 
            this.byteTextBox8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.byteTextBox8.BackColor = System.Drawing.Color.Black;
            this.byteTextBox8.ForeColor = System.Drawing.Color.White;
            this.byteTextBox8.Location = new System.Drawing.Point(453, 36);
            this.byteTextBox8.Name = "byteTextBox8";
            this.byteTextBox8.ReadOnly = true;
            this.byteTextBox8.Size = new System.Drawing.Size(28, 20);
            this.byteTextBox8.TabIndex = 10;
            this.byteTextBox8.TabStop = false;
            this.byteTextBox8.Text = "0";
            this.byteTextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // byteTextBox9
            // 
            this.byteTextBox9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.byteTextBox9.BackColor = System.Drawing.Color.Black;
            this.byteTextBox9.ForeColor = System.Drawing.Color.White;
            this.byteTextBox9.Location = new System.Drawing.Point(480, 36);
            this.byteTextBox9.Name = "byteTextBox9";
            this.byteTextBox9.ReadOnly = true;
            this.byteTextBox9.Size = new System.Drawing.Size(28, 20);
            this.byteTextBox9.TabIndex = 11;
            this.byteTextBox9.TabStop = false;
            this.byteTextBox9.Text = "0";
            this.byteTextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // byteTextBox10
            // 
            this.byteTextBox10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.byteTextBox10.BackColor = System.Drawing.Color.Black;
            this.byteTextBox10.ForeColor = System.Drawing.Color.White;
            this.byteTextBox10.Location = new System.Drawing.Point(507, 36);
            this.byteTextBox10.Name = "byteTextBox10";
            this.byteTextBox10.ReadOnly = true;
            this.byteTextBox10.Size = new System.Drawing.Size(28, 20);
            this.byteTextBox10.TabIndex = 12;
            this.byteTextBox10.TabStop = false;
            this.byteTextBox10.Text = "0";
            this.byteTextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // byteTextBox11
            // 
            this.byteTextBox11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.byteTextBox11.BackColor = System.Drawing.Color.Black;
            this.byteTextBox11.ForeColor = System.Drawing.Color.White;
            this.byteTextBox11.Location = new System.Drawing.Point(534, 36);
            this.byteTextBox11.Name = "byteTextBox11";
            this.byteTextBox11.ReadOnly = true;
            this.byteTextBox11.Size = new System.Drawing.Size(28, 20);
            this.byteTextBox11.TabIndex = 13;
            this.byteTextBox11.TabStop = false;
            this.byteTextBox11.Text = "0";
            this.byteTextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // byteTextBox12
            // 
            this.byteTextBox12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.byteTextBox12.BackColor = System.Drawing.Color.Black;
            this.byteTextBox12.ForeColor = System.Drawing.Color.White;
            this.byteTextBox12.Location = new System.Drawing.Point(561, 36);
            this.byteTextBox12.Name = "byteTextBox12";
            this.byteTextBox12.ReadOnly = true;
            this.byteTextBox12.Size = new System.Drawing.Size(28, 20);
            this.byteTextBox12.TabIndex = 14;
            this.byteTextBox12.TabStop = false;
            this.byteTextBox12.Text = "0";
            this.byteTextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // byteTextBox13
            // 
            this.byteTextBox13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.byteTextBox13.BackColor = System.Drawing.Color.Black;
            this.byteTextBox13.ForeColor = System.Drawing.Color.White;
            this.byteTextBox13.Location = new System.Drawing.Point(588, 36);
            this.byteTextBox13.Name = "byteTextBox13";
            this.byteTextBox13.ReadOnly = true;
            this.byteTextBox13.Size = new System.Drawing.Size(28, 20);
            this.byteTextBox13.TabIndex = 15;
            this.byteTextBox13.TabStop = false;
            this.byteTextBox13.Text = "0";
            this.byteTextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // byteTextBox26
            // 
            this.byteTextBox26.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.byteTextBox26.BackColor = System.Drawing.Color.Black;
            this.byteTextBox26.ForeColor = System.Drawing.Color.White;
            this.byteTextBox26.Location = new System.Drawing.Point(939, 36);
            this.byteTextBox26.Name = "byteTextBox26";
            this.byteTextBox26.ReadOnly = true;
            this.byteTextBox26.Size = new System.Drawing.Size(28, 20);
            this.byteTextBox26.TabIndex = 28;
            this.byteTextBox26.TabStop = false;
            this.byteTextBox26.Text = "0";
            this.byteTextBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // byteTextBox25
            // 
            this.byteTextBox25.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.byteTextBox25.BackColor = System.Drawing.Color.Black;
            this.byteTextBox25.ForeColor = System.Drawing.Color.White;
            this.byteTextBox25.Location = new System.Drawing.Point(912, 36);
            this.byteTextBox25.Name = "byteTextBox25";
            this.byteTextBox25.ReadOnly = true;
            this.byteTextBox25.Size = new System.Drawing.Size(28, 20);
            this.byteTextBox25.TabIndex = 27;
            this.byteTextBox25.TabStop = false;
            this.byteTextBox25.Text = "0";
            this.byteTextBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // byteTextBox24
            // 
            this.byteTextBox24.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.byteTextBox24.BackColor = System.Drawing.Color.Black;
            this.byteTextBox24.ForeColor = System.Drawing.Color.White;
            this.byteTextBox24.Location = new System.Drawing.Point(885, 36);
            this.byteTextBox24.Name = "byteTextBox24";
            this.byteTextBox24.ReadOnly = true;
            this.byteTextBox24.Size = new System.Drawing.Size(28, 20);
            this.byteTextBox24.TabIndex = 26;
            this.byteTextBox24.TabStop = false;
            this.byteTextBox24.Text = "0";
            this.byteTextBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // byteTextBox23
            // 
            this.byteTextBox23.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.byteTextBox23.BackColor = System.Drawing.Color.Black;
            this.byteTextBox23.ForeColor = System.Drawing.Color.White;
            this.byteTextBox23.Location = new System.Drawing.Point(858, 36);
            this.byteTextBox23.Name = "byteTextBox23";
            this.byteTextBox23.ReadOnly = true;
            this.byteTextBox23.Size = new System.Drawing.Size(28, 20);
            this.byteTextBox23.TabIndex = 25;
            this.byteTextBox23.TabStop = false;
            this.byteTextBox23.Text = "0";
            this.byteTextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // byteTextBox22
            // 
            this.byteTextBox22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.byteTextBox22.BackColor = System.Drawing.Color.Black;
            this.byteTextBox22.ForeColor = System.Drawing.Color.White;
            this.byteTextBox22.Location = new System.Drawing.Point(831, 36);
            this.byteTextBox22.Name = "byteTextBox22";
            this.byteTextBox22.ReadOnly = true;
            this.byteTextBox22.Size = new System.Drawing.Size(28, 20);
            this.byteTextBox22.TabIndex = 24;
            this.byteTextBox22.TabStop = false;
            this.byteTextBox22.Text = "0";
            this.byteTextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // byteTextBox21
            // 
            this.byteTextBox21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.byteTextBox21.BackColor = System.Drawing.Color.Black;
            this.byteTextBox21.ForeColor = System.Drawing.Color.White;
            this.byteTextBox21.Location = new System.Drawing.Point(804, 36);
            this.byteTextBox21.Name = "byteTextBox21";
            this.byteTextBox21.ReadOnly = true;
            this.byteTextBox21.Size = new System.Drawing.Size(28, 20);
            this.byteTextBox21.TabIndex = 23;
            this.byteTextBox21.TabStop = false;
            this.byteTextBox21.Text = "0";
            this.byteTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // byteTextBox20
            // 
            this.byteTextBox20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.byteTextBox20.BackColor = System.Drawing.Color.Black;
            this.byteTextBox20.ForeColor = System.Drawing.Color.White;
            this.byteTextBox20.Location = new System.Drawing.Point(777, 36);
            this.byteTextBox20.Name = "byteTextBox20";
            this.byteTextBox20.ReadOnly = true;
            this.byteTextBox20.Size = new System.Drawing.Size(28, 20);
            this.byteTextBox20.TabIndex = 22;
            this.byteTextBox20.TabStop = false;
            this.byteTextBox20.Text = "0";
            this.byteTextBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // byteTextBox19
            // 
            this.byteTextBox19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.byteTextBox19.BackColor = System.Drawing.Color.Black;
            this.byteTextBox19.ForeColor = System.Drawing.Color.White;
            this.byteTextBox19.Location = new System.Drawing.Point(750, 36);
            this.byteTextBox19.Name = "byteTextBox19";
            this.byteTextBox19.ReadOnly = true;
            this.byteTextBox19.Size = new System.Drawing.Size(28, 20);
            this.byteTextBox19.TabIndex = 21;
            this.byteTextBox19.TabStop = false;
            this.byteTextBox19.Text = "0";
            this.byteTextBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // byteTextBox18
            // 
            this.byteTextBox18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.byteTextBox18.BackColor = System.Drawing.Color.Black;
            this.byteTextBox18.ForeColor = System.Drawing.Color.White;
            this.byteTextBox18.Location = new System.Drawing.Point(723, 36);
            this.byteTextBox18.Name = "byteTextBox18";
            this.byteTextBox18.ReadOnly = true;
            this.byteTextBox18.Size = new System.Drawing.Size(28, 20);
            this.byteTextBox18.TabIndex = 20;
            this.byteTextBox18.TabStop = false;
            this.byteTextBox18.Text = "0";
            this.byteTextBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // byteTextBox17
            // 
            this.byteTextBox17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.byteTextBox17.BackColor = System.Drawing.Color.Black;
            this.byteTextBox17.ForeColor = System.Drawing.Color.White;
            this.byteTextBox17.Location = new System.Drawing.Point(696, 36);
            this.byteTextBox17.Name = "byteTextBox17";
            this.byteTextBox17.ReadOnly = true;
            this.byteTextBox17.Size = new System.Drawing.Size(28, 20);
            this.byteTextBox17.TabIndex = 19;
            this.byteTextBox17.TabStop = false;
            this.byteTextBox17.Text = "0";
            this.byteTextBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // byteTextBox16
            // 
            this.byteTextBox16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.byteTextBox16.BackColor = System.Drawing.Color.Black;
            this.byteTextBox16.ForeColor = System.Drawing.Color.White;
            this.byteTextBox16.Location = new System.Drawing.Point(669, 36);
            this.byteTextBox16.Name = "byteTextBox16";
            this.byteTextBox16.ReadOnly = true;
            this.byteTextBox16.Size = new System.Drawing.Size(28, 20);
            this.byteTextBox16.TabIndex = 18;
            this.byteTextBox16.TabStop = false;
            this.byteTextBox16.Text = "0";
            this.byteTextBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // byteTextBox15
            // 
            this.byteTextBox15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.byteTextBox15.BackColor = System.Drawing.Color.Black;
            this.byteTextBox15.ForeColor = System.Drawing.Color.White;
            this.byteTextBox15.Location = new System.Drawing.Point(642, 36);
            this.byteTextBox15.Name = "byteTextBox15";
            this.byteTextBox15.ReadOnly = true;
            this.byteTextBox15.Size = new System.Drawing.Size(28, 20);
            this.byteTextBox15.TabIndex = 17;
            this.byteTextBox15.TabStop = false;
            this.byteTextBox15.Text = "0";
            this.byteTextBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // byteTextBox14
            // 
            this.byteTextBox14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.byteTextBox14.BackColor = System.Drawing.Color.Black;
            this.byteTextBox14.ForeColor = System.Drawing.Color.White;
            this.byteTextBox14.Location = new System.Drawing.Point(615, 36);
            this.byteTextBox14.Name = "byteTextBox14";
            this.byteTextBox14.ReadOnly = true;
            this.byteTextBox14.Size = new System.Drawing.Size(28, 20);
            this.byteTextBox14.TabIndex = 16;
            this.byteTextBox14.TabStop = false;
            this.byteTextBox14.Text = "0";
            this.byteTextBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTextBox.BackColor = System.Drawing.Color.White;
            this.outputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox.Location = new System.Drawing.Point(0, 531);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.outputTextBox.Size = new System.Drawing.Size(990, 56);
            this.outputTextBox.TabIndex = 32;
            this.outputTextBox.TabStop = false;
            this.outputTextBox.WordWrap = false;
            // 
            // interpreterTimer
            // 
            this.interpreterTimer.Interval = 1000;
            this.interpreterTimer.Tick += new System.EventHandler(this.interpreterTimer_Tick);
            // 
            // pauseButton
            // 
            this.pauseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pauseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pauseButton.FlatAppearance.BorderSize = 0;
            this.pauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseButton.Location = new System.Drawing.Point(990, 70);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(155, 37);
            this.pauseButton.TabIndex = 33;
            this.pauseButton.Text = "&Pause";
            this.pauseButton.UseVisualStyleBackColor = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 10;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Interpretation Speed (ms)";
            // 
            // interpretationSpeedTextBox
            // 
            this.interpretationSpeedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.interpretationSpeedTextBox.Location = new System.Drawing.Point(178, 36);
            this.interpretationSpeedTextBox.Name = "interpretationSpeedTextBox";
            this.interpretationSpeedTextBox.Size = new System.Drawing.Size(53, 20);
            this.interpretationSpeedTextBox.TabIndex = 35;
            this.interpretationSpeedTextBox.Text = "1000";
            this.interpretationSpeedTextBox.Leave += new System.EventHandler(this.interpretationSpeedTextBox_Leave);
            // 
            // InterpreterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(990, 587);
            this.Controls.Add(this.interpretationSpeedTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.byteTextBox26);
            this.Controls.Add(this.byteTextBox25);
            this.Controls.Add(this.byteTextBox24);
            this.Controls.Add(this.byteTextBox23);
            this.Controls.Add(this.byteTextBox22);
            this.Controls.Add(this.byteTextBox21);
            this.Controls.Add(this.byteTextBox20);
            this.Controls.Add(this.byteTextBox19);
            this.Controls.Add(this.byteTextBox18);
            this.Controls.Add(this.byteTextBox17);
            this.Controls.Add(this.byteTextBox16);
            this.Controls.Add(this.byteTextBox15);
            this.Controls.Add(this.byteTextBox14);
            this.Controls.Add(this.byteTextBox13);
            this.Controls.Add(this.byteTextBox12);
            this.Controls.Add(this.byteTextBox11);
            this.Controls.Add(this.byteTextBox10);
            this.Controls.Add(this.byteTextBox9);
            this.Controls.Add(this.byteTextBox8);
            this.Controls.Add(this.byteTextBox7);
            this.Controls.Add(this.byteTextBox6);
            this.Controls.Add(this.byteTextBox5);
            this.Controls.Add(this.byteTextBox4);
            this.Controls.Add(this.byteTextBox3);
            this.Controls.Add(this.byteTextBox2);
            this.Controls.Add(this.byteTextBox1);
            this.Controls.Add(this.byteTextBox0);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.inputRichTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InterpreterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BF Interpreter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InterpreterForm_FormClosing);
            this.Load += new System.EventHandler(this.InterpreterForm_Load);
            this.Resize += new System.EventHandler(this.InterpreterForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox inputRichTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TextBox byteTextBox0;
        private System.Windows.Forms.TextBox byteTextBox1;
        private System.Windows.Forms.TextBox byteTextBox2;
        private System.Windows.Forms.TextBox byteTextBox3;
        private System.Windows.Forms.TextBox byteTextBox4;
        private System.Windows.Forms.TextBox byteTextBox5;
        private System.Windows.Forms.TextBox byteTextBox6;
        private System.Windows.Forms.TextBox byteTextBox7;
        private System.Windows.Forms.TextBox byteTextBox8;
        private System.Windows.Forms.TextBox byteTextBox9;
        private System.Windows.Forms.TextBox byteTextBox10;
        private System.Windows.Forms.TextBox byteTextBox11;
        private System.Windows.Forms.TextBox byteTextBox12;
        private System.Windows.Forms.TextBox byteTextBox13;
        private System.Windows.Forms.TextBox byteTextBox26;
        private System.Windows.Forms.TextBox byteTextBox25;
        private System.Windows.Forms.TextBox byteTextBox24;
        private System.Windows.Forms.TextBox byteTextBox23;
        private System.Windows.Forms.TextBox byteTextBox22;
        private System.Windows.Forms.TextBox byteTextBox21;
        private System.Windows.Forms.TextBox byteTextBox20;
        private System.Windows.Forms.TextBox byteTextBox19;
        private System.Windows.Forms.TextBox byteTextBox18;
        private System.Windows.Forms.TextBox byteTextBox17;
        private System.Windows.Forms.TextBox byteTextBox16;
        private System.Windows.Forms.TextBox byteTextBox15;
        private System.Windows.Forms.TextBox byteTextBox14;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Timer interpreterTimer;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox interpretationSpeedTextBox;
    }
}

