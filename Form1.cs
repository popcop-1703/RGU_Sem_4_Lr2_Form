using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

                maximStore.Name = "Maxim Store";
                maximStore.TvCost = 10000;
                maximStore.AllSell = Convert.ToInt32(textBox1.Text);
                label2.Text = "Сумма общих продаж = " + Convert.ToString(maximStore.AllCost());
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
            

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8  && number != ',') // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
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
