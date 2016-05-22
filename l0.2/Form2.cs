using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l0._2
{
    public partial class Form2 : Form
    {
        Object books;

        public Form2(Object book)
        {
            InitializeComponent();
            textBox1.Text = ((Book)book).getName();
            textBox2.Text = ((Book)book).getId();
            textBox3.Text = ((Book)book).getWriter();
            textBox4.Text = ((Book)book).getAbout();
            textBox5.Text = ((Book)book).getTotalNumberOfBook().ToString();

            this.books = book;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(textBox2.Text) ||
                String.IsNullOrWhiteSpace(textBox3.Text) || 
                String.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Eksik bilgi girdiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ((Book)books).setName(textBox1.Text);
            ((Book)books).setId(textBox2.Text);
            ((Book)books).setWriter(textBox3.Text);
            ((Book)books).setAbout(textBox4.Text);
            ((Book)books).setTotalNumberOfBook(textBox5.Text);
            MessageBox.Show("Kitap bilgileri güncellendi");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

    }
}
