namespace WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox_OO1_X = new TextBox();
            textBox_OO1_Y = new TextBox();
            textBox_OO2_Y = new TextBox();
            textBox_OO2_X = new TextBox();
            label3 = new Label();
            textBox_T_Y = new TextBox();
            textBox_T_X = new TextBox();
            label4 = new Label();
            textBox7 = new TextBox();
            textBox_BPLA_X = new TextBox();
            label5 = new Label();
            textBox_BPLA_Y = new TextBox();
            textBox_BPLA_Z = new TextBox();
            buttonStart = new Button();
            textBox_Input_OO2_Y = new TextBox();
            textBox_Input_OO2_X = new TextBox();
            label6 = new Label();
            textBox_Input_OO1_Y = new TextBox();
            textBox_Input_OO1_X = new TextBox();
            label7 = new Label();
            textBox_Input_L1 = new TextBox();
            label8 = new Label();
            textBox_Input_L2 = new TextBox();
            label9 = new Label();
            textBox_Input_L3 = new TextBox();
            label10 = new Label();
            textBox_Input_a = new TextBox();
            label11 = new Label();
            textBox_Input_aa = new TextBox();
            label12 = new Label();
            label13 = new Label();
            buttonMath = new Button();
            label14 = new Label();
            textBox_Rez_BPLA_Z = new TextBox();
            textBox_Rez_BPLA_Y = new TextBox();
            textBox_Rez_T_Y = new TextBox();
            textBox_Rez_T_X = new TextBox();
            label15 = new Label();
            textBox24 = new TextBox();
            textBox_Rez_BPLA_X = new TextBox();
            label16 = new Label();
            textBox_Input_сc = new TextBox();
            label17 = new Label();
            textBox_dс = new TextBox();
            textBox_daa = new TextBox();
            textBox_da = new TextBox();
            textBox_dL3 = new TextBox();
            label21 = new Label();
            textBox_dL2 = new TextBox();
            textBox_dL1 = new TextBox();
            textBox_Rez_D_BPLA_Z = new TextBox();
            textBox_Rez_D_BPLA_Y = new TextBox();
            textBox_Rez_D_T_Y = new TextBox();
            textBox_Rez_D_T_X = new TextBox();
            label24 = new Label();
            textBox12 = new TextBox();
            textBox_Rez_D_BPLA_X = new TextBox();
            label25 = new Label();
            textBox_Rez_BPLA = new TextBox();
            label26 = new Label();
            label27 = new Label();
            textBox_Rez_T = new TextBox();
            textBox_OO1_Z = new TextBox();
            textBox_OO2_Z = new TextBox();
            textBox_T_Z = new TextBox();
            textBox_dbb = new TextBox();
            textBox_db = new TextBox();
            textBox_Input_bb = new TextBox();
            label18 = new Label();
            textBox_Input_b = new TextBox();
            label19 = new Label();
            textBox_Rez_T_Z = new TextBox();
            textBox_Rez_D_T_Z = new TextBox();
            label20 = new Label();
            label22 = new Label();
            label23 = new Label();
            label29 = new Label();
            label31 = new Label();
            label33 = new Label();
            label35 = new Label();
            label36 = new Label();
            textBoxBPLA_TEST_H = new TextBox();
            label28 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 1);
            label1.Name = "label1";
            label1.Size = new Size(149, 17);
            label1.TabIndex = 0;
            label1.Text = "Координаты по ГНСС:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(14, 24);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "ОО1:";
            label2.Click += label2_Click;
            // 
            // textBox_OO1_X
            // 
            textBox_OO1_X.Location = new Point(52, 22);
            textBox_OO1_X.Margin = new Padding(3, 2, 3, 2);
            textBox_OO1_X.Name = "textBox_OO1_X";
            textBox_OO1_X.PlaceholderText = "B";
            textBox_OO1_X.Size = new Size(132, 23);
            textBox_OO1_X.TabIndex = 2;
            textBox_OO1_X.Tag = "";
            // 
            // textBox_OO1_Y
            // 
            textBox_OO1_Y.Location = new Point(189, 22);
            textBox_OO1_Y.Margin = new Padding(3, 2, 3, 2);
            textBox_OO1_Y.Name = "textBox_OO1_Y";
            textBox_OO1_Y.PlaceholderText = "L";
            textBox_OO1_Y.Size = new Size(132, 23);
            textBox_OO1_Y.TabIndex = 3;
            // 
            // textBox_OO2_Y
            // 
            textBox_OO2_Y.Location = new Point(648, 22);
            textBox_OO2_Y.Margin = new Padding(3, 2, 3, 2);
            textBox_OO2_Y.Name = "textBox_OO2_Y";
            textBox_OO2_Y.PlaceholderText = "L";
            textBox_OO2_Y.Size = new Size(132, 23);
            textBox_OO2_Y.TabIndex = 6;
            // 
            // textBox_OO2_X
            // 
            textBox_OO2_X.Location = new Point(512, 22);
            textBox_OO2_X.Margin = new Padding(3, 2, 3, 2);
            textBox_OO2_X.Name = "textBox_OO2_X";
            textBox_OO2_X.PlaceholderText = "B";
            textBox_OO2_X.Size = new Size(132, 23);
            textBox_OO2_X.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(473, 24);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 4;
            label3.Text = "ОО2:";
            label3.Click += label3_Click;
            // 
            // textBox_T_Y
            // 
            textBox_T_Y.Location = new Point(648, 46);
            textBox_T_Y.Margin = new Padding(3, 2, 3, 2);
            textBox_T_Y.Name = "textBox_T_Y";
            textBox_T_Y.PlaceholderText = "L";
            textBox_T_Y.Size = new Size(132, 23);
            textBox_T_Y.TabIndex = 12;
            // 
            // textBox_T_X
            // 
            textBox_T_X.Location = new Point(512, 46);
            textBox_T_X.Margin = new Padding(3, 2, 3, 2);
            textBox_T_X.Name = "textBox_T_X";
            textBox_T_X.PlaceholderText = "B";
            textBox_T_X.Size = new Size(132, 23);
            textBox_T_X.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point(458, 51);
            label4.Name = "label4";
            label4.Size = new Size(50, 13);
            label4.TabIndex = 10;
            label4.Text = "ОБЪЕКТ:";
            label4.Click += label4_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(163, 46);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(0, 23);
            textBox7.TabIndex = 9;
            // 
            // textBox_BPLA_X
            // 
            textBox_BPLA_X.Location = new Point(52, 46);
            textBox_BPLA_X.Margin = new Padding(3, 2, 3, 2);
            textBox_BPLA_X.Name = "textBox_BPLA_X";
            textBox_BPLA_X.PlaceholderText = "B";
            textBox_BPLA_X.Size = new Size(132, 23);
            textBox_BPLA_X.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label5.Location = new Point(5, 49);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 7;
            label5.Text = "БПЛА:";
            label5.Click += label5_Click;
            // 
            // textBox_BPLA_Y
            // 
            textBox_BPLA_Y.Location = new Point(189, 46);
            textBox_BPLA_Y.Margin = new Padding(3, 2, 3, 2);
            textBox_BPLA_Y.Name = "textBox_BPLA_Y";
            textBox_BPLA_Y.PlaceholderText = "L";
            textBox_BPLA_Y.Size = new Size(132, 23);
            textBox_BPLA_Y.TabIndex = 13;
            // 
            // textBox_BPLA_Z
            // 
            textBox_BPLA_Z.Location = new Point(326, 46);
            textBox_BPLA_Z.Margin = new Padding(3, 2, 3, 2);
            textBox_BPLA_Z.Name = "textBox_BPLA_Z";
            textBox_BPLA_Z.PlaceholderText = "H";
            textBox_BPLA_Z.Size = new Size(132, 23);
            textBox_BPLA_Z.TabIndex = 14;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(14, 71);
            buttonStart.Margin = new Padding(3, 2, 3, 2);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(906, 22);
            buttonStart.TabIndex = 15;
            buttonStart.Text = "Заполнить";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += button1_Click;
            // 
            // textBox_Input_OO2_Y
            // 
            textBox_Input_OO2_Y.Location = new Point(785, 116);
            textBox_Input_OO2_Y.Margin = new Padding(3, 2, 3, 2);
            textBox_Input_OO2_Y.Name = "textBox_Input_OO2_Y";
            textBox_Input_OO2_Y.PlaceholderText = "L";
            textBox_Input_OO2_Y.Size = new Size(132, 23);
            textBox_Input_OO2_Y.TabIndex = 21;
            // 
            // textBox_Input_OO2_X
            // 
            textBox_Input_OO2_X.Location = new Point(512, 116);
            textBox_Input_OO2_X.Margin = new Padding(3, 2, 3, 2);
            textBox_Input_OO2_X.Name = "textBox_Input_OO2_X";
            textBox_Input_OO2_X.PlaceholderText = "B";
            textBox_Input_OO2_X.Size = new Size(132, 23);
            textBox_Input_OO2_X.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label6.Location = new Point(473, 118);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 19;
            label6.Text = "ОО2:";
            label6.Click += label6_Click;
            // 
            // textBox_Input_OO1_Y
            // 
            textBox_Input_OO1_Y.Location = new Point(325, 117);
            textBox_Input_OO1_Y.Margin = new Padding(3, 2, 3, 2);
            textBox_Input_OO1_Y.Name = "textBox_Input_OO1_Y";
            textBox_Input_OO1_Y.PlaceholderText = "L";
            textBox_Input_OO1_Y.Size = new Size(132, 23);
            textBox_Input_OO1_Y.TabIndex = 18;
            // 
            // textBox_Input_OO1_X
            // 
            textBox_Input_OO1_X.Location = new Point(52, 116);
            textBox_Input_OO1_X.Margin = new Padding(3, 2, 3, 2);
            textBox_Input_OO1_X.Name = "textBox_Input_OO1_X";
            textBox_Input_OO1_X.PlaceholderText = "B";
            textBox_Input_OO1_X.Size = new Size(132, 23);
            textBox_Input_OO1_X.TabIndex = 17;
            textBox_Input_OO1_X.Tag = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label7.Location = new Point(10, 120);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 16;
            label7.Text = "ОО1:";
            label7.Click += label7_Click;
            // 
            // textBox_Input_L1
            // 
            textBox_Input_L1.Location = new Point(52, 142);
            textBox_Input_L1.Margin = new Padding(3, 2, 3, 2);
            textBox_Input_L1.Name = "textBox_Input_L1";
            textBox_Input_L1.PlaceholderText = "метры";
            textBox_Input_L1.Size = new Size(132, 23);
            textBox_Input_L1.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label8.Location = new Point(14, 142);
            label8.Name = "label8";
            label8.Size = new Size(22, 15);
            label8.TabIndex = 22;
            label8.Text = "L1:";
            label8.Click += label8_Click;
            // 
            // textBox_Input_L2
            // 
            textBox_Input_L2.Location = new Point(52, 169);
            textBox_Input_L2.Margin = new Padding(3, 2, 3, 2);
            textBox_Input_L2.Name = "textBox_Input_L2";
            textBox_Input_L2.PlaceholderText = "метры";
            textBox_Input_L2.Size = new Size(132, 23);
            textBox_Input_L2.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label9.Location = new Point(14, 169);
            label9.Name = "label9";
            label9.Size = new Size(22, 15);
            label9.TabIndex = 24;
            label9.Text = "L2:";
            label9.Click += label9_Click;
            // 
            // textBox_Input_L3
            // 
            textBox_Input_L3.Location = new Point(52, 195);
            textBox_Input_L3.Margin = new Padding(3, 2, 3, 2);
            textBox_Input_L3.Name = "textBox_Input_L3";
            textBox_Input_L3.PlaceholderText = "метры";
            textBox_Input_L3.Size = new Size(132, 23);
            textBox_Input_L3.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label10.Location = new Point(14, 195);
            label10.Name = "label10";
            label10.Size = new Size(22, 15);
            label10.TabIndex = 26;
            label10.Text = "L3:";
            label10.Click += label10_Click;
            // 
            // textBox_Input_a
            // 
            textBox_Input_a.Location = new Point(512, 142);
            textBox_Input_a.Margin = new Padding(3, 2, 3, 2);
            textBox_Input_a.Name = "textBox_Input_a";
            textBox_Input_a.PlaceholderText = "градусы";
            textBox_Input_a.Size = new Size(132, 23);
            textBox_Input_a.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label11.Location = new Point(484, 142);
            label11.Name = "label11";
            label11.Size = new Size(24, 15);
            label11.TabIndex = 28;
            label11.Text = "∠a:";
            label11.Click += label11_Click;
            // 
            // textBox_Input_aa
            // 
            textBox_Input_aa.Location = new Point(512, 169);
            textBox_Input_aa.Margin = new Padding(3, 2, 3, 2);
            textBox_Input_aa.Name = "textBox_Input_aa";
            textBox_Input_aa.PlaceholderText = "градусы";
            textBox_Input_aa.Size = new Size(132, 23);
            textBox_Input_aa.TabIndex = 31;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label12.Location = new Point(482, 169);
            label12.Name = "label12";
            label12.Size = new Size(26, 15);
            label12.TabIndex = 30;
            label12.Text = "∠A:";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(14, 95);
            label13.Name = "label13";
            label13.Size = new Size(137, 17);
            label13.TabIndex = 32;
            label13.Text = "Данные измерений:";
            label13.Click += label13_Click;
            // 
            // buttonMath
            // 
            buttonMath.Location = new Point(10, 296);
            buttonMath.Margin = new Padding(3, 2, 3, 2);
            buttonMath.Name = "buttonMath";
            buttonMath.Size = new Size(906, 22);
            buttonMath.TabIndex = 33;
            buttonMath.Text = "Найти";
            buttonMath.UseVisualStyleBackColor = true;
            buttonMath.Click += button2_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(10, 320);
            label14.Name = "label14";
            label14.Size = new Size(137, 17);
            label14.TabIndex = 34;
            label14.Text = "Результаты расчёта:";
            // 
            // textBox_Rez_BPLA_Z
            // 
            textBox_Rez_BPLA_Z.Location = new Point(326, 337);
            textBox_Rez_BPLA_Z.Margin = new Padding(3, 2, 3, 2);
            textBox_Rez_BPLA_Z.Name = "textBox_Rez_BPLA_Z";
            textBox_Rez_BPLA_Z.PlaceholderText = "H";
            textBox_Rez_BPLA_Z.ReadOnly = true;
            textBox_Rez_BPLA_Z.Size = new Size(132, 23);
            textBox_Rez_BPLA_Z.TabIndex = 42;
            // 
            // textBox_Rez_BPLA_Y
            // 
            textBox_Rez_BPLA_Y.Location = new Point(189, 337);
            textBox_Rez_BPLA_Y.Margin = new Padding(3, 2, 3, 2);
            textBox_Rez_BPLA_Y.Name = "textBox_Rez_BPLA_Y";
            textBox_Rez_BPLA_Y.PlaceholderText = "L";
            textBox_Rez_BPLA_Y.ReadOnly = true;
            textBox_Rez_BPLA_Y.Size = new Size(132, 23);
            textBox_Rez_BPLA_Y.TabIndex = 41;
            // 
            // textBox_Rez_T_Y
            // 
            textBox_Rez_T_Y.Location = new Point(648, 337);
            textBox_Rez_T_Y.Margin = new Padding(3, 2, 3, 2);
            textBox_Rez_T_Y.Name = "textBox_Rez_T_Y";
            textBox_Rez_T_Y.PlaceholderText = "L";
            textBox_Rez_T_Y.ReadOnly = true;
            textBox_Rez_T_Y.Size = new Size(132, 23);
            textBox_Rez_T_Y.TabIndex = 40;
            // 
            // textBox_Rez_T_X
            // 
            textBox_Rez_T_X.Location = new Point(512, 337);
            textBox_Rez_T_X.Margin = new Padding(3, 2, 3, 2);
            textBox_Rez_T_X.Name = "textBox_Rez_T_X";
            textBox_Rez_T_X.PlaceholderText = "B";
            textBox_Rez_T_X.ReadOnly = true;
            textBox_Rez_T_X.Size = new Size(132, 23);
            textBox_Rez_T_X.TabIndex = 39;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(463, 347);
            label15.Name = "label15";
            label15.Size = new Size(50, 13);
            label15.TabIndex = 38;
            label15.Text = "ОБЪЕКТ:";
            // 
            // textBox24
            // 
            textBox24.Location = new Point(179, 337);
            textBox24.Margin = new Padding(3, 2, 3, 2);
            textBox24.Name = "textBox24";
            textBox24.Size = new Size(0, 23);
            textBox24.TabIndex = 37;
            // 
            // textBox_Rez_BPLA_X
            // 
            textBox_Rez_BPLA_X.Location = new Point(52, 337);
            textBox_Rez_BPLA_X.Margin = new Padding(3, 2, 3, 2);
            textBox_Rez_BPLA_X.Name = "textBox_Rez_BPLA_X";
            textBox_Rez_BPLA_X.PlaceholderText = "B";
            textBox_Rez_BPLA_X.ReadOnly = true;
            textBox_Rez_BPLA_X.Size = new Size(132, 23);
            textBox_Rez_BPLA_X.TabIndex = 36;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(5, 340);
            label16.Name = "label16";
            label16.Size = new Size(42, 15);
            label16.TabIndex = 35;
            label16.Text = "БПЛА:";
            // 
            // textBox_Input_сc
            // 
            textBox_Input_сc.Location = new Point(52, 221);
            textBox_Input_сc.Margin = new Padding(3, 2, 3, 2);
            textBox_Input_сc.Name = "textBox_Input_сc";
            textBox_Input_сc.PlaceholderText = "градусы";
            textBox_Input_сc.Size = new Size(132, 23);
            textBox_Input_сc.TabIndex = 43;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label17.Location = new Point(13, 221);
            label17.Name = "label17";
            label17.Size = new Size(26, 15);
            label17.TabIndex = 44;
            label17.Text = "∠C:";
            label17.Click += label17_Click;
            // 
            // textBox_dс
            // 
            textBox_dс.Location = new Point(326, 221);
            textBox_dс.Margin = new Padding(3, 2, 3, 2);
            textBox_dс.Name = "textBox_dс";
            textBox_dс.PlaceholderText = "абсолют";
            textBox_dс.Size = new Size(132, 23);
            textBox_dс.TabIndex = 55;
            // 
            // textBox_daa
            // 
            textBox_daa.Location = new Point(785, 169);
            textBox_daa.Margin = new Padding(3, 2, 3, 2);
            textBox_daa.Name = "textBox_daa";
            textBox_daa.PlaceholderText = "абсолют";
            textBox_daa.Size = new Size(132, 23);
            textBox_daa.TabIndex = 54;
            // 
            // textBox_da
            // 
            textBox_da.Location = new Point(785, 142);
            textBox_da.Margin = new Padding(3, 2, 3, 2);
            textBox_da.Name = "textBox_da";
            textBox_da.PlaceholderText = "абсолют";
            textBox_da.Size = new Size(132, 23);
            textBox_da.TabIndex = 52;
            // 
            // textBox_dL3
            // 
            textBox_dL3.Location = new Point(326, 195);
            textBox_dL3.Margin = new Padding(3, 2, 3, 2);
            textBox_dL3.Name = "textBox_dL3";
            textBox_dL3.PlaceholderText = "абсолют";
            textBox_dL3.Size = new Size(132, 23);
            textBox_dL3.TabIndex = 50;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(433, 201);
            label21.Name = "label21";
            label21.Size = new Size(0, 15);
            label21.TabIndex = 49;
            // 
            // textBox_dL2
            // 
            textBox_dL2.Location = new Point(326, 169);
            textBox_dL2.Margin = new Padding(3, 2, 3, 2);
            textBox_dL2.Name = "textBox_dL2";
            textBox_dL2.PlaceholderText = "абсолют";
            textBox_dL2.Size = new Size(132, 23);
            textBox_dL2.TabIndex = 48;
            // 
            // textBox_dL1
            // 
            textBox_dL1.Location = new Point(326, 142);
            textBox_dL1.Margin = new Padding(3, 2, 3, 2);
            textBox_dL1.Name = "textBox_dL1";
            textBox_dL1.PlaceholderText = "абсолют";
            textBox_dL1.Size = new Size(132, 23);
            textBox_dL1.TabIndex = 46;
            // 
            // textBox_Rez_D_BPLA_Z
            // 
            textBox_Rez_D_BPLA_Z.Location = new Point(326, 364);
            textBox_Rez_D_BPLA_Z.Margin = new Padding(3, 2, 3, 2);
            textBox_Rez_D_BPLA_Z.Name = "textBox_Rez_D_BPLA_Z";
            textBox_Rez_D_BPLA_Z.PlaceholderText = "H";
            textBox_Rez_D_BPLA_Z.ReadOnly = true;
            textBox_Rez_D_BPLA_Z.Size = new Size(132, 23);
            textBox_Rez_D_BPLA_Z.TabIndex = 64;
            // 
            // textBox_Rez_D_BPLA_Y
            // 
            textBox_Rez_D_BPLA_Y.Location = new Point(189, 364);
            textBox_Rez_D_BPLA_Y.Margin = new Padding(3, 2, 3, 2);
            textBox_Rez_D_BPLA_Y.Name = "textBox_Rez_D_BPLA_Y";
            textBox_Rez_D_BPLA_Y.PlaceholderText = "L";
            textBox_Rez_D_BPLA_Y.ReadOnly = true;
            textBox_Rez_D_BPLA_Y.Size = new Size(132, 23);
            textBox_Rez_D_BPLA_Y.TabIndex = 63;
            // 
            // textBox_Rez_D_T_Y
            // 
            textBox_Rez_D_T_Y.Location = new Point(648, 364);
            textBox_Rez_D_T_Y.Margin = new Padding(3, 2, 3, 2);
            textBox_Rez_D_T_Y.Name = "textBox_Rez_D_T_Y";
            textBox_Rez_D_T_Y.PlaceholderText = "L";
            textBox_Rez_D_T_Y.ReadOnly = true;
            textBox_Rez_D_T_Y.Size = new Size(132, 23);
            textBox_Rez_D_T_Y.TabIndex = 62;
            // 
            // textBox_Rez_D_T_X
            // 
            textBox_Rez_D_T_X.Location = new Point(512, 364);
            textBox_Rez_D_T_X.Margin = new Padding(3, 2, 3, 2);
            textBox_Rez_D_T_X.Name = "textBox_Rez_D_T_X";
            textBox_Rez_D_T_X.PlaceholderText = "B";
            textBox_Rez_D_T_X.ReadOnly = true;
            textBox_Rez_D_T_X.Size = new Size(132, 23);
            textBox_Rez_D_T_X.TabIndex = 61;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(458, 368);
            label24.Name = "label24";
            label24.Size = new Size(55, 13);
            label24.TabIndex = 60;
            label24.Text = "*ОБЪЕКТ:";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(180, 364);
            textBox12.Margin = new Padding(3, 2, 3, 2);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(0, 23);
            textBox12.TabIndex = 59;
            // 
            // textBox_Rez_D_BPLA_X
            // 
            textBox_Rez_D_BPLA_X.Location = new Point(52, 364);
            textBox_Rez_D_BPLA_X.Margin = new Padding(3, 2, 3, 2);
            textBox_Rez_D_BPLA_X.Name = "textBox_Rez_D_BPLA_X";
            textBox_Rez_D_BPLA_X.PlaceholderText = "B";
            textBox_Rez_D_BPLA_X.ReadOnly = true;
            textBox_Rez_D_BPLA_X.Size = new Size(132, 23);
            textBox_Rez_D_BPLA_X.TabIndex = 58;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(0, 366);
            label25.Name = "label25";
            label25.Size = new Size(47, 15);
            label25.TabIndex = 57;
            label25.Text = "*БПЛА:";
            // 
            // textBox_Rez_BPLA
            // 
            textBox_Rez_BPLA.Location = new Point(52, 415);
            textBox_Rez_BPLA.Margin = new Padding(3, 2, 3, 2);
            textBox_Rez_BPLA.Name = "textBox_Rez_BPLA";
            textBox_Rez_BPLA.PlaceholderText = "РАССТОЯНИЕ";
            textBox_Rez_BPLA.ReadOnly = true;
            textBox_Rez_BPLA.Size = new Size(405, 23);
            textBox_Rez_BPLA.TabIndex = 65;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(52, 398);
            label26.Name = "label26";
            label26.Size = new Size(168, 15);
            label26.TabIndex = 66;
            label26.Text = "Погрешность БПЛА в метрах";
            label26.Click += label26_Click;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(512, 398);
            label27.Name = "label27";
            label27.Size = new Size(182, 15);
            label27.TabIndex = 68;
            label27.Text = "Погрешность Объекта в метрах";
            // 
            // textBox_Rez_T
            // 
            textBox_Rez_T.Location = new Point(512, 415);
            textBox_Rez_T.Margin = new Padding(3, 2, 3, 2);
            textBox_Rez_T.Name = "textBox_Rez_T";
            textBox_Rez_T.PlaceholderText = "РАССТОЯНИЕ";
            textBox_Rez_T.ReadOnly = true;
            textBox_Rez_T.Size = new Size(405, 23);
            textBox_Rez_T.TabIndex = 67;
            // 
            // textBox_OO1_Z
            // 
            textBox_OO1_Z.Location = new Point(326, 22);
            textBox_OO1_Z.Margin = new Padding(3, 2, 3, 2);
            textBox_OO1_Z.Name = "textBox_OO1_Z";
            textBox_OO1_Z.PlaceholderText = "H";
            textBox_OO1_Z.Size = new Size(132, 23);
            textBox_OO1_Z.TabIndex = 90;
            // 
            // textBox_OO2_Z
            // 
            textBox_OO2_Z.Location = new Point(785, 22);
            textBox_OO2_Z.Margin = new Padding(3, 2, 3, 2);
            textBox_OO2_Z.Name = "textBox_OO2_Z";
            textBox_OO2_Z.PlaceholderText = "H";
            textBox_OO2_Z.Size = new Size(132, 23);
            textBox_OO2_Z.TabIndex = 91;
            // 
            // textBox_T_Z
            // 
            textBox_T_Z.Location = new Point(785, 46);
            textBox_T_Z.Margin = new Padding(3, 2, 3, 2);
            textBox_T_Z.Name = "textBox_T_Z";
            textBox_T_Z.PlaceholderText = "H";
            textBox_T_Z.Size = new Size(132, 23);
            textBox_T_Z.TabIndex = 92;
            // 
            // textBox_dbb
            // 
            textBox_dbb.Location = new Point(785, 221);
            textBox_dbb.Margin = new Padding(3, 2, 3, 2);
            textBox_dbb.Name = "textBox_dbb";
            textBox_dbb.PlaceholderText = "абсолют";
            textBox_dbb.Size = new Size(132, 23);
            textBox_dbb.TabIndex = 100;
            // 
            // textBox_db
            // 
            textBox_db.Location = new Point(785, 195);
            textBox_db.Margin = new Padding(3, 2, 3, 2);
            textBox_db.Name = "textBox_db";
            textBox_db.PlaceholderText = "абсолют";
            textBox_db.Size = new Size(132, 23);
            textBox_db.TabIndex = 99;
            // 
            // textBox_Input_bb
            // 
            textBox_Input_bb.Location = new Point(512, 221);
            textBox_Input_bb.Margin = new Padding(3, 2, 3, 2);
            textBox_Input_bb.Name = "textBox_Input_bb";
            textBox_Input_bb.PlaceholderText = "градусы";
            textBox_Input_bb.Size = new Size(132, 23);
            textBox_Input_bb.TabIndex = 98;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label18.Location = new Point(483, 221);
            label18.Name = "label18";
            label18.Size = new Size(25, 15);
            label18.TabIndex = 97;
            label18.Text = "∠B:";
            label18.Click += label18_Click;
            // 
            // textBox_Input_b
            // 
            textBox_Input_b.Location = new Point(512, 195);
            textBox_Input_b.Margin = new Padding(3, 2, 3, 2);
            textBox_Input_b.Name = "textBox_Input_b";
            textBox_Input_b.PlaceholderText = "градусы";
            textBox_Input_b.Size = new Size(132, 23);
            textBox_Input_b.TabIndex = 96;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label19.Location = new Point(483, 195);
            label19.Name = "label19";
            label19.Size = new Size(25, 15);
            label19.TabIndex = 95;
            label19.Text = "∠b:";
            label19.Click += label19_Click;
            // 
            // textBox_Rez_T_Z
            // 
            textBox_Rez_T_Z.Location = new Point(785, 337);
            textBox_Rez_T_Z.Margin = new Padding(3, 2, 3, 2);
            textBox_Rez_T_Z.Name = "textBox_Rez_T_Z";
            textBox_Rez_T_Z.PlaceholderText = "H";
            textBox_Rez_T_Z.ReadOnly = true;
            textBox_Rez_T_Z.Size = new Size(132, 23);
            textBox_Rez_T_Z.TabIndex = 101;
            // 
            // textBox_Rez_D_T_Z
            // 
            textBox_Rez_D_T_Z.Location = new Point(785, 364);
            textBox_Rez_D_T_Z.Margin = new Padding(3, 2, 3, 2);
            textBox_Rez_D_T_Z.Name = "textBox_Rez_D_T_Z";
            textBox_Rez_D_T_Z.PlaceholderText = "H";
            textBox_Rez_D_T_Z.ReadOnly = true;
            textBox_Rez_D_T_Z.Size = new Size(132, 23);
            textBox_Rez_D_T_Z.TabIndex = 102;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label20.Location = new Point(291, 142);
            label20.Name = "label20";
            label20.Size = new Size(30, 15);
            label20.TabIndex = 105;
            label20.Text = "∆L1:";
            label20.Click += label20_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label22.Location = new Point(291, 169);
            label22.Name = "label22";
            label22.Size = new Size(30, 15);
            label22.TabIndex = 106;
            label22.Text = "∆L2:";
            label22.Click += label22_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label23.Location = new Point(291, 195);
            label23.Name = "label23";
            label23.Size = new Size(30, 15);
            label23.TabIndex = 107;
            label23.Text = "∆L3:";
            label23.Click += label23_Click;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label29.Location = new Point(288, 221);
            label29.Name = "label29";
            label29.Size = new Size(34, 15);
            label29.TabIndex = 108;
            label29.Text = "∆∠C:";
            label29.Click += label29_Click;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label31.Location = new Point(748, 142);
            label31.Name = "label31";
            label31.Size = new Size(32, 15);
            label31.TabIndex = 109;
            label31.Text = "∆∠a:";
            label31.Click += label31_Click;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label33.Location = new Point(746, 169);
            label33.Name = "label33";
            label33.Size = new Size(34, 15);
            label33.TabIndex = 110;
            label33.Text = "∆∠A:";
            label33.Click += label33_Click;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label35.Location = new Point(747, 195);
            label35.Name = "label35";
            label35.Size = new Size(33, 15);
            label35.TabIndex = 111;
            label35.Text = "∆∠b:";
            label35.Click += label35_Click;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label36.Location = new Point(747, 221);
            label36.Name = "label36";
            label36.Size = new Size(33, 15);
            label36.TabIndex = 112;
            label36.Text = "∆∠B:";
            label36.Click += label36_Click;
            // 
            // textBoxBPLA_TEST_H
            // 
            textBoxBPLA_TEST_H.Location = new Point(788, 269);
            textBoxBPLA_TEST_H.Margin = new Padding(3, 2, 3, 2);
            textBoxBPLA_TEST_H.Name = "textBoxBPLA_TEST_H";
            textBoxBPLA_TEST_H.PlaceholderText = "H";
            textBoxBPLA_TEST_H.Size = new Size(132, 23);
            textBoxBPLA_TEST_H.TabIndex = 113;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label28.Location = new Point(697, 272);
            label28.Name = "label28";
            label28.Size = new Size(85, 15);
            label28.TabIndex = 114;
            label28.Text = "Высота БПЛА:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 445);
            Controls.Add(label28);
            Controls.Add(textBoxBPLA_TEST_H);
            Controls.Add(label36);
            Controls.Add(label35);
            Controls.Add(label33);
            Controls.Add(label31);
            Controls.Add(label29);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(label20);
            Controls.Add(textBox_Rez_D_T_Z);
            Controls.Add(textBox_Rez_T_Z);
            Controls.Add(textBox_dbb);
            Controls.Add(textBox_db);
            Controls.Add(textBox_Input_bb);
            Controls.Add(label18);
            Controls.Add(textBox_Input_b);
            Controls.Add(label19);
            Controls.Add(textBox_T_Z);
            Controls.Add(textBox_OO2_Z);
            Controls.Add(textBox_OO1_Z);
            Controls.Add(label27);
            Controls.Add(textBox_Rez_T);
            Controls.Add(label26);
            Controls.Add(textBox_Rez_BPLA);
            Controls.Add(textBox_Rez_D_BPLA_Z);
            Controls.Add(textBox_Rez_D_BPLA_Y);
            Controls.Add(textBox_Rez_D_T_Y);
            Controls.Add(textBox_Rez_D_T_X);
            Controls.Add(label24);
            Controls.Add(textBox12);
            Controls.Add(textBox_Rez_D_BPLA_X);
            Controls.Add(label25);
            Controls.Add(textBox_dс);
            Controls.Add(textBox_daa);
            Controls.Add(textBox_da);
            Controls.Add(textBox_dL3);
            Controls.Add(label21);
            Controls.Add(textBox_dL2);
            Controls.Add(textBox_dL1);
            Controls.Add(label17);
            Controls.Add(textBox_Input_сc);
            Controls.Add(textBox_Rez_BPLA_Z);
            Controls.Add(textBox_Rez_BPLA_Y);
            Controls.Add(textBox_Rez_T_Y);
            Controls.Add(textBox_Rez_T_X);
            Controls.Add(label15);
            Controls.Add(textBox24);
            Controls.Add(textBox_Rez_BPLA_X);
            Controls.Add(label16);
            Controls.Add(label14);
            Controls.Add(buttonMath);
            Controls.Add(label13);
            Controls.Add(textBox_Input_aa);
            Controls.Add(label12);
            Controls.Add(textBox_Input_a);
            Controls.Add(label11);
            Controls.Add(textBox_Input_L3);
            Controls.Add(label10);
            Controls.Add(textBox_Input_L2);
            Controls.Add(label9);
            Controls.Add(textBox_Input_L1);
            Controls.Add(label8);
            Controls.Add(textBox_Input_OO2_Y);
            Controls.Add(textBox_Input_OO2_X);
            Controls.Add(label6);
            Controls.Add(textBox_Input_OO1_Y);
            Controls.Add(textBox_Input_OO1_X);
            Controls.Add(label7);
            Controls.Add(buttonStart);
            Controls.Add(textBox_BPLA_Z);
            Controls.Add(textBox_BPLA_Y);
            Controls.Add(textBox_T_Y);
            Controls.Add(textBox_T_X);
            Controls.Add(label4);
            Controls.Add(textBox7);
            Controls.Add(textBox_BPLA_X);
            Controls.Add(label5);
            Controls.Add(textBox_OO2_Y);
            Controls.Add(textBox_OO2_X);
            Controls.Add(label3);
            Controls.Add(textBox_OO1_Y);
            Controls.Add(textBox_OO1_X);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Тестовая форма";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox_OO1_X;
        private TextBox textBox_OO1_Y;
        private TextBox textBox_OO2_Y;
        private TextBox textBox_OO2_X;
        private Label label3;
        private TextBox textBox_T_Y;
        private TextBox textBox_T_X;
        private Label label4;
        private TextBox textBox7;
        private TextBox textBox_BPLA_X;
        private Label label5;
        private TextBox textBox_BPLA_Y;
        private TextBox textBox_BPLA_Z;
        private Button buttonStart;
        private TextBox textBox_Input_OO2_Y;
        private TextBox textBox_Input_OO2_X;
        private Label label6;
        private TextBox textBox_Input_OO1_Y;
        private TextBox textBox_Input_OO1_X;
        private Label label7;
        private TextBox textBox_Input_L1;
        private Label label8;
        private TextBox textBox_Input_L2;
        private Label label9;
        private TextBox textBox_Input_L3;
        private Label label10;
        private TextBox textBox_Input_a;
        private Label label11;
        private TextBox textBox_Input_aa;
        private Label label12;
        private Label label13;
        private Button buttonMath;
        private Label label14;
        private TextBox textBox_Rez_BPLA_Z;
        private TextBox textBox_Rez_BPLA_Y;
        private TextBox textBox_Rez_T_Y;
        private TextBox textBox_Rez_T_X;
        private Label label15;
        private TextBox textBox24;
        private TextBox textBox_Rez_BPLA_X;
        private Label label16;
        private TextBox textBox_Input_сc;
        private Label label17;
        private TextBox textBox_dс;
        private TextBox textBox_daa;
        private TextBox textBox_da;
        private TextBox textBox_dL3;
        private Label label21;
        private TextBox textBox_dL2;
        private TextBox textBox_dL1;
        private TextBox textBox_Rez_D_BPLA_Z;
        private TextBox textBox_Rez_D_BPLA_Y;
        private TextBox textBox_Rez_D_T_Y;
        private TextBox textBox_Rez_D_T_X;
        private Label label24;
        private TextBox textBox12;
        private TextBox textBox_Rez_D_BPLA_X;
        private Label label25;
        private TextBox textBox_Rez_BPLA;
        private Label label26;
        private Label label27;
        private TextBox textBox_Rez_T;
        private TextBox textBox_OO1_Z;
        private TextBox textBox_OO2_Z;
        private TextBox textBox_T_Z;
        private TextBox textBox_dbb;
        private TextBox textBox_db;
        private TextBox textBox_Input_bb;
        private Label label18;
        private TextBox textBox_Input_b;
        private Label label19;
        private TextBox textBox_Rez_T_Z;
        private TextBox textBox_Rez_D_T_Z;
        private Label label20;
        private Label label22;
        private Label label23;
        private Label label29;
        private Label label31;
        private Label label33;
        private Label label35;
        private Label label36;
        private TextBox textBoxBPLA_TEST_H;
        private Label label28;
    }
}