using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Kalk
    {
        List<int> chisla;
        List<char> znak;
        public Kalk()
        {
            chisla = new List<int>();
            znak = new List<char>();
        }
        public void vvod()
        {
            string vvod = Console.ReadLine();
            string[] massivchisel = vvod.Split(new char[] { '+', '-', '*', '/' });
            for (int i = 0; i < massivchisel.Length; i++)
            {
                chisla.Add(Convert.ToInt32(massivchisel[i]));
            }
            foreach (char i in vvod)
            {
                if (i == '+' || i == '-' || i == '*' || i == '/')
                {
                    znak.Add(i);
                }
            }
        }
        public void Search()
        {
            for (int v = 0; v <= znak.Count; v++)
            {
                for (int i = 0; i < znak.Count; i++)
                {
                    if (znak[i] == '*')
                    {
                        chisla[i] = chisla[i] * chisla[i + 1];
                        znak.RemoveAt(i);
                        chisla.RemoveAt(i + 1);
                    }
                    else if (znak[i] == '/')
                    {
                        chisla[i] = chisla[i] / chisla[i + 1];
                        znak.RemoveAt(i);
                        chisla.RemoveAt(i + 1);
                    }

                }
                for (int i = 0; i < znak.Count; i++)
                {
                    if (znak[i] == '+')
                    {
                        chisla[i] = chisla[i] + chisla[i + 1];
                        znak.RemoveAt(i);
                        chisla.RemoveAt(i + 1);
                    }
                    else if (znak[i] == '-')
                    {
                        chisla[i] = chisla[i] - chisla[i + 1];
                        znak.RemoveAt(i);
                        chisla.RemoveAt(i + 1);
                    }
                }
            }
            Console.WriteLine(chisla[0]);
        }
      
    }
}
