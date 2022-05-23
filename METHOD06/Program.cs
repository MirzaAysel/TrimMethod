using System;
using System.Collections.Generic;
using System.Linq;

namespace METHOD06
{
    class Program
    {
        static void Main(string[] args)
        {


            string str = " Mirze Aysel ";
            List<char> list = str.ToList();
            var index = list.FindIndex(f => !(f.ToString() == " "));

            //MyMethodTrimStart

            for (int i = 0; i <= index; i++)
            {
                if (list[i].ToString() == " ")
                {

                    list.RemoveAt(i);
                }

            }
            foreach (var item in list)
            {
                Console.Write(item);

            }

            Console.WriteLine("");
            //MyMethodTrimEnd

            var lastindex = list.FindLastIndex(f => !(f.ToString() == " "));

            for (int i = lastindex; i <= list.Count; i++)
            {
                if (list[i].ToString() == " ")
                {

                    list.RemoveAt(i);
                }

            }
            foreach (var item in list)
            {
                Console.Write(item);


            }


            Console.WriteLine("");

           { 
            //MyMethodTrim
            for (int i = 0; i <= index; i++)
            {
                for (int j = lastindex; j <= list.Count; j++)
                {
                    if (list[i].ToString() == " ")
                    {
                        if (list[j].ToString() == " ")
                        {
                            list.RemoveAt(i);
                            list.RemoveAt(j);
                        }
                    }
                }
            }
            foreach (var item in list)
            {
                Console.Write(item);
                   
            }

        }
        }
    }
}
