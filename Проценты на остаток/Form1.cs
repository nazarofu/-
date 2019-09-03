using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проценты_на_остаток
{
    public partial class Form1 : Form
    {
        // 1. Переменные валют

        string rub = "₽"; // Рубль
        string usd = "$"; // Доллар
        string eur = "€"; // Евро
        string uah = "₴"; // Гривна
        string trl = "₺"; // Турецкая лира

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Text = "Рассчитайте сколько вам выплатят\nпо банковскому вкладу"; // Сделал через код для переноса строки на новый абзац
            comboBox1.SelectedIndex = 0;
        }

        // 2. Проводимые вычисления

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = (numericUpDown1.Value * numericUpDown2.Value / 100).ToString("F"); // Сначала вычисляется сколько набежит % за год
            textBox1.Text = (Convert.ToDouble(textBox2.Text) / 12).ToString("F"); // Затем делится на количество месяцев для вычисления ежемесячной выплаты

        }

        // 3. Валюты

        // 3.1. Рубль

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Text = rub; // ...поля валют заполняются символом рубля
            textBox6.Text = rub;
            textBox7.Text = rub;
        }

        // 3.2. Доллар

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Text = usd; // ..поля валют заполняются символом доллара
            textBox6.Text = usd;
            textBox7.Text = usd;
        }

        // 3.3. Евро

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Text = eur; // ..поля валют заполняются символом евро
            textBox6.Text = eur;
            textBox7.Text = eur;
        }

        // 3.4. Гривна

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            {
                textBox5.Text = uah; // ..поля валют заполняются символом гривны
                textBox6.Text = uah;
                textBox7.Text = uah;
            }
        }

        // 3.5.Турецкая лира

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Text = trl; // ..поля валют заполняются символом лиры
            textBox6.Text = trl;
            textBox7.Text = trl;
        }

        // 4. Локализации

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        // 4.1. Русская

            if (comboBox1.SelectedIndex == 0)
            {
                label5.Text = "Рассчитайте сколько вам выплатят\nпо банковскому вкладу";
                label1.Text = "сумма";
                label2.Text = "% по вкладу";
                label3.Text = "в месяц";
                label4.Text = "в год";
                label6.Text = "Итого:";
                label7.Text = "Автор: Сергей Назаров";
                label8.Text = "Language / Язык:";
                label8.Location = new System.Drawing.Point(120, 349); // Исправление положения текстовой надписи
                button1.Text = "Рассчитать";
                groupBox1.Text = "Валюты";
                radioButton1.Text = "Рубль";
                radioButton2.Text = "Доллар";
                radioButton3.Text = "Евро";
                radioButton5.Text = "Гривна";
                radioButton4.Text = "Лира";
                radioButton1.Checked = true; // автоматически выбирает валюту страны при переключении языка
            }

            // 4.2. Английская

            if (comboBox1.SelectedIndex == 1)
            {
                label5.Text = "Calculate how much you will be paid\non a bank's deposit";
                label1.Text = "amount";
                label2.Text = "% deposit interest";
                label3.Text = "per month";
                label4.Text = "per year";
                label6.Text = "Total:";
                label7.Text = "Author: Sergey Nazarov";
                label8.Text = "Language:";
                label8.Location = new System.Drawing.Point(158, 349); // Исправление положения текстовой надписи
                button1.Text = "Calculate";
                groupBox1.Text = "Currencies";
                radioButton1.Text = "Ruble";
                radioButton2.Text = "Dollar";
                radioButton3.Text = "Euro";
                radioButton5.Text = "Hryvnia";
                radioButton4.Text = "Lira";
                radioButton2.Checked = true; // автоматически выбирает валюту страны при переключении языка
            }

            // 4.3. Французская

            if (comboBox1.SelectedIndex == 2)
            {
                label5.Text = "Calculez combien vous serez payé sur\nun dépôt bancaire";
                label1.Text = "montant";
                label2.Text = "% sur le dépôt";
                label3.Text = "par mois";
                label4.Text = "par an";
                label6.Text = "Total:";
                label7.Text = "Auteur: Sergey Nazarov";
                label8.Text = "Language / Langue:";
                label8.Location = new System.Drawing.Point(112, 349); // Исправление положения текстовой надписи
                button1.Text = "Calculer";
                groupBox1.Text = "Monnaies";
                radioButton1.Text = "Rouble";
                radioButton2.Text = "Dollar";
                radioButton3.Text = "Euro";
                radioButton5.Text = "Grivna";
                radioButton4.Text = "Lire";
                radioButton3.Checked = true; // автоматически выбирает валюту страны при переключении языка
            }

            // 4.3. Украинская

            if (comboBox1.SelectedIndex == 3)
            {
                label5.Text = "Розрахуйте скільки вам виплатять\nза банківським вкладом";
                label1.Text = "сума";
                label2.Text = "% за вкладом";
                label3.Text = "в місяць";
                label4.Text = "у рік";
                label6.Text = "Разом:";
                label7.Text = "Автор: Сергій Назаров";
                label8.Text = "Language / Мова:";
                label8.Location = new System.Drawing.Point(120, 349); // исправление положения текстовой надписи
                button1.Text = "Розрахувавши";
                groupBox1.Text = "Валюта";
                radioButton1.Text = "Рубель";
                radioButton2.Text = "Долар";
                radioButton3.Text = "Євро";
                radioButton5.Text = "Гривня";
                radioButton4.Text = "Ліра";
                radioButton5.Checked = true; // автоматически выбирает валюту страны при переключении языка
            }

            // 4.4. Турецкая

            if (comboBox1.SelectedIndex == 4)
            {
                label5.Text = "Banka mevduatında ne kadar ödeme\nyapacağınızı hesaplayın";
                label1.Text = "miktarı";
                label2.Text = "% mevduat";
                label3.Text = "aylık";
                label4.Text = "yılda";
                label6.Text = "Tutar:";
                label7.Text = "Yazar: Sergey Nazarov";
                label8.Text = "Language / Dil:";
                label8.Location = new System.Drawing.Point(135, 349); // исправление положения текстовой надписи
                button1.Text = "Hesaplamak";
                groupBox1.Text = "Döviz";
                radioButton1.Text = "Ruble";
                radioButton2.Text = "Dolar";
                radioButton3.Text = "Avro";
                radioButton5.Text = "Grivnası";
                radioButton4.Text = "Lira";
                radioButton4.Checked = true; // автоматически выбирает валюту страны при переключении языка
            }
        }
    }
    }
