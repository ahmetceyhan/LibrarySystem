using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace l0._2
{
    class Manager
    {
        //internal Book Book
        //{
        //    get
        //    {
        //        throw new System.NotImplementedException();
        //    }
        //    set
        //    {
        //    }
        //}

        //internal Person Person
        //{
        //    get
        //    {
        //        throw new System.NotImplementedException();
        //    }
        //    set
        //    {
        //    }
        //}

        public static string password_controll(string name, string password)
        {
            if (name == "Kullanıcı adı" && password == "Şifre")
                return "EMPTY";
            if (name == "admin" && password == "admin")
                return "ADMIN";
            else if (Memory.isExistUser(name,password))
                return "LIBRARIAN";
            else
                return "null";
        }

        //GIRIS EKRANI SIFRE SEMBOLU ICIN
        ///////////////////////////////////////////////////////////////////
        //goruntulenecek texti tutuyor
        private static string text = "";
        //textin sifrelimi sifresizmi goruntulecegini belirliyor
        private static bool key = false;

        public static string get_text()
        {
            if (key == false)
            {
                string newtext = "";                    //
                for (int i = 0; i < text.Length; i++)   //sifreli hale getiriyor
                    newtext += "\u0416";                //
                //
                return newtext;                         //sifreli return ediyor
            }
            else
                return text;//sifresiz return ediyor
        }


        public static void set_text(string input)
        {
            //texte ekleme yapiyor ve max 4 sayi girilebiliyor
            if (text.Length < 4)
                text += input;
        }

        public static void set_key()
        {
            if (key == true)
                key = false;
            else
                key = true;
        }

        public static bool get_key()
        {
            return key;
        }

        //texti siliyor
        public static void clear_text()
        {
            text = "";
        }

        internal static String borrow(Book book, Student student)
        {
            if (book.getNumberOfBook() == 0)
                return book.getName() + "isimli kitaptan stokta bulunmamaktadir. Ödünç verilemedi.";
            if (book.isExistOnStudentList(student))
                return "Aynı Öğrenciye Zaten Ödünç Verildi";
            if (book.getReservationList() == null)
            {
                student.addBookList(book);
                book.addStudentList(student);
                book.setNumberOfBook((book.getNumberOfBook() - 1).ToString());
                Memory.addCurrentBorrowingBook();
                Memory.addTotalBorrowingBook();
                return "Ödünç Verildi";
            }
            else
            {
                if (book.getNumberOfBook() == 0)
                {
                    if (book.isExistOnReservationList(student))
                    {
                        student.addBookList(book);
                        book.addStudentList(student);
                        book.setNumberOfBook((book.getNumberOfBook()-1).ToString());
                        book.deleteReservationList(student);
                        Memory.addCurrentBorrowingBook();
                        Memory.addTotalBorrowingBook();
                        return "Ödünç Verildi";
                    }
                    else
                    {
                        return "Ödünç Verilemedi: Rezerve eden öğrenci var, öncelik o öğrencide";
                    }
                }
                else
                {
                    student.addBookList(book);
                    book.addStudentList(student);
                    book.setNumberOfBook((book.getNumberOfBook() - 1).ToString());
                    Memory.addCurrentBorrowingBook();
                    Memory.addTotalBorrowingBook();
                    return "Ödünç Verildi";
                }
            }
            //return "borrow(Book book, Student student)";
        }

        internal static void reBorrow(Book book, Student student)
        {
            student.deleteBookList(book);
            book.deleteStudentList(student);
            book.setNumberOfBook((book.getNumberOfBook() + 1).ToString());
        }

        internal static String reservation(Book book, Student student)
        {
            if (book.isExistOnReservationList(student))
                return "Aynı Öğrenciye Zaten Rezerve Verildi";
            else
            {
                student.addReservationList(book);
                book.addReservationList(student);
                return "Rezerve Edildi";
            }
        }
        internal static void reReservation(Book book, Student student)
        {
            student.deleteReservationList(book);
            book.deleteReservationList(student);
        }

        internal Password Password
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        //internal static void take(Book book, Student student)
        //{
        //    student.deleteBookList(book);
        //    book.deleteStudentList(student);
        //}
    }

}
