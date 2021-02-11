
namespace WindowsFormsApp2
{
    partial class Form1
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
            this.termT = new System.Windows.Forms.TextBox();
            this.neTermT = new System.Windows.Forms.TextBox();
            this.CelT = new System.Windows.Forms.TextBox();
            this.CelPrav = new System.Windows.Forms.TextBox();
            this.addTerm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addNeTerm = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.addCel = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.addPravila = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.PravilaT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.StorPrav = new System.Windows.Forms.RadioButton();
            this.StorLev = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.addEmpty = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.labelPrav = new System.Windows.Forms.Label();
            this.labelCel = new System.Windows.Forms.Label();
            this.labelNeTerm = new System.Windows.Forms.Label();
            this.labelTerm = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label15 = new System.Windows.Forms.Label();
            this.textResult = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // termT
            // 
            this.termT.BackColor = System.Drawing.Color.PeachPuff;
            this.termT.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.termT.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.termT.Location = new System.Drawing.Point(16, 13);
            this.termT.MaxLength = 50;
            this.termT.Name = "termT";
            this.termT.Size = new System.Drawing.Size(280, 23);
            this.termT.TabIndex = 0;
            // 
            // neTermT
            // 
            this.neTermT.BackColor = System.Drawing.Color.PeachPuff;
            this.neTermT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.neTermT.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.neTermT.Location = new System.Drawing.Point(16, 12);
            this.neTermT.MaxLength = 50;
            this.neTermT.Name = "neTermT";
            this.neTermT.Size = new System.Drawing.Size(283, 23);
            this.neTermT.TabIndex = 1;
            // 
            // CelT
            // 
            this.CelT.BackColor = System.Drawing.Color.PeachPuff;
            this.CelT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CelT.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CelT.Location = new System.Drawing.Point(24, 25);
            this.CelT.MaxLength = 1;
            this.CelT.Name = "CelT";
            this.CelT.Size = new System.Drawing.Size(52, 23);
            this.CelT.TabIndex = 2;
            // 
            // CelPrav
            // 
            this.CelPrav.BackColor = System.Drawing.Color.PeachPuff;
            this.CelPrav.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CelPrav.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CelPrav.Location = new System.Drawing.Point(11, 38);
            this.CelPrav.MaxLength = 1;
            this.CelPrav.Name = "CelPrav";
            this.CelPrav.Size = new System.Drawing.Size(31, 23);
            this.CelPrav.TabIndex = 3;
            this.CelPrav.TextChanged += new System.EventHandler(this.CelPrav_TextChanged);
            // 
            // addTerm
            // 
            this.addTerm.BackColor = System.Drawing.Color.YellowGreen;
            this.addTerm.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTerm.Location = new System.Drawing.Point(119, 55);
            this.addTerm.Name = "addTerm";
            this.addTerm.Size = new System.Drawing.Size(75, 23);
            this.addTerm.TabIndex = 4;
            this.addTerm.Text = "Добавить";
            this.addTerm.UseVisualStyleBackColor = false;
            this.addTerm.Click += new System.EventHandler(this.addTerm_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(116, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addNeTerm
            // 
            this.addNeTerm.BackColor = System.Drawing.Color.YellowGreen;
            this.addNeTerm.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNeTerm.Location = new System.Drawing.Point(119, 54);
            this.addNeTerm.Name = "addNeTerm";
            this.addNeTerm.Size = new System.Drawing.Size(75, 23);
            this.addNeTerm.TabIndex = 7;
            this.addNeTerm.Text = "Добавить";
            this.addNeTerm.UseVisualStyleBackColor = false;
            this.addNeTerm.Click += new System.EventHandler(this.addNeTerm_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(116, 149);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // addCel
            // 
            this.addCel.BackColor = System.Drawing.Color.YellowGreen;
            this.addCel.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCel.Location = new System.Drawing.Point(13, 76);
            this.addCel.Name = "addCel";
            this.addCel.Size = new System.Drawing.Size(75, 23);
            this.addCel.TabIndex = 9;
            this.addCel.Text = "Добавить";
            this.addCel.UseVisualStyleBackColor = false;
            this.addCel.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Crimson;
            this.button6.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(237, 273);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // addPravila
            // 
            this.addPravila.BackColor = System.Drawing.Color.YellowGreen;
            this.addPravila.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPravila.Location = new System.Drawing.Point(60, 76);
            this.addPravila.Name = "addPravila";
            this.addPravila.Size = new System.Drawing.Size(75, 23);
            this.addPravila.TabIndex = 11;
            this.addPravila.Text = "Добавить";
            this.addPravila.UseVisualStyleBackColor = false;
            this.addPravila.Click += new System.EventHandler(this.addPravila_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Crimson;
            this.button8.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(90, 349);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 10;
            this.button8.Text = "Удалить";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // PravilaT
            // 
            this.PravilaT.BackColor = System.Drawing.Color.PeachPuff;
            this.PravilaT.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PravilaT.Location = new System.Drawing.Point(48, 38);
            this.PravilaT.Name = "PravilaT";
            this.PravilaT.Size = new System.Drawing.Size(141, 23);
            this.PravilaT.TabIndex = 26;
            this.PravilaT.TextChanged += new System.EventHandler(this.PravilaT_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ввод терминальных символов через запятую";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 453);
            this.panel1.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(141, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "Ввод";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.label12);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Controls.Add(this.numericUpDown2);
            this.panel8.Controls.Add(this.numericUpDown1);
            this.panel8.Location = new System.Drawing.Point(129, 378);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 32);
            this.panel8.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(99, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Макс.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Мин.";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(136, 5);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown2.TabIndex = 16;
            this.numericUpDown2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(36, 5);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.StorPrav);
            this.panel7.Controls.Add(this.StorLev);
            this.panel7.Location = new System.Drawing.Point(13, 334);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(110, 76);
            this.panel7.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Выбор выхода";
            // 
            // StorPrav
            // 
            this.StorPrav.AutoSize = true;
            this.StorPrav.Location = new System.Drawing.Point(3, 43);
            this.StorPrav.Name = "StorPrav";
            this.StorPrav.Size = new System.Drawing.Size(110, 17);
            this.StorPrav.TabIndex = 1;
            this.StorPrav.Text = "Правосторонний";
            this.StorPrav.UseVisualStyleBackColor = true;
            this.StorPrav.CheckedChanged += new System.EventHandler(this.button5_Click);
            // 
            // StorLev
            // 
            this.StorLev.AutoSize = true;
            this.StorLev.Checked = true;
            this.StorLev.Location = new System.Drawing.Point(3, 20);
            this.StorLev.Name = "StorLev";
            this.StorLev.Size = new System.Drawing.Size(104, 17);
            this.StorLev.TabIndex = 0;
            this.StorLev.TabStop = true;
            this.StorLev.Text = "Левосторонний";
            this.StorLev.UseVisualStyleBackColor = true;
            this.StorLev.CheckedChanged += new System.EventHandler(this.StorLev_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.termT);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.addTerm);
            this.panel2.Location = new System.Drawing.Point(9, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 86);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.neTermT);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.addNeTerm);
            this.panel3.Location = new System.Drawing.Point(9, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 86);
            this.panel3.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ввод нетерминальных символов через запятую";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.CelT);
            this.panel4.Controls.Add(this.addCel);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(13, 212);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(110, 116);
            this.panel4.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Целевой символ";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.addEmpty);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.addPravila);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.CelPrav);
            this.panel5.Controls.Add(this.PravilaT);
            this.panel5.Location = new System.Drawing.Point(129, 212);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 160);
            this.panel5.TabIndex = 17;
            // 
            // addEmpty
            // 
            this.addEmpty.BackColor = System.Drawing.Color.MediumPurple;
            this.addEmpty.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEmpty.Location = new System.Drawing.Point(14, 105);
            this.addEmpty.Name = "addEmpty";
            this.addEmpty.Size = new System.Drawing.Size(165, 27);
            this.addEmpty.TabIndex = 16;
            this.addEmpty.Text = "Добавить пустое правило";
            this.addEmpty.UseVisualStyleBackColor = false;
            this.addEmpty.Click += new System.EventHandler(this.addEmpty_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Символ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Правила";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.button11);
            this.panel6.Controls.Add(this.button4);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.button8);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.button9);
            this.panel6.Controls.Add(this.labelPrav);
            this.panel6.Controls.Add(this.button6);
            this.panel6.Controls.Add(this.labelCel);
            this.panel6.Controls.Add(this.labelNeTerm);
            this.panel6.Controls.Add(this.labelTerm);
            this.panel6.Location = new System.Drawing.Point(357, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(313, 453);
            this.panel6.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(234, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 58);
            this.button1.TabIndex = 20;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.PowderBlue;
            this.button11.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.Location = new System.Drawing.Point(117, 378);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(114, 58);
            this.button11.TabIndex = 19;
            this.button11.Text = "Сгенерировать";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(115, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "Проверка";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Yellow;
            this.button9.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(13, 378);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(98, 58);
            this.button9.TabIndex = 17;
            this.button9.Text = "Подтвердить";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // labelPrav
            // 
            this.labelPrav.BackColor = System.Drawing.Color.Silver;
            this.labelPrav.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPrav.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrav.Location = new System.Drawing.Point(13, 192);
            this.labelPrav.Name = "labelPrav";
            this.labelPrav.Size = new System.Drawing.Size(218, 153);
            this.labelPrav.TabIndex = 3;
            // 
            // labelCel
            // 
            this.labelCel.BackColor = System.Drawing.Color.Silver;
            this.labelCel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCel.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCel.Location = new System.Drawing.Point(250, 221);
            this.labelCel.Name = "labelCel";
            this.labelCel.Size = new System.Drawing.Size(41, 40);
            this.labelCel.TabIndex = 2;
            this.labelCel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNeTerm
            // 
            this.labelNeTerm.BackColor = System.Drawing.Color.Silver;
            this.labelNeTerm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNeTerm.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNeTerm.Location = new System.Drawing.Point(13, 97);
            this.labelNeTerm.Name = "labelNeTerm";
            this.labelNeTerm.Size = new System.Drawing.Size(265, 44);
            this.labelNeTerm.TabIndex = 1;
            // 
            // labelTerm
            // 
            this.labelTerm.BackColor = System.Drawing.Color.Silver;
            this.labelTerm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTerm.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTerm.Location = new System.Drawing.Point(13, 29);
            this.labelTerm.Name = "labelTerm";
            this.labelTerm.Size = new System.Drawing.Size(265, 39);
            this.labelTerm.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.AutoScroll = true;
            this.panel9.Controls.Add(this.progressBar1);
            this.panel9.Controls.Add(this.label15);
            this.panel9.Controls.Add(this.textResult);
            this.panel9.Location = new System.Drawing.Point(676, 12);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(319, 453);
            this.panel9.TabIndex = 16;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(196, 440);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 10);
            this.progressBar1.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(120, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 20);
            this.label15.TabIndex = 20;
            this.label15.Text = "Результат";
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(3, 29);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textResult.Size = new System.Drawing.Size(313, 421);
            this.textResult.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1007, 485);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox termT;
        private System.Windows.Forms.TextBox neTermT;
        private System.Windows.Forms.TextBox CelT;
        private System.Windows.Forms.TextBox CelPrav;
        private System.Windows.Forms.Button addTerm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addNeTerm;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button addCel;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button addPravila;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox PravilaT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton StorPrav;
        private System.Windows.Forms.RadioButton StorLev;
        private System.Windows.Forms.Button addEmpty;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label labelPrav;
        private System.Windows.Forms.Label labelCel;
        private System.Windows.Forms.Label labelNeTerm;
        private System.Windows.Forms.Label labelTerm;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

