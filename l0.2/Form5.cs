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
    public partial class Form5 : Form
    {
        public Form5(Object student)
        {
            InitializeComponent();

            label4.Text = ((Student)student).getName();
            label5.Text = ((Student)student).getSurname();
            label6.Text = ((Student)student).getId();
            foreach (Book item in ((Student)student).bookList)
                listBox1.Items.Add(((Book)item));
        }
    }
}
