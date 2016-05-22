using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace l0._2
{
    class Memory
    {
        private static ArrayList studentsList = new ArrayList();
        private static ArrayList librariantsList = new ArrayList();
        private static ArrayList bookList = new ArrayList();
        private static int currentBorrowingBook = 0;
        private static int totalBorrowingBook = 0;

        static public void addLibrarian(string name, string password)
        {
            Librarians librarian = new Librarians(name, password);
            librariantsList.Add(librarian);
        }

        static public int deleteLibrarian(string name) {
            foreach (Librarians librarian in librariantsList)
            {
                if (librarian.getName().Equals(name))
                {
                    librariantsList.Remove(librarian);
                    return 1;
                }
            }
            return 0;
        }
        static public void lookStudent() { }
        static public void addStudent(string name, string surname, string id)
        {
            Student student = new Student(name, surname, id);
            studentsList.Add(student);
            //return student;
        }
        static public void deleteStudent(Student student)
        {
            student.deleteThisStudent();
            studentsList.Remove(student);
        }

        static public void addBook(string name, string id, string writer)
        {
            Book book = new Book(name, id, writer);
            bookList.Add(book);
            //bookList.Sort();
            //return book;
        }
        static public void addBook(string name, string id, string writer, string about)
        {
            Book book = new Book(name, id, writer, about);
            bookList.Add(book);
            //bookList.Sort();
            //return book;
        }
        static public void deleteBoook(Book book)
        {
            book.deleteThisBook();
            bookList.Remove(book);             
        }
        static public Book searchBook(string id)
        {
            foreach(Book book in bookList){
               if (book.getId().Equals(id))
                  return book;
            }
            return null;
        }
        static public void borrowBook() { }
        static public void rezerveBook() { }
        static public void getBackBook() { }

        public static int getSizeOfLibrariantsSize()
        {
            return librariantsList.Count;
        }

        static public bool isExistBook(string p1, string p2, string p3)
        {
            foreach (Book item in bookList)
            {
                if (item.getId().Equals(p2))
                    return false;
            }
            return true;
        }

        static public bool isExistStudent(string p1, string p2, string p3)
        {
            foreach (Student item in studentsList)
            {
                if (item.getId().Equals(p3))
                    return false;
            }
            return true;
        }

        static public int getBookSize()
        {
            return bookList.Count;
        }

        static public int getStudentSize()
        {
            return studentsList.Count;
        }


        public static void addTotalBorrowingBook()
        {
            totalBorrowingBook++;
        }

        public static void addCurrentBorrowingBook()
        {
            currentBorrowingBook++;
        }
        public static void delCurrentBorrowingBook()
        {
            currentBorrowingBook--;
        }
        public static int getTotalBorrowingBook()
        {
            return totalBorrowingBook;
        }

        public static int getCurrentBorrowingBook()
        {
            return currentBorrowingBook;
        }
        public static ArrayList getBookList()
        {
            return bookList;
        }
        public static ArrayList getStudentsList()
        {
            return studentsList;
        }

        internal static bool isExistUser(string name, string password)
        {
            foreach (Librarians librarian in librariantsList)
            {
                if (librarian.getName().Equals(name) && librarian.getPassword().Equals(password))
                    return true;
            }
            return false;
        }
    }
}
