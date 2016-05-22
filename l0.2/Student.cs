using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace l0._2 
{
    class Student : Person
    {
        string surname;
        string id;
        public ArrayList bookList = new ArrayList();
        public ArrayList reservationList = new ArrayList();

        public Student(string name,string surname,string id) : base(name)
        {
            this.surname = surname;
            this.id = id;
            
        }
        public string getId()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        public string getSurname()
        {
            return surname;
        }
        public void setId(String id)
        {
            this.id = id;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public void setSurname(String surname)
        {
            this.surname = surname;
        }
        public override string ToString()
        {
            int size = 10;
            String output = "";
            for (int j = 0; j < id.Length; j++)
                output += id[j];
            for (int i = id.Length; i < size; i++)
            {

                output += " ";
            }
            return id.ToString().PadRight(30, ' ') + "\t" + name.ToString().PadRight(30, ' ') + "\t" + surname.ToString().PadRight(30, ' ');
        }

        public void addBookList(Book book)
        {
            bookList.Add(book);
        }

        public void deleteBookList(Book book)
        {
            bookList.Remove(book);
        }
        public ArrayList getBookList()
        {
            return bookList;
        }
        public void addReservationList(Book book)
        {
            reservationList.Add(book);
        }

        public void deleteReservationList(Book book)
        {
            reservationList.Remove(book);
        }
        public ArrayList getReservationList()
        {
            return reservationList;
        }
        public void deleteThisStudent()
        {
            foreach (Object book in bookList)
            {
                ((Book)book).deleteStudentList(this);
                ((Book)book).setNumberOfBook((((Book)book).getNumberOfBook() + 1).ToString());
            }
        }
    }
}
