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

namespace RGU_Sem_4_Lr2_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TvStore maximStore = new TvStore();

                maximStore.Name = textBox3.Text;
                maximStore.TvCost = Convert.ToDouble(textBox2.Text);
                maximStore.AllSell = Convert.ToInt32(textBox1.Text);
                //label2.Text = "Сумма общих продаж = " + Convert.ToString(maximStore.AllCost());
                MessageBox.Show("Название магазина - " + maximStore.Name + "\nСумма общих продаж = " + Convert.ToString(maximStore.AllCost()) + "\nКоличество продаж = " + Convert.ToString(maximStore.TvCost), "Результат");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
            

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != ',') // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
           // textBox4.Clear();
           // textBox5.Clear();
        }
    }

    class TvStore
    {
        string nameStore;
        public string Name
        {
            get { return nameStore; }
            set { nameStore = value; }
        }
        //объявление закрытого поля
        double tvCost;
        //объявление свойства для чтения и для записи
        public double TvCost
        {
            get { return tvCost; }
            set { tvCost = value; }
        }
        double allSell;
        public double AllSell
        {
            set { allSell = value; }
        }
        public decimal AllCost()
        {
            return (decimal)(tvCost * allSell);
        }
    }

    
}
