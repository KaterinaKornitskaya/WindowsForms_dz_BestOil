using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsForms_les3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double a95plus = 50;       // цена позиции бензина
        private double a95 = 45;           // цена позиции бензина
        private double a92 = 40;           // цена позиции бензина
        private double dt = 35;            // цена позиции бензина
        private double gas = 30;           // цена позиции бензина
        private double hotdog_price = 40;  // цена позиции кафе
        private double burger_price = 30;  // цена позиции кафе
        private double potato_price = 20;  // цена позиции кафе
        private double cola_price = 10;    // цена позиции кафе
     

        // 2 раза щелкнули по форме, получили метод
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_gasTypes.SelectedIndex = 0;  // по умолчанию галочка стоит на 0 эл-те пизиции бензина
            rdB_Sum.Checked = true;               // по умолчанию включен raddioButton "Сума"
            textBox_cafe1_price.Text = hotdog_price.ToString("N2");  // установка цены в текстбоксах "Цена" в кафе
            textBox_cafe2_price.Text = burger_price.ToString("N2");  // установка цены в текстбоксах "Цена" в кафе
            textBox_cafe3_price.Text = potato_price.ToString("N2");  // установка цены в текстбоксах "Цена" в кафе
            textBox_cafe4_price.Text = cola_price.ToString("N2");    // установка цены в текстбоксах "Цена" в кафе
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // установка цены в текстбокс "Цена" в Заправке
            switch (comboBox_gasTypes.SelectedIndex)  // в зависимости от выбранного вида бензина
            {
                case (0):
                    textBox_gasPrice.Text = a95plus.ToString();
                    break;
                case (1):
                    textBox_gasPrice.Text = a95.ToString();
                    break;
                case (2):
                    textBox_gasPrice.Text = a92.ToString();
                    break;
                case (3):
                    textBox_gasPrice.Text = dt.ToString();
                    break;
                case (4):
                    textBox_gasPrice.Text = gas.ToString();
                    break;
            }
            itogo_gas.Text = Rosrahunok_zapravka().ToString("N2");
        }

        private double Rosrahunok_zapravka()  // метод Рассчет цены в Заправке
        {
            double rozrahunok = 0;  // переменная для итоговой цены
            if (textBox_gasCount.Text == string.Empty)  // если текстбокс "Кол-во" в заправке пустая
                textBox_gasCount.Text = 0.ToString();   // то утсанавливаем 0
           
            if (textBox_gasSum.Text == string.Empty)    // если текстбокс "Сумма" в заправке пустая
                textBox_gasSum.Text = 0.ToString();     // то утсанавливаем 0

            if (rdB_count.Checked)  // если установлена галочка "Кол-во" в заправке
            {
                rozrahunok = double.Parse(textBox_gasPrice.Text) 
                    * double.Parse(textBox_gasCount.Text);
            }
            else if (rdB_Sum.Checked)  // если установлена галочка "Сумма" в заправке
            {
                rozrahunok = double.Parse(textBox_gasSum.Text);
                textBox_gasCount.Text = (rozrahunok/double.Parse(textBox_gasPrice.Text)).ToString("N2");
            }
            return rozrahunok;
        }

        // смена галочки в radioButton в заправке
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rdB_count.Checked)  // если установлена галочка "Кол-во" в заправке 
            { 
                textBox_gasCount.ReadOnly = false;  // текстбокс Кол-во - не только для чтения
                textBox_gasSum.ReadOnly = true;     // текстбокс Сумма - только для чтения

                textBox_gasCount.Text = 10.ToString("N2");  // в текстбокс Кол-во утсанавливаем 10 по умолчанию
                textBox_gasSum.Text = string.Empty;
            }
            else if (rdB_Sum.Checked)  // если установлена галочка "Сумма" в заправке
            {
                textBox_gasCount.ReadOnly = true;  // текстбокс Кол-во - только для чтения
                textBox_gasSum.ReadOnly = false;   // текстбокс Сумма - не только для чтения

                textBox_gasSum.Text = 100.ToString("N2");  // в текстбокс Сумма утсанавливаем 10 по умолчанию
                textBox_gasCount.Text = string.Empty;
            }
        }

        private void textBox_count_TextChanged(object sender, EventArgs e)
        {
            // в зависимотси от изменения Кол-во в Заправке - меняем Всего цена в заправке
            itogo_gas.Text = Rosrahunok_zapravka().ToString("N2");          
        }

        private void textBox_sum_TextChanged(object sender, EventArgs e)
        {
            // в зависимотси от изменения Сумма в Заправке - меняем Всего цена в заправке
            itogo_gas.Text = Rosrahunok_zapravka().ToString("N2");
        }

        private double Rozrahunok_Cafe()  // метод Рассчет цены в Кафе
        {
            if (textBox_cafe1_amount.Text == string.Empty)  // если текстбокс "Кол-во" в кафе пустая
                textBox_cafe1_amount.Text = 0.ToString();   // то утсанавливаем 0
            if (textBox_cafe2_amount.Text == string.Empty)
                textBox_cafe2_amount.Text = 0.ToString();
            if (textBox_cafe3_amount.Text == string.Empty)
                textBox_cafe3_amount.Text = 0.ToString();
            if (textBox_cafe4_amount.Text == string.Empty)
                textBox_cafe4_amount.Text = 0.ToString();

            double f1 = double.Parse(textBox_cafe1_price.Text) * double.Parse(textBox_cafe1_amount.Text);
            double f2 = double.Parse(textBox_cafe2_price.Text) * double.Parse(textBox_cafe2_amount.Text);
            double f3 = double.Parse(textBox_cafe3_price.Text) * double.Parse(textBox_cafe3_amount.Text);
            double f4 = double.Parse(textBox_cafe4_price.Text) * double.Parse(textBox_cafe4_amount.Text);
            
            return f1+f2+f3+f4;
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_hotdog.Checked)                    // если чекбокс хотдог включен
            {
                textBox_cafe1_amount.ReadOnly = false;     // то открываем поле позиции
            }
            else if (checkBox_hotdog.Checked == false)     // если чекбокс хотдог отключен
            {
                textBox_cafe1_amount.ReadOnly = true;      // то ставим поле позиции только для чтения
                textBox_cafe1_amount.Text = 0.ToString();  // в поле позиции автоматически ставится 0
            }
        }

        // аналогично checkBox1_CheckedChanged:
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_burger.Checked)
            {
                textBox_cafe2_amount.ReadOnly = false;
            }
            else if (checkBox_burger.Checked == false)
            {
                textBox_cafe2_amount.ReadOnly= true;
                textBox_cafe2_amount.Text = 0.ToString();
            }
        }

        // аналогично checkBox1_CheckedChanged:
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_potato.Checked)
            {
                textBox_cafe3_amount.ReadOnly = false;
            }
            else if (checkBox_potato.Checked == false)
            {
                textBox_cafe3_amount.ReadOnly= true;
                textBox_cafe3_amount.Text = 0.ToString();
            }
        }

        // аналогично checkBox1_CheckedChanged:
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_cola.Checked)
            {
                textBox_cafe4_amount.ReadOnly = false;
            }
            else if (checkBox_cola.Checked == false)
            {
                textBox_cafe4_amount.ReadOnly= true;
                textBox_cafe4_amount.Text = 0.ToString();
            }
        }
      
        private void textBox_cafe1_amount_TextChanged(object sender, EventArgs e)
        {
            // в зависимотси от изменения кол-ва позиции в кафе - меняем Всего цена в кафе
            textBox_cafeToPay.Text = Rozrahunok_Cafe().ToString("N2");
        }

        private void textBox_cafe2_amount_TextChanged(object sender, EventArgs e)
        {
            // в зависимотси от изменения кол-ва позиции в кафе - меняем Всего цена в кафе
            textBox_cafeToPay.Text = Rozrahunok_Cafe().ToString("N2");
        }

        private void textBox_cafe3_amount_TextChanged(object sender, EventArgs e)
        {
            // в зависимотси от изменения кол-ва позиции в кафе - меняем Всего цена в кафе
            textBox_cafeToPay.Text = Rozrahunok_Cafe().ToString("N2");
        }

        private void textBox_cafe4_amount_TextChanged(object sender, EventArgs e)
        {
            // в зависимотси от изменения кол-ва позиции в кафе - меняем Всего цена в кафе
            textBox_cafeToPay.Text = Rozrahunok_Cafe().ToString("N2");
        }

        // обработка клика по кнопке Постчитать (полный рассчет)
        private void button_TotalToPay_Click(object sender, EventArgs e)
        {
            textBox_TotalToPay.Text
                 = (Rosrahunok_zapravka() + Rozrahunok_Cafe()).ToString("N2");
        }
    }
}
