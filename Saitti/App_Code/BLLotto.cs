﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLotto
/// </summary>
/*public class BLLotto
{
    public BLLotto()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}*/

/*using System;
using System.Collections.Generic;
using System.Linq;*/
using System.Text;
using System.Threading.Tasks;



/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using System.Windows;
//haukku using System.Windows.Controls;
//haukku using System.Windows.Data;
//haukku using System.Windows.Documents;
using System.Windows.Input;
//haukku using System.Windows.Media;
//haukku using System.Windows.Media.Imaging;
//haukku using System.Windows.Navigation;
//haukku using System.Windows.Shapes;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace JAMK.ICT.Data2//Tehtava2
{
    public static class Lotto
    {
        public static string Luvut(int monta, int alue, Random rnd)
        {
            //comboBox.Items.Add("Sunday");
            //comboBox.Items.Add("Monday");
            //Random rnd = new Random();
            int numero, n, m;
            //taul = new int[7];
            int[] taul = new int[monta];
            int[] taul2 = new int[alue + 1];
            int[] kaytetty = new int[7];

            string palautus = "";

            /*for (int m = 0; m < drawns; m++)
            {*/
            for (n = 0; n < alue + 1; n++) taul2[n] = n;

            /*for (n = 0; n < 7; n++)
            {
                taul[n] = numero = taul2[rnd.Next(1, 40-n)];
                for (m = numero; m < 39-n; m++)
                {
                    taul2[m] = taul2[m + 1];
                }
                //taul2[m] = taul2[m + 1];
                if(m==(39-n)) taul2[m] = taul2[m + 1];
            }*/

            /*for (n = 0; n < 7; n++)
            {
                m=rnd.Next(1, 40);
                kaytetty[n] = m;
                for(numero= m;numero++<40- n; numero++)
                {
                    taul2[numero] = numero;
                }
            }*/

            for (n = 0; n < monta; n++)
            {
                taul[n] = numero = taul2[rnd.Next(1, alue - n)];

                taul2[numero] = taul2[alue - n]; // HAHAA 39 ei +1=40
            }

            /*for (n = 0; n < 7; n++)
            {
                numero = rnd.Next(1, 39+1); // creates a number between 1 and 12
                                          //numero = 10;
                taul[n] = numero;
            }*/
            for (n = 0; n < monta; n++)
            {
                //numero = rnd.Next(1, 39+1); // creates a number between 1 and 12
                //numero = 10;
                palautus += " " + taul[n].ToString();
            }
            palautus += "\n";
            //            }

            return palautus;
        }

        public static string Viking(int drawns)
        {
            //comboBox.Items.Add("Sunday");
            //comboBox.Items.Add("Monday");
            Random rnd = new Random();
            int numero, n;
            //taul = new int[7];
            int[] taul = new int[6];
            string palautus = "";

            for (int m = 0; m < drawns; m++)
            {
                for (n = 0; n < 6; n++)
                {
                    numero = rnd.Next(1, 48 + 1); // creates a number between 1 and 12
                                                  //numero = 10;
                    taul[n] = numero;
                }
                for (n = 0; n < 6; n++)
                {
                    numero = rnd.Next(1, 48 + 1); // creates a number between 1 and 12
                                                  //numero = 10;
                    palautus += " " + numero.ToString();
                }
                palautus += "\n";
            }

            return palautus;
        }

        public static string Euro(int drawns)
        {
            //comboBox.Items.Add("Sunday");
            //comboBox.Items.Add("Monday");
            Random rnd = new Random();
            int numero, n;
            //taul = new int[7];
            int[] taul = new int[5];
            string palautus = "";

            for (int m = 0; m < drawns; m++)
            {
                for (n = 0; n < 5; n++)
                {
                    numero = rnd.Next(1, 50 + 1); // creates a number between 1 and 12
                                                  //numero = 10;
                    taul[n] = numero;
                }
                for (n = 0; n < 5; n++)
                {
                    numero = rnd.Next(1, 50 + 1); // creates a number between 1 and 12
                                                  //numero = 10;
                    palautus += " " + numero.ToString();
                }
                palautus += "  ";
                for (n = 0; n < 2; n++)
                {
                    numero = rnd.Next(1, 8 + 1); // creates a number between 1 and 12
                                                 //numero = 10;
                    palautus += " " + numero.ToString();
                }
                palautus += "\n";
            }



            return palautus;
        }
    }
}