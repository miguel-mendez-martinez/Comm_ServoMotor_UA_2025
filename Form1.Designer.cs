namespace Comm_ServoMotor_2_UA_2025
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelConectado = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IPtextbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PowerLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelError = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.VelMovVEL = new System.Windows.Forms.NumericUpDown();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.PosMovABS = new System.Windows.Forms.NumericUpDown();
            this.VelMovABS = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.PosMovREL = new System.Windows.Forms.NumericUpDown();
            this.VelMovREL = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.VelMovJOG = new System.Windows.Forms.NumericUpDown();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.ModeMovHOME = new System.Windows.Forms.NumericUpDown();
            this.VelMovHOME = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.labelPosicion = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VelMovVEL)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PosMovABS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelMovABS)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PosMovREL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelMovREL)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VelMovJOG)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModeMovHOME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelMovHOME)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(204, 32);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(78, 31);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Conectarse";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 52);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelConectado);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IPtextbox);
            this.groupBox1.Controls.Add(this.ConnectButton);
            this.groupBox1.Location = new System.Drawing.Point(21, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 83);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conexión";
            // 
            // labelConectado
            // 
            this.labelConectado.AutoSize = true;
            this.labelConectado.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelConectado.Location = new System.Drawing.Point(50, 61);
            this.labelConectado.Name = "labelConectado";
            this.labelConectado.Size = new System.Drawing.Size(80, 13);
            this.labelConectado.TabIndex = 5;
            this.labelConectado.Text = "CONECTADO!!";
            this.labelConectado.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(301, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "Desconectarse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dirección IP";
            // 
            // IPtextbox
            // 
            this.IPtextbox.Location = new System.Drawing.Point(47, 38);
            this.IPtextbox.Name = "IPtextbox";
            this.IPtextbox.Size = new System.Drawing.Size(134, 20);
            this.IPtextbox.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button12);
            this.groupBox2.Controls.Add(this.PowerLabel);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(450, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 83);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Potencia";
            // 
            // PowerLabel
            // 
            this.PowerLabel.AutoSize = true;
            this.PowerLabel.BackColor = System.Drawing.Color.Red;
            this.PowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PowerLabel.Location = new System.Drawing.Point(239, 33);
            this.PowerLabel.Name = "PowerLabel";
            this.PowerLabel.Size = new System.Drawing.Size(52, 25);
            this.PowerLabel.TabIndex = 3;
            this.PowerLabel.Text = "OFF";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(669, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 49);
            this.button3.TabIndex = 1;
            this.button3.Text = "RESET";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(19, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 35);
            this.button4.TabIndex = 0;
            this.button4.Text = "ON";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelError);
            this.groupBox3.Location = new System.Drawing.Point(812, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 83);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Error";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.labelError.Location = new System.Drawing.Point(25, 25);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 39);
            this.labelError.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.VelMovVEL);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(718, 345);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(239, 141);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Velocidad";
            // 
            // VelMovVEL
            // 
            this.VelMovVEL.Location = new System.Drawing.Point(21, 58);
            this.VelMovVEL.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.VelMovVEL.Name = "VelMovVEL";
            this.VelMovVEL.Size = new System.Drawing.Size(149, 20);
            this.VelMovVEL.TabIndex = 7;
            this.VelMovVEL.ValueChanged += new System.EventHandler(this.textBoxVelocidad_Leave);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(128, 91);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 31);
            this.button6.TabIndex = 5;
            this.button6.Text = "STOP";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(15, 91);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 31);
            this.button5.TabIndex = 5;
            this.button5.Text = "RUN";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Velocidad (mm)";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.PosMovABS);
            this.groupBox5.Controls.Add(this.VelMovABS);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.button7);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(50, 173);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(239, 141);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Movimiento Absoluto";
            // 
            // PosMovABS
            // 
            this.PosMovABS.Location = new System.Drawing.Point(24, 104);
            this.PosMovABS.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PosMovABS.Name = "PosMovABS";
            this.PosMovABS.Size = new System.Drawing.Size(95, 20);
            this.PosMovABS.TabIndex = 10;
            this.PosMovABS.ValueChanged += new System.EventHandler(this.PosMovABS_ValueChanged);
            // 
            // VelMovABS
            // 
            this.VelMovABS.Location = new System.Drawing.Point(21, 54);
            this.VelMovABS.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.VelMovABS.Name = "VelMovABS";
            this.VelMovABS.Size = new System.Drawing.Size(95, 20);
            this.VelMovABS.TabIndex = 9;
            this.VelMovABS.ValueChanged += new System.EventHandler(this.VelMovABS_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Posicion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "STOP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(146, 47);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(78, 31);
            this.button7.TabIndex = 5;
            this.button7.Text = "RUN";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Velocidad";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.PosMovREL);
            this.groupBox6.Controls.Add(this.VelMovREL);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.button8);
            this.groupBox6.Controls.Add(this.button9);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(50, 345);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(239, 141);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Movimiento Relativo";
            // 
            // PosMovREL
            // 
            this.PosMovREL.Location = new System.Drawing.Point(21, 104);
            this.PosMovREL.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PosMovREL.Name = "PosMovREL";
            this.PosMovREL.Size = new System.Drawing.Size(95, 20);
            this.PosMovREL.TabIndex = 12;
            this.PosMovREL.ValueChanged += new System.EventHandler(this.PosMovREL_ValueChanged);
            // 
            // VelMovREL
            // 
            this.VelMovREL.Location = new System.Drawing.Point(21, 54);
            this.VelMovREL.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.VelMovREL.Name = "VelMovREL";
            this.VelMovREL.Size = new System.Drawing.Size(95, 20);
            this.VelMovREL.TabIndex = 11;
            this.VelMovREL.ValueChanged += new System.EventHandler(this.VelMovREL_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Posicion";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(146, 97);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(78, 31);
            this.button8.TabIndex = 5;
            this.button8.Text = "STOP";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(146, 47);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(78, 31);
            this.button9.TabIndex = 5;
            this.button9.Text = "RUN";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Velocidad";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.VelMovJOG);
            this.groupBox7.Controls.Add(this.button10);
            this.groupBox7.Controls.Add(this.button11);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Location = new System.Drawing.Point(381, 173);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(239, 141);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Movimiento Jog";
            // 
            // VelMovJOG
            // 
            this.VelMovJOG.Location = new System.Drawing.Point(21, 75);
            this.VelMovJOG.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.VelMovJOG.Name = "VelMovJOG";
            this.VelMovJOG.Size = new System.Drawing.Size(95, 20);
            this.VelMovJOG.TabIndex = 13;
            this.VelMovJOG.ValueChanged += new System.EventHandler(this.VelMovJOG_ValueChanged);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(146, 97);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(78, 31);
            this.button10.TabIndex = 5;
            this.button10.Text = "REVERSE";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button10_MouseDown);
            this.button10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button10_MouseUp);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(146, 47);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(78, 31);
            this.button11.TabIndex = 5;
            this.button11.Text = "FORWORD";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button11_MouseDown);
            this.button11.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button11_MouseUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Velocidad";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.ModeMovHOME);
            this.groupBox8.Controls.Add(this.VelMovHOME);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.button13);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Location = new System.Drawing.Point(381, 345);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(239, 141);
            this.groupBox8.TabIndex = 11;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Home";
            // 
            // ModeMovHOME
            // 
            this.ModeMovHOME.Location = new System.Drawing.Point(21, 107);
            this.ModeMovHOME.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ModeMovHOME.Name = "ModeMovHOME";
            this.ModeMovHOME.Size = new System.Drawing.Size(95, 20);
            this.ModeMovHOME.TabIndex = 16;
            this.ModeMovHOME.ValueChanged += new System.EventHandler(this.ModeMovHOME_ValueChanged);
            // 
            // VelMovHOME
            // 
            this.VelMovHOME.Location = new System.Drawing.Point(21, 54);
            this.VelMovHOME.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.VelMovHOME.Name = "VelMovHOME";
            this.VelMovHOME.Size = new System.Drawing.Size(95, 20);
            this.VelMovHOME.TabIndex = 15;
            this.VelMovHOME.ValueChanged += new System.EventHandler(this.VelMovHOME_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Modo";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(146, 73);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(78, 31);
            this.button13.TabIndex = 5;
            this.button13.Text = "HOME";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Velocidad";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.labelPosicion);
            this.groupBox9.Location = new System.Drawing.Point(812, 173);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(187, 104);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Posicion Actual";
            // 
            // labelPosicion
            // 
            this.labelPosicion.AutoSize = true;
            this.labelPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.labelPosicion.Location = new System.Drawing.Point(25, 25);
            this.labelPosicion.Name = "labelPosicion";
            this.labelPosicion.Size = new System.Drawing.Size(0, 39);
            this.labelPosicion.TabIndex = 0;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(117, 30);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(81, 35);
            this.button12.TabIndex = 4;
            this.button12.Text = "OFF";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 547);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VelMovVEL)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PosMovABS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelMovABS)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PosMovREL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelMovREL)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VelMovJOG)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModeMovHOME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VelMovHOME)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox IPtextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label labelConectado;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label PowerLabel;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label labelPosicion;
        private System.Windows.Forms.NumericUpDown VelMovVEL;
        private System.Windows.Forms.NumericUpDown PosMovABS;
        private System.Windows.Forms.NumericUpDown VelMovABS;
        private System.Windows.Forms.NumericUpDown PosMovREL;
        private System.Windows.Forms.NumericUpDown VelMovREL;
        private System.Windows.Forms.NumericUpDown VelMovJOG;
        private System.Windows.Forms.NumericUpDown ModeMovHOME;
        private System.Windows.Forms.NumericUpDown VelMovHOME;
        private System.Windows.Forms.Button button12;
    }
}

