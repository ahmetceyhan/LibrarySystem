using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l0._2
{
    class Book //: IComparable
    {
        private string id;
        private string name;
        private string writer;
        private string about;
        private ArrayList studentsList = new ArrayList();
        private ArrayList reservationList = new ArrayList();
        private int numberOfBook;
        private int totalNumberOfBook;

        public ArrayList StudentsList
        {
            get { return studentsList; }
            set { studentsList = value; }
        }

        public Book(string name, string id, string writer)
        {
            this.name = name;
            this.id = id;
            this.writer = writer;
            this.about = "";
            this.numberOfBook = 1;
            this.totalNumberOfBook = 1;
        }
        public Book(string name, string id, string writer,string about)
        {
            this.name = name;
            this.id = id;
            this.writer = writer;
            this.about = about;
            this.numberOfBook = 1;
            this.totalNumberOfBook = 1;
        }


        public override string ToString()
        {
            StringFormat format = new StringFormat(StringFormatFlags.LineLimit);
            float[] formatTabs = { 10.0f, 20.0f };
            format.SetTabStops(0.0f, formatTabs);
            //return String.Format("{-50:c}{50:c}{50:c}", id, name, writer);
            //return id + "\t\t\t" + name + "\t\t\t" + writer;
            return id.ToString().PadRight(30, ' ') + "\t" + name.ToString().PadRight(29, ' ') + "\t" + writer.ToString().PadRight(28, ' ');
        }
            

        public string getWriter()
        {
            return writer;
        }

        public string getId()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        public void setWriter(String writer)
        {
            this.writer = writer;
        }
        public string getAbout()
        {
            return about;
        }

        public void setAbout(String about)
        {
            this.about = about;
        }

        public void setId(String id)
        {
            this.id = id;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        //override
        //public int CompareTo(object obj)
        //{
        //    //if (obj is Book)
        //        return this.id.CompareTo((obj as Book).getId());
        //    //return 0;
        //}

        public void addStudentList(Student student)
        {
            studentsList.Add(student);
        } 

        public void deleteStudentList(Student student)
        {
            studentsList.Remove(student);
        }

        public ArrayList getStudentList( )    
        {
            return studentsList;
        }

        public void addReservationList(Student student)
        {
            reservationList.Add(student);
        }

        public void deleteReservationList(Student student)
        {
            reservationList.Remove(student);
        }
        public ArrayList getReservationList()
        {
            return reservationList;
        }

        internal int getNumberOfBook()
        {
            return numberOfBook;
        }

        internal void setNumberOfBook(string p)
        {
            numberOfBook = Convert.ToInt32(p);
        }
        internal int getTotalNumberOfBook()
        {
            return totalNumberOfBook;
        }

        internal void setTotalNumberOfBook(string p)
        {
            numberOfBook += Convert.ToInt32(p) - totalNumberOfBook;
            totalNumberOfBook = Convert.ToInt32(p);
        }

        internal bool isExistOnStudentList(Student student)
        {
            foreach (Student item in studentsList)
            {
                if (item.getId().Equals(student.getId()))
                    return true;
            }
            return false;
        }

        internal bool isExistOnReservationList(Student student)
        {
            foreach (Student item in reservationList)
            {
                if (item.getId().Equals(student.getId()))
                    return true;
            }
            return false;
        }
        public void deleteThisBook()
        {
            foreach (Object student in studentsList)
            {
                ((Student)student).deleteBookList(this);
            }
        }
    }
}
