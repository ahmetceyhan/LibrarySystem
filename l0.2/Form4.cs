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
    public partial class Form4 : Form
    {
        Object students;

        public Form4(Object student)
        {
            InitializeComponent();
            textBox1.Text = ((Student)student).getName();
            textBox2.Text = ((Student)student).getSurname();
            textBox3.Text = ((Student)student).getId();
            foreach (Book item in ((Student)student).bookList)
                listBox1.Items.Add(((Book)item));
            this.students = student;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text) ||
                String.IsNullOrWhiteSpace(textBox2.Text) ||
                String.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Eksik bilgi girdiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ((Student)students).setName(textBox1.Text);
            ((Student)students).setSurname(textBox2.Text);
            ((Student)students).setId(textBox3.Text);
            MessageBox.Show("Öğrenci bilgileri güncellendi");
        }
    }
}
