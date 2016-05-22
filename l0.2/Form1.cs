using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l0._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Show();
            textBox2.Show();
            button1.Show();
            button2.Show();
            clear();
            loader();
            label3.Text = Memory.getBookSize().ToString();
            label5.Text = Memory.getStudentSize().ToString();
            label7.Text = Memory.getCurrentBorrowingBook().ToString();
            label9.Text = Memory.getTotalBorrowingBook().ToString();
        }

        private void loader()
        {
            textBox1.Name = textBox1.Text;
            textBox2.Name = textBox2.Text;
            textBox3.Name = textBox3.Text;
            textBox4.Name = textBox4.Text;
            textBox5.Name = textBox5.Text;
            textBox9.Name = textBox9.Text;
            textBox10.Name = textBox10.Text;
            textBox11.Name = textBox11.Text;
            textBox12.Name = textBox12.Text;
            textBox16.Name = textBox16.Text;
            textBox17.Name = textBox17.Text;
            textBox18.Name = textBox18.Text;
            textBox19.Name = textBox19.Text;
            textBox20.Name = textBox20.Text;
            textBox21.Name = textBox21.Text;
            textBox22.Name = textBox22.Text;
            textBox23.Name = textBox23.Text;
            textBox24.Name = textBox24.Text;
            textBox26.Name = textBox26.Text;

            Memory.addLibrarian("user", "1234");
            fakeList();
            file_reader();
        }

        

        private void file_reader()
        {
            StreamReader a = new StreamReader("100TemelEser.txt");
           //String[] informations;
            String line = a.ReadLine();
            for (line = a.ReadLine(); line != null; line = a.ReadLine())
            {

                String[] informations = Regex.Split(line, "//");

                Memory.addBook(informations[1],informations[0],informations[2],informations[3]);
                //MessageBox.Show(informations[1] + "\t" + informations[0] + "\t" + informations[2] + "\t" + informations[3]);

            }  
    //      MessageBox.Show(line);
            refreshListBox1();


        }

        private void fakeList()
        {
            int m = 30;
            for (int i = 1; i < m; i++)
                //for (int j = 1; j < m; j++)
                //            for (int k = 1; k < m; k++)
               // Memory.addBook("kitap" + 11 + i * 3, (13 + i * i * i * i).ToString(), "yazar" + 17 + i * i * i * 7); for (int i = 1; i < m; i++)
                //for (int j = 1; j < m; j++)
                //            for (int k = 1; k < m; k++)
                Memory.addStudent("Name" + 11 + i * 3,  "SurName" + 17 + i * i * i * 7,(13 + i * i * i * i).ToString());
            refreshListBox1();
            refreshListBox2();
        }


        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Click(object sender, EventArgs e)
        {
            TextBox box;
            box = (TextBox)sender;
            if (box.Text == box.Name)
            box.Text = "";
        }


        private void textBox_Leave(object sender, EventArgs e)
        {
            TextBox box;
            box = (TextBox)sender;
            if(box.Text == "")
            box.Text = box.Name;
        }

        private void bos()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //showUserPanel();
            string key = Manager.password_controll(textBox1.Text, textBox2.Text);
            if (key == "LIBRARIAN")
            {
                showUserPanel();
                textBox1.Text = textBox1.Name;
                textBox2.Text = textBox2.Name;
            }
            else if (key == "ADMIN")
            {
                showAdminPanel();
                textBox1.Text = textBox1.Name;
                textBox2.Text = textBox2.Name;
            }
            else if (key == "EMPTY")
                MessageBox.Show("Kullanıcı Adı / Şifre giriniz", "Uyarı");
            else
                MessageBox.Show("Hatalı Şifre / Kullanıcı Adı", "Uyarı");
        }
        private void showAdminPanel()
        {
            flowLayoutPanel1.Show();
            showUserPanel();
        }
        private void showUserPanel()
        {
            textBox1.Hide();
            textBox2.Hide();
            button1.Hide();
            button2.Hide();
            groupBox2.Show();
            groupBox13.Show();


        }
        private void hideAdminPanel()
        {
            flowLayoutPanel1.Hide();
        }

        private void clear()
        {
            //textBox3.Hide();
            //textBox4.Hide();
            //textBox5.Hide();
            //textBox6.Hide();
            //textBox7.Hide();
            //textBox8.Hide();
            //textBox9.Hide();
            //textBox10.Hide();
            //textBox11.Hide();
            //textBox12.Hide();
            //textBox15.Hide();
            //textBox14.Hide();
            //textBox13.Hide();
            //textBox22.Hide();

            //button10.Hide();
            //button11.Hide();
            //button16.Hide();
            //button17.Hide();
            //button15.Hide();
            //button18.Hide();
            //button22.Hide();


            //textBox16.Hide();
            //textBox17.Hide();
            //textBox18.Hide();
            //button19.Hide();


            //textBox19.Hide();
            //textBox20.Hide();
            //textBox21.Hide();
            //button20.Hide();
            //textBox23.Hide();
            //textBox24.Hide();
            //button27.Hide();
            //textBox26.Hide();
            //button28.Hide();
            groupBox1.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
            groupBox6.Hide();
            groupBox7.Hide();
            groupBox8.Hide();
            groupBox9.Hide();
            groupBox10.Hide();
            groupBox11.Hide();
            groupBox12.Hide();
            groupBox13.Hide();
            listBox1.Hide();
            listBox2.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            refreshListBox1();
            clear();
            groupBox1.Show();
            groupBox1.Location = new System.Drawing.Point(36, 130);
            groupBox3.Show();
            groupBox3.Location = new System.Drawing.Point(481, 130);
            listBox1.Location = new System.Drawing.Point(42, 190);
            listBox1.Size = new System.Drawing.Size(421, 420);
            listBox1.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            clear();
            textBox1.Show();
            textBox2.Show();
            button1.Show();
            button2.Show();

            groupBox2.Hide();
            hideAdminPanel();
            radioButtonReset();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            clear();
            groupBox7.Show();
            groupBox7.Location = new System.Drawing.Point(36, 202);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clear();
            groupBox1.Show();
            groupBox1.Location = new System.Drawing.Point(36, 190);
            groupBox5.Show();
            groupBox5.Location = new System.Drawing.Point(180, 130);
            groupBox8.Show();
            groupBox8.Location = new System.Drawing.Point(481, 190);
            listBox1.Location = new System.Drawing.Point(42, 250);
            listBox1.Size = new System.Drawing.Size(421, 420);
            listBox1.Show();

            listBox2.Location = new System.Drawing.Point(481, 250);
            listBox2.Size = new System.Drawing.Size(421, 420);
            listBox2.Show();
            button15.Enabled = true;
            radioButton4.Checked = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clear();
            groupBox6.Show();
            groupBox6.Location = new System.Drawing.Point(36, 130);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            refreshListBox2();
            clear();
            groupBox8.Show();
            groupBox8.Location = new System.Drawing.Point(36, 130);
            groupBox4.Show();
            groupBox4.Location = new System.Drawing.Point(481, 130);
            listBox2.Location = new System.Drawing.Point(42, 190);
            listBox2.Size = new System.Drawing.Size(421, 420);
            listBox2.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            clear();
            groupBox10.Show();
            groupBox10.Location = new System.Drawing.Point(36, 130);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null || listBox2.SelectedItem != null)
            {
                Manager.reBorrow((Book)listBox1.SelectedItem, (Student)listBox2.SelectedItem);
                Memory.delCurrentBorrowingBook();
                MessageBox.Show("İade Alındı", "BİLDİRİ");
            }
            refreshListBox1();
            refreshListBox2();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            clear();
            groupBox9.Show();
            groupBox9.Location = new System.Drawing.Point(36, 130);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label3.Text = Memory.getBookSize().ToString();
            label5.Text = Memory.getStudentSize().ToString();
            label7.Text = Memory.getCurrentBorrowingBook().ToString();
            label9.Text = Memory.getTotalBorrowingBook().ToString();
            radioButtonReset();
            clear();
            groupBox13.Show();
        }

        private void radioButtonReset()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            clear();
            textBox23.Show();
            textBox24.Show();

            button27.Show(); groupBox11.Show();

        }

        private void button24_Click(object sender, EventArgs e)
        {
            clear();
            textBox26.Show();
            button28.Show();
            groupBox12.Show();

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            //TextBox textbox = new TextBox();
            //textbox = (TextBox)sender;
            //int size = textbox.Text.Length;
            //string newtext = "";
            //for (int i = 0; i < size; i++)
            //    newtext += "x";
            //textbox.Text = newtext;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*TextBox textbox = new TextBox();
            textbox = (V)sender;
            Password.set_text(e.KeyChar);
            textBox1.Text = Password.get_text();
            textbox.Text = Password.get_text();*/
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            //this.textBox2.PasswordChar = '*';
            //TextBox box = new TextBox();
            //Manager.clear_text();
            //Manager.set_text(box.Text);
            //box.Text = Manager.get_text();
            //if (box.Text.Equals(""))
            //    this.textBox2.PasswordChar = '\0';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Book newItem = 
            if (textBox3.Text == textBox3.Name || textBox4.Text == textBox4.Name || textBox5.Text == textBox5.Name)
            {
                MessageBox.Show("Eksik bilgi girdiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Memory.isExistBook(textBox3.Text, textBox4.Text, textBox5.Text))
            {
                MessageBox.Show("Aynı ID ye sahip kitap daha önce kaydedilmiş!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Memory.addBook(textBox3.Text, textBox4.Text, textBox5.Text);
            refreshListBox1();
            MessageBox.Show("Kitap Eklendi", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox16.Text == textBox16.Name || textBox17.Text == textBox17.Name || textBox18.Text == textBox18.Name)
            {
                MessageBox.Show("Eksik bilgi girdiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Memory.isExistStudent(textBox16.Text, textBox17.Text, textBox18.Text))
            {
                MessageBox.Show("Aynı ID ye sahip kitap daha önce kaydedilmiş!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Memory.addStudent(textBox16.Text, textBox17.Text, textBox18.Text);
            refreshListBox2();
            MessageBox.Show("Öğrenci Eklendi", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Memory.deleteBoook((Book)listBox1.SelectedItem);
            refreshListBox1();
            MessageBox.Show("Kitap Silindi", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public void refreshListBox1()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < Memory.getBookList().Count; i++)
                listBox1.Items.Add(Memory.getBookList()[i]);
        }

        private void refreshListBox2()
        {
            listBox2.Items.Clear();
            for (int i = 0; i < Memory.getStudentsList().Count; i++)
                listBox2.Items.Add(Memory.getStudentsList()[i]);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Memory.deleteStudent((Student)listBox2.SelectedItem);
            refreshTextBoxs();
            refreshListBox2();
            MessageBox.Show("Öğrenci Silindi", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void refreshTextBoxs()
        {
            textBox1.Text = textBox1.Name;
            textBox2.Text = textBox2.Name;
            textBox3.Text = textBox3.Name;
            textBox4.Text = textBox4.Name;
            textBox5.Text = textBox5.Name;
            textBox9.Text = textBox9.Name;
            textBox10.Text = textBox10.Name;
            textBox11.Text = textBox11.Name;
            textBox12.Text = textBox12.Name;
            textBox16.Text = textBox16.Name;
            textBox17.Text = textBox17.Name;
            textBox18.Text = textBox18.Name;
            textBox19.Text = textBox19.Name;
            textBox20.Text = textBox20.Name;
            textBox21.Text = textBox21.Name;
            textBox22.Text = textBox22.Name;
            textBox23.Text = textBox23.Name;
            textBox24.Text = textBox24.Name;
            textBox26.Text = textBox26.Name;
        
        
        }

        private void textBoxTextChangedForBook(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < Memory.getBookList().Count; i++)
                if (bookChooser(i))
                    listBox1.Items.Add(Memory.getBookList()[i]);
        }

        private bool bookChooser(int i)
        {
            if (textBox3.Text.Equals(textBox3.Name) || ((Book)(Memory.getBookList()[i])).getName().StartsWith(textBox3.Text.ToString()))
                if (textBox4.Text.Equals(textBox4.Name) || ((Book)(Memory.getBookList()[i])).getId().StartsWith(textBox4.Text.ToString()))
                    if (textBox5.Text.Equals(textBox5.Name) || ((Book)(Memory.getBookList()[i])).getWriter().StartsWith(textBox5.Text.ToString()))
                        return true;
            return false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Form2 newForm = new Form2(listBox1.SelectedItem);
                newForm.ShowDialog();
                listBox1.Items.Clear();
                for (int i = 0; i < Memory.getBookList().Count; i++)
                    if (bookChooser(i))
                        listBox1.Items.Add(Memory.getBookList()[i]);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Form3 newForm = new Form3(listBox1.SelectedItem);
                newForm.ShowDialog();
            }   
        }

        private void textBoxTextChangedForStudent(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            for (int i = 0; i < Memory.getStudentsList().Count; i++)
                if (studentChooser(i))
                    listBox2.Items.Add(Memory.getStudentsList()[i]);
        }

        private bool studentChooser(int i)
        {
            if (textBox16.Text.Equals(textBox16.Name) || ((Student)(Memory.getStudentsList()[i])).getName().StartsWith(textBox16.Text.ToString()))
                if (textBox18.Text.Equals(textBox18.Name) || ((Student)(Memory.getStudentsList()[i])).getId().StartsWith(textBox18.Text.ToString()))
                    if (textBox17.Text.Equals(textBox17.Name) || ((Student)(Memory.getStudentsList()[i])).getSurname().StartsWith(textBox17.Text.ToString()))
                        return true;
            return false;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null || listBox2.SelectedItem != null)
            {
                Form4 newForm = new Form4(listBox2.SelectedItem);
                newForm.ShowDialog();
                listBox2.Items.Clear();
                for (int i = 0; i < Memory.getStudentsList().Count; i++)
                    if (studentChooser(i))
                        listBox2.Items.Add(Memory.getStudentsList()[i]);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null || listBox2.SelectedItem != null)
            {
                String message = Manager.borrow((Book)listBox1.SelectedItem, (Student)listBox2.SelectedItem);
                MessageBox.Show(message, "BİLDİRİ");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null || listBox2.SelectedItem != null)
            {
                String message = Manager.reservation((Book)listBox1.SelectedItem, (Student)listBox2.SelectedItem);
                MessageBox.Show(message, "BİLDİRİ");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                Form5 newForm = new Form5(listBox2.SelectedItem);
                newForm.ShowDialog();
                listBox2.Items.Clear();
                for (int i = 0; i < Memory.getStudentsList().Count; i++)
                    if (studentChooser(i))
                        listBox2.Items.Add(Memory.getStudentsList()[i]);                
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true) { 
                button15.Enabled = true;
                button17.Enabled = false;
                button16.Enabled = false;
                button8.Enabled = false;
            }
            else if (radioButton5.Checked == true)
            {
                button15.Enabled = false;
                button17.Enabled = true;
                button16.Enabled = false;
                button8.Enabled = false;
            }
            else if (radioButton6.Checked == true)
            {
                button15.Enabled = false;
                button17.Enabled = false;
                button16.Enabled = true;
                button8.Enabled = false;
            }
            else if (radioButton7.Checked == true)
            {
                button15.Enabled = false;
                button17.Enabled = false;
                button16.Enabled = false;
                button8.Enabled = true;
            }
            refreshListBox1();
            refreshListBox2();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                
            }
            else if (radioButton5.Checked == true)
            {
                

            }
            else if (radioButton6.Checked == true)
            {
                if (listBox2.SelectedIndex == -1)
                {
                    listBox2.Items.Clear();
                    ArrayList list = ((Book)listBox1.SelectedItem).getStudentList();
                    foreach (Student student in list)
                        listBox2.Items.Add(student);
                }
                else 
                    ;
            }            
            else if (radioButton7.Checked == true)
            {
                if (listBox2.SelectedIndex == -1)
                {
                    listBox2.Items.Clear();
                    ArrayList list = ((Book)listBox1.SelectedItem).getReservationList();
                    foreach (Student student in list)
                        listBox2.Items.Add(student);
                }
                else 
                    ;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                

            }
            else if (radioButton5.Checked == true)
            {
                

            }
            else if (radioButton6.Checked == true)
            {
                if (listBox1.SelectedIndex == -1)
                {
                    listBox1.Items.Clear();
                    ArrayList list = ((Student)listBox2.SelectedItem).getBookList();
                    foreach (Book book in list)
                        listBox1.Items.Add(book);
                }
                else
                    ;
            }            
            else if (radioButton7.Checked == true)
            {
                if (listBox1.SelectedIndex == -1)
                {
                    listBox1.Items.Clear();
                    ArrayList list = ((Student)listBox2.SelectedItem).getReservationList();
                    foreach (Book book in list)
                        listBox1.Items.Add(book);
                }
                else
                    ;
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null || listBox2.SelectedItem != null)
            {
                Manager.reReservation((Book)listBox1.SelectedItem, (Student)listBox2.SelectedItem);
                MessageBox.Show("İade Alındı", "BİLDİRİ");
            }
            refreshListBox1();
            refreshListBox2();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (Memory.deleteLibrarian(textBox26.Text) == 0)
                MessageBox.Show("Bu isimde kullanıcı bulunamadı", "BİLDİRİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Kullanıcı silindi", "BİLDİRİ");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Memory.addLibrarian(textBox23.Text, textBox24.Text);
            MessageBox.Show("Kullanıcı Eklendi", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            this.Show();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }        
    }
}
