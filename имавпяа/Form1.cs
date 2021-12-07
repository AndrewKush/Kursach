using System;
using System.Windows.Forms;

namespace имавпяа
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
    
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
         if (!Char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))
            {
                if (!((e.KeyChar.ToString() == ",") && (textBox1.Text.IndexOf(",") == -1)))
                    e.Handled = true;
            }   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double k;//Курс(отнрошение рубля к доллару
            double usd;//Цена в долларах
            double rub;//Цена в рублях
            label4.Text = "";
            try
            {
                //Исходные данные
                usd = System.Convert.ToDouble(textBox1.Text);
                k = System.Convert.ToDouble(textBox2.Text);
                //Первесчет
                rub = usd * k;
                //Вывод результата
                label4.Text = usd.ToString("N") + " USD = " + rub.ToString("C");
            }
            catch
            {
                //Исключение
                if((textBox1.Text== "") || (textBox2.Text== ""))
                {
                    MessageBox.Show("Ошибка исходных данных. \n" + "Необходимо ввести данные в оба поля. ", "Конвертер", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ошибка исходных данных. \n" + "Неверный формат данных в одном из полей. ", "Конвертер", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
