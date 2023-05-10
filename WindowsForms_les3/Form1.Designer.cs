namespace WindowsForms_les3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox_gasStation = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox_gasToPay = new System.Windows.Forms.GroupBox();
            this.label_grn3 = new System.Windows.Forms.Label();
            this.itogo_gas = new System.Windows.Forms.Label();
            this.label_grn1 = new System.Windows.Forms.Label();
            this.label_gasPrice = new System.Windows.Forms.Label();
            this.textBox_gasPrice = new System.Windows.Forms.TextBox();
            this.comboBox_gasTypes = new System.Windows.Forms.ComboBox();
            this.label_gas = new System.Windows.Forms.Label();
            this.groupBox_radiobuttons = new System.Windows.Forms.GroupBox();
            this.label_grn2 = new System.Windows.Forms.Label();
            this.label_litr = new System.Windows.Forms.Label();
            this.textBox_gasSum = new System.Windows.Forms.TextBox();
            this.textBox_gasCount = new System.Windows.Forms.TextBox();
            this.rdB_Sum = new System.Windows.Forms.RadioButton();
            this.rdB_count = new System.Windows.Forms.RadioButton();
            this.groupBox_Cafe = new System.Windows.Forms.GroupBox();
            this.label_CafeCount = new System.Windows.Forms.Label();
            this.label_cafePrice = new System.Windows.Forms.Label();
            this.groupBox_cafeToPay = new System.Windows.Forms.GroupBox();
            this.label_grn4 = new System.Windows.Forms.Label();
            this.textBox_cafeToPay = new System.Windows.Forms.TextBox();
            this.textBox_cafe4_amount = new System.Windows.Forms.TextBox();
            this.textBox_cafe3_amount = new System.Windows.Forms.TextBox();
            this.textBox_cafe2_amount = new System.Windows.Forms.TextBox();
            this.textBox_cafe1_amount = new System.Windows.Forms.TextBox();
            this.textBox_cafe4_price = new System.Windows.Forms.TextBox();
            this.textBox_cafe3_price = new System.Windows.Forms.TextBox();
            this.textBox_cafe2_price = new System.Windows.Forms.TextBox();
            this.textBox_cafe1_price = new System.Windows.Forms.TextBox();
            this.checkBox_cola = new System.Windows.Forms.CheckBox();
            this.checkBox_potato = new System.Windows.Forms.CheckBox();
            this.checkBox_burger = new System.Windows.Forms.CheckBox();
            this.checkBox_hotdog = new System.Windows.Forms.CheckBox();
            this.groupBox_Total = new System.Windows.Forms.GroupBox();
            this.label_grn5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_TotalToPay = new System.Windows.Forms.TextBox();
            this.button_TotalToPay = new System.Windows.Forms.Button();
            this.groupBox_gasStation.SuspendLayout();
            this.groupBox_gasToPay.SuspendLayout();
            this.groupBox_radiobuttons.SuspendLayout();
            this.groupBox_Cafe.SuspendLayout();
            this.groupBox_cafeToPay.SuspendLayout();
            this.groupBox_Total.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_gasStation
            // 
            this.groupBox_gasStation.Controls.Add(this.panel1);
            this.groupBox_gasStation.Controls.Add(this.groupBox_gasToPay);
            this.groupBox_gasStation.Controls.Add(this.label_grn1);
            this.groupBox_gasStation.Controls.Add(this.label_gasPrice);
            this.groupBox_gasStation.Controls.Add(this.textBox_gasPrice);
            this.groupBox_gasStation.Controls.Add(this.comboBox_gasTypes);
            this.groupBox_gasStation.Controls.Add(this.label_gas);
            this.groupBox_gasStation.Controls.Add(this.groupBox_radiobuttons);
            this.groupBox_gasStation.Location = new System.Drawing.Point(12, 12);
            this.groupBox_gasStation.Name = "groupBox_gasStation";
            this.groupBox_gasStation.Size = new System.Drawing.Size(226, 299);
            this.groupBox_gasStation.TabIndex = 0;
            this.groupBox_gasStation.TabStop = false;
            this.groupBox_gasStation.Text = "Автозаправка";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(244, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 118);
            this.panel1.TabIndex = 2;
            // 
            // groupBox_gasToPay
            // 
            this.groupBox_gasToPay.Controls.Add(this.label_grn3);
            this.groupBox_gasToPay.Controls.Add(this.itogo_gas);
            this.groupBox_gasToPay.Location = new System.Drawing.Point(12, 202);
            this.groupBox_gasToPay.Name = "groupBox_gasToPay";
            this.groupBox_gasToPay.Size = new System.Drawing.Size(201, 87);
            this.groupBox_gasToPay.TabIndex = 7;
            this.groupBox_gasToPay.TabStop = false;
            this.groupBox_gasToPay.Text = "До оплати(автозаправка)";
            // 
            // label_grn3
            // 
            this.label_grn3.AutoSize = true;
            this.label_grn3.Location = new System.Drawing.Point(162, 46);
            this.label_grn3.Name = "label_grn3";
            this.label_grn3.Size = new System.Drawing.Size(27, 13);
            this.label_grn3.TabIndex = 7;
            this.label_grn3.Text = "грн.";
            // 
            // itogo_gas
            // 
            this.itogo_gas.AutoSize = true;
            this.itogo_gas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itogo_gas.Location = new System.Drawing.Point(70, 38);
            this.itogo_gas.Name = "itogo_gas";
            this.itogo_gas.Size = new System.Drawing.Size(94, 24);
            this.itogo_gas.TabIndex = 0;
            this.itogo_gas.Text = "gasToPay";
            // 
            // label_grn1
            // 
            this.label_grn1.AutoSize = true;
            this.label_grn1.Location = new System.Drawing.Point(186, 64);
            this.label_grn1.Name = "label_grn1";
            this.label_grn1.Size = new System.Drawing.Size(27, 13);
            this.label_grn1.TabIndex = 6;
            this.label_grn1.Text = "грн.";
            // 
            // label_gasPrice
            // 
            this.label_gasPrice.AutoSize = true;
            this.label_gasPrice.Location = new System.Drawing.Point(15, 60);
            this.label_gasPrice.Name = "label_gasPrice";
            this.label_gasPrice.Size = new System.Drawing.Size(29, 13);
            this.label_gasPrice.TabIndex = 5;
            this.label_gasPrice.Text = "Ціна";
            // 
            // textBox_gasPrice
            // 
            this.textBox_gasPrice.Location = new System.Drawing.Point(86, 57);
            this.textBox_gasPrice.Name = "textBox_gasPrice";
            this.textBox_gasPrice.ReadOnly = true;
            this.textBox_gasPrice.Size = new System.Drawing.Size(100, 20);
            this.textBox_gasPrice.TabIndex = 4;
            // 
            // comboBox_gasTypes
            // 
            this.comboBox_gasTypes.FormattingEnabled = true;
            this.comboBox_gasTypes.Items.AddRange(new object[] {
            "A 95+",
            "A 95",
            "A 92",
            "ДТ",
            "Газ"});
            this.comboBox_gasTypes.Location = new System.Drawing.Point(86, 30);
            this.comboBox_gasTypes.Name = "comboBox_gasTypes";
            this.comboBox_gasTypes.Size = new System.Drawing.Size(127, 21);
            this.comboBox_gasTypes.TabIndex = 3;
            this.comboBox_gasTypes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_gas
            // 
            this.label_gas.AutoSize = true;
            this.label_gas.Location = new System.Drawing.Point(15, 33);
            this.label_gas.Name = "label_gas";
            this.label_gas.Size = new System.Drawing.Size(44, 13);
            this.label_gas.TabIndex = 2;
            this.label_gas.Text = "Бензин";
            // 
            // groupBox_radiobuttons
            // 
            this.groupBox_radiobuttons.Controls.Add(this.label_grn2);
            this.groupBox_radiobuttons.Controls.Add(this.label_litr);
            this.groupBox_radiobuttons.Controls.Add(this.textBox_gasSum);
            this.groupBox_radiobuttons.Controls.Add(this.textBox_gasCount);
            this.groupBox_radiobuttons.Controls.Add(this.rdB_Sum);
            this.groupBox_radiobuttons.Controls.Add(this.rdB_count);
            this.groupBox_radiobuttons.Location = new System.Drawing.Point(12, 98);
            this.groupBox_radiobuttons.Name = "groupBox_radiobuttons";
            this.groupBox_radiobuttons.Size = new System.Drawing.Size(201, 78);
            this.groupBox_radiobuttons.TabIndex = 1;
            this.groupBox_radiobuttons.TabStop = false;
            // 
            // label_grn2
            // 
            this.label_grn2.AutoSize = true;
            this.label_grn2.Location = new System.Drawing.Point(174, 50);
            this.label_grn2.Name = "label_grn2";
            this.label_grn2.Size = new System.Drawing.Size(27, 13);
            this.label_grn2.TabIndex = 5;
            this.label_grn2.Text = "грн.";
            // 
            // label_litr
            // 
            this.label_litr.AutoSize = true;
            this.label_litr.Location = new System.Drawing.Point(174, 23);
            this.label_litr.Name = "label_litr";
            this.label_litr.Size = new System.Drawing.Size(16, 13);
            this.label_litr.TabIndex = 4;
            this.label_litr.Text = "л.";
            // 
            // textBox_gasSum
            // 
            this.textBox_gasSum.Location = new System.Drawing.Point(74, 43);
            this.textBox_gasSum.Name = "textBox_gasSum";
            this.textBox_gasSum.Size = new System.Drawing.Size(100, 20);
            this.textBox_gasSum.TabIndex = 3;
            this.textBox_gasSum.TextChanged += new System.EventHandler(this.textBox_sum_TextChanged);
            // 
            // textBox_gasCount
            // 
            this.textBox_gasCount.Location = new System.Drawing.Point(74, 17);
            this.textBox_gasCount.Name = "textBox_gasCount";
            this.textBox_gasCount.Size = new System.Drawing.Size(100, 20);
            this.textBox_gasCount.TabIndex = 2;
            this.textBox_gasCount.TextChanged += new System.EventHandler(this.textBox_count_TextChanged);
            // 
            // rdB_Sum
            // 
            this.rdB_Sum.AutoSize = true;
            this.rdB_Sum.Location = new System.Drawing.Point(6, 44);
            this.rdB_Sum.Name = "rdB_Sum";
            this.rdB_Sum.Size = new System.Drawing.Size(51, 17);
            this.rdB_Sum.TabIndex = 1;
            this.rdB_Sum.TabStop = true;
            this.rdB_Sum.Text = "Сума";
            this.rdB_Sum.UseVisualStyleBackColor = true;
            this.rdB_Sum.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdB_count
            // 
            this.rdB_count.AutoSize = true;
            this.rdB_count.Location = new System.Drawing.Point(6, 20);
            this.rdB_count.Name = "rdB_count";
            this.rdB_count.Size = new System.Drawing.Size(71, 17);
            this.rdB_count.TabIndex = 0;
            this.rdB_count.TabStop = true;
            this.rdB_count.Text = "Кількість";
            this.rdB_count.UseVisualStyleBackColor = true;
            this.rdB_count.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBox_Cafe
            // 
            this.groupBox_Cafe.Controls.Add(this.label_CafeCount);
            this.groupBox_Cafe.Controls.Add(this.label_cafePrice);
            this.groupBox_Cafe.Controls.Add(this.groupBox_cafeToPay);
            this.groupBox_Cafe.Controls.Add(this.textBox_cafe4_amount);
            this.groupBox_Cafe.Controls.Add(this.textBox_cafe3_amount);
            this.groupBox_Cafe.Controls.Add(this.textBox_cafe2_amount);
            this.groupBox_Cafe.Controls.Add(this.textBox_cafe1_amount);
            this.groupBox_Cafe.Controls.Add(this.textBox_cafe4_price);
            this.groupBox_Cafe.Controls.Add(this.textBox_cafe3_price);
            this.groupBox_Cafe.Controls.Add(this.textBox_cafe2_price);
            this.groupBox_Cafe.Controls.Add(this.textBox_cafe1_price);
            this.groupBox_Cafe.Controls.Add(this.checkBox_cola);
            this.groupBox_Cafe.Controls.Add(this.checkBox_potato);
            this.groupBox_Cafe.Controls.Add(this.checkBox_burger);
            this.groupBox_Cafe.Controls.Add(this.checkBox_hotdog);
            this.groupBox_Cafe.Location = new System.Drawing.Point(259, 12);
            this.groupBox_Cafe.Name = "groupBox_Cafe";
            this.groupBox_Cafe.Size = new System.Drawing.Size(224, 299);
            this.groupBox_Cafe.TabIndex = 1;
            this.groupBox_Cafe.TabStop = false;
            this.groupBox_Cafe.Text = "Кафе";
            // 
            // label_CafeCount
            // 
            this.label_CafeCount.AutoSize = true;
            this.label_CafeCount.Location = new System.Drawing.Point(167, 11);
            this.label_CafeCount.Name = "label_CafeCount";
            this.label_CafeCount.Size = new System.Drawing.Size(53, 13);
            this.label_CafeCount.TabIndex = 14;
            this.label_CafeCount.Text = "Кількість";
            // 
            // label_cafePrice
            // 
            this.label_cafePrice.AutoSize = true;
            this.label_cafePrice.Location = new System.Drawing.Point(103, 11);
            this.label_cafePrice.Name = "label_cafePrice";
            this.label_cafePrice.Size = new System.Drawing.Size(29, 13);
            this.label_cafePrice.TabIndex = 13;
            this.label_cafePrice.Text = "Ціна";
            // 
            // groupBox_cafeToPay
            // 
            this.groupBox_cafeToPay.Controls.Add(this.label_grn4);
            this.groupBox_cafeToPay.Controls.Add(this.textBox_cafeToPay);
            this.groupBox_cafeToPay.Location = new System.Drawing.Point(15, 202);
            this.groupBox_cafeToPay.Name = "groupBox_cafeToPay";
            this.groupBox_cafeToPay.Size = new System.Drawing.Size(193, 87);
            this.groupBox_cafeToPay.TabIndex = 12;
            this.groupBox_cafeToPay.TabStop = false;
            this.groupBox_cafeToPay.Text = "До оплати (кафе)";
            // 
            // label_grn4
            // 
            this.label_grn4.AutoSize = true;
            this.label_grn4.Location = new System.Drawing.Point(154, 53);
            this.label_grn4.Name = "label_grn4";
            this.label_grn4.Size = new System.Drawing.Size(27, 13);
            this.label_grn4.TabIndex = 1;
            this.label_grn4.Text = "грн.";
            // 
            // textBox_cafeToPay
            // 
            this.textBox_cafeToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_cafeToPay.Location = new System.Drawing.Point(60, 35);
            this.textBox_cafeToPay.Name = "textBox_cafeToPay";
            this.textBox_cafeToPay.Size = new System.Drawing.Size(88, 29);
            this.textBox_cafeToPay.TabIndex = 0;
            // 
            // textBox_cafe4_amount
            // 
            this.textBox_cafe4_amount.Location = new System.Drawing.Point(158, 109);
            this.textBox_cafe4_amount.Name = "textBox_cafe4_amount";
            this.textBox_cafe4_amount.ReadOnly = true;
            this.textBox_cafe4_amount.Size = new System.Drawing.Size(50, 20);
            this.textBox_cafe4_amount.TabIndex = 11;
            this.textBox_cafe4_amount.Text = "0";
            this.textBox_cafe4_amount.TextChanged += new System.EventHandler(this.textBox_cafe4_amount_TextChanged);
            // 
            // textBox_cafe3_amount
            // 
            this.textBox_cafe3_amount.Location = new System.Drawing.Point(158, 83);
            this.textBox_cafe3_amount.Name = "textBox_cafe3_amount";
            this.textBox_cafe3_amount.ReadOnly = true;
            this.textBox_cafe3_amount.Size = new System.Drawing.Size(50, 20);
            this.textBox_cafe3_amount.TabIndex = 10;
            this.textBox_cafe3_amount.Text = "0";
            this.textBox_cafe3_amount.TextChanged += new System.EventHandler(this.textBox_cafe3_amount_TextChanged);
            // 
            // textBox_cafe2_amount
            // 
            this.textBox_cafe2_amount.Location = new System.Drawing.Point(158, 57);
            this.textBox_cafe2_amount.Name = "textBox_cafe2_amount";
            this.textBox_cafe2_amount.ReadOnly = true;
            this.textBox_cafe2_amount.Size = new System.Drawing.Size(50, 20);
            this.textBox_cafe2_amount.TabIndex = 9;
            this.textBox_cafe2_amount.Text = "0";
            this.textBox_cafe2_amount.TextChanged += new System.EventHandler(this.textBox_cafe2_amount_TextChanged);
            // 
            // textBox_cafe1_amount
            // 
            this.textBox_cafe1_amount.Location = new System.Drawing.Point(158, 31);
            this.textBox_cafe1_amount.Name = "textBox_cafe1_amount";
            this.textBox_cafe1_amount.ReadOnly = true;
            this.textBox_cafe1_amount.Size = new System.Drawing.Size(50, 20);
            this.textBox_cafe1_amount.TabIndex = 8;
            this.textBox_cafe1_amount.Text = "0";
            this.textBox_cafe1_amount.TextChanged += new System.EventHandler(this.textBox_cafe1_amount_TextChanged);
            // 
            // textBox_cafe4_price
            // 
            this.textBox_cafe4_price.Location = new System.Drawing.Point(105, 109);
            this.textBox_cafe4_price.Name = "textBox_cafe4_price";
            this.textBox_cafe4_price.ReadOnly = true;
            this.textBox_cafe4_price.Size = new System.Drawing.Size(47, 20);
            this.textBox_cafe4_price.TabIndex = 7;
            // 
            // textBox_cafe3_price
            // 
            this.textBox_cafe3_price.Location = new System.Drawing.Point(105, 83);
            this.textBox_cafe3_price.Name = "textBox_cafe3_price";
            this.textBox_cafe3_price.ReadOnly = true;
            this.textBox_cafe3_price.Size = new System.Drawing.Size(47, 20);
            this.textBox_cafe3_price.TabIndex = 6;
            // 
            // textBox_cafe2_price
            // 
            this.textBox_cafe2_price.Location = new System.Drawing.Point(105, 57);
            this.textBox_cafe2_price.Name = "textBox_cafe2_price";
            this.textBox_cafe2_price.ReadOnly = true;
            this.textBox_cafe2_price.Size = new System.Drawing.Size(47, 20);
            this.textBox_cafe2_price.TabIndex = 5;
            // 
            // textBox_cafe1_price
            // 
            this.textBox_cafe1_price.Location = new System.Drawing.Point(105, 31);
            this.textBox_cafe1_price.Name = "textBox_cafe1_price";
            this.textBox_cafe1_price.ReadOnly = true;
            this.textBox_cafe1_price.Size = new System.Drawing.Size(47, 20);
            this.textBox_cafe1_price.TabIndex = 4;
            // 
            // checkBox_cola
            // 
            this.checkBox_cola.AutoSize = true;
            this.checkBox_cola.Location = new System.Drawing.Point(15, 111);
            this.checkBox_cola.Name = "checkBox_cola";
            this.checkBox_cola.Size = new System.Drawing.Size(78, 17);
            this.checkBox_cola.TabIndex = 3;
            this.checkBox_cola.Text = "Кока-кола";
            this.checkBox_cola.UseVisualStyleBackColor = true;
            this.checkBox_cola.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox_potato
            // 
            this.checkBox_potato.AutoSize = true;
            this.checkBox_potato.Location = new System.Drawing.Point(15, 85);
            this.checkBox_potato.Name = "checkBox_potato";
            this.checkBox_potato.Size = new System.Drawing.Size(93, 17);
            this.checkBox_potato.TabIndex = 2;
            this.checkBox_potato.Text = "Картопля фрі";
            this.checkBox_potato.UseVisualStyleBackColor = true;
            this.checkBox_potato.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox_burger
            // 
            this.checkBox_burger.AutoSize = true;
            this.checkBox_burger.Location = new System.Drawing.Point(15, 59);
            this.checkBox_burger.Name = "checkBox_burger";
            this.checkBox_burger.Size = new System.Drawing.Size(61, 17);
            this.checkBox_burger.TabIndex = 1;
            this.checkBox_burger.Text = "Бургер";
            this.checkBox_burger.UseVisualStyleBackColor = true;
            this.checkBox_burger.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox_hotdog
            // 
            this.checkBox_hotdog.AutoSize = true;
            this.checkBox_hotdog.Location = new System.Drawing.Point(15, 33);
            this.checkBox_hotdog.Name = "checkBox_hotdog";
            this.checkBox_hotdog.Size = new System.Drawing.Size(64, 17);
            this.checkBox_hotdog.TabIndex = 0;
            this.checkBox_hotdog.Text = "Хот-дог";
            this.checkBox_hotdog.UseVisualStyleBackColor = true;
            this.checkBox_hotdog.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox_Total
            // 
            this.groupBox_Total.Controls.Add(this.label_grn5);
            this.groupBox_Total.Controls.Add(this.pictureBox1);
            this.groupBox_Total.Controls.Add(this.textBox_TotalToPay);
            this.groupBox_Total.Controls.Add(this.button_TotalToPay);
            this.groupBox_Total.Location = new System.Drawing.Point(12, 317);
            this.groupBox_Total.Name = "groupBox_Total";
            this.groupBox_Total.Size = new System.Drawing.Size(471, 74);
            this.groupBox_Total.TabIndex = 2;
            this.groupBox_Total.TabStop = false;
            this.groupBox_Total.Text = "ВСЬОГО до оплати";
            // 
            // label_grn5
            // 
            this.label_grn5.AutoSize = true;
            this.label_grn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_grn5.Location = new System.Drawing.Point(288, 36);
            this.label_grn5.Name = "label_grn5";
            this.label_grn5.Size = new System.Drawing.Size(59, 29);
            this.label_grn5.TabIndex = 3;
            this.label_grn5.Text = "грн.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::WindowsForms_les3.Properties.Resources.free_icon_money_bags_3639404__2_;
            this.pictureBox1.Location = new System.Drawing.Point(18, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 38);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_TotalToPay
            // 
            this.textBox_TotalToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_TotalToPay.Location = new System.Drawing.Point(182, 27);
            this.textBox_TotalToPay.Name = "textBox_TotalToPay";
            this.textBox_TotalToPay.Size = new System.Drawing.Size(100, 35);
            this.textBox_TotalToPay.TabIndex = 1;
            // 
            // button_TotalToPay
            // 
            this.button_TotalToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_TotalToPay.Location = new System.Drawing.Point(65, 27);
            this.button_TotalToPay.Name = "button_TotalToPay";
            this.button_TotalToPay.Size = new System.Drawing.Size(111, 35);
            this.button_TotalToPay.TabIndex = 0;
            this.button_TotalToPay.Text = "Порахувати";
            this.button_TotalToPay.UseVisualStyleBackColor = true;
            this.button_TotalToPay.Click += new System.EventHandler(this.button_TotalToPay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 403);
            this.Controls.Add(this.groupBox_Total);
            this.Controls.Add(this.groupBox_Cafe);
            this.Controls.Add(this.groupBox_gasStation);
            this.Name = "Form1";
            this.Text = "BestOil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_gasStation.ResumeLayout(false);
            this.groupBox_gasStation.PerformLayout();
            this.groupBox_gasToPay.ResumeLayout(false);
            this.groupBox_gasToPay.PerformLayout();
            this.groupBox_radiobuttons.ResumeLayout(false);
            this.groupBox_radiobuttons.PerformLayout();
            this.groupBox_Cafe.ResumeLayout(false);
            this.groupBox_Cafe.PerformLayout();
            this.groupBox_cafeToPay.ResumeLayout(false);
            this.groupBox_cafeToPay.PerformLayout();
            this.groupBox_Total.ResumeLayout(false);
            this.groupBox_Total.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_gasStation;
        private System.Windows.Forms.RadioButton rdB_count;
        private System.Windows.Forms.GroupBox groupBox_radiobuttons;
        private System.Windows.Forms.RadioButton rdB_Sum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_gasTypes;
        private System.Windows.Forms.Label label_gas;
        private System.Windows.Forms.GroupBox groupBox_gasToPay;
        private System.Windows.Forms.Label label_grn3;
        private System.Windows.Forms.Label itogo_gas;
        private System.Windows.Forms.Label label_grn1;
        private System.Windows.Forms.Label label_gasPrice;
        private System.Windows.Forms.TextBox textBox_gasPrice;
        private System.Windows.Forms.Label label_grn2;
        private System.Windows.Forms.Label label_litr;
        private System.Windows.Forms.TextBox textBox_gasSum;
        private System.Windows.Forms.TextBox textBox_gasCount;
        private System.Windows.Forms.GroupBox groupBox_Cafe;
        private System.Windows.Forms.CheckBox checkBox_hotdog;
        private System.Windows.Forms.CheckBox checkBox_cola;
        private System.Windows.Forms.CheckBox checkBox_potato;
        private System.Windows.Forms.CheckBox checkBox_burger;
        private System.Windows.Forms.GroupBox groupBox_cafeToPay;
        private System.Windows.Forms.TextBox textBox_cafeToPay;
        private System.Windows.Forms.TextBox textBox_cafe4_amount;
        private System.Windows.Forms.TextBox textBox_cafe3_amount;
        private System.Windows.Forms.TextBox textBox_cafe2_amount;
        private System.Windows.Forms.TextBox textBox_cafe1_amount;
        private System.Windows.Forms.TextBox textBox_cafe4_price;
        private System.Windows.Forms.TextBox textBox_cafe3_price;
        private System.Windows.Forms.TextBox textBox_cafe2_price;
        private System.Windows.Forms.TextBox textBox_cafe1_price;
        private System.Windows.Forms.GroupBox groupBox_Total;
        private System.Windows.Forms.TextBox textBox_TotalToPay;
        private System.Windows.Forms.Button button_TotalToPay;
        private System.Windows.Forms.Label label_CafeCount;
        private System.Windows.Forms.Label label_cafePrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_grn4;
        private System.Windows.Forms.Label label_grn5;
    }
}

