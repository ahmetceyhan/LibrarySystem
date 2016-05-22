using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l0._2
{
    class Password
    {
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

    }
}
