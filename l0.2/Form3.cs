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
    public partial class Form3 : Form
    {
        Object books;

        public Form3(Object book)
        {
            InitializeComponent();
            label4.Text = ((Book)book).getName();
            label5.Text = ((Book)book).getId();
            label6.Text = ((Book)book).getWriter();
            label7.Text = ((Book)book).getAbout();
            label8.Text = ((Book)book).getTotalNumberOfBook().ToString();
            label10.Text = (((Book)book).getTotalNumberOfBook() - ((Book)book).getNumberOfBook()).ToString();
            foreach (Student item in ((Book)book).StudentsList)
                listBox1.Items.Add(((Student)item));

            this.books = book;
        }
    }
}
