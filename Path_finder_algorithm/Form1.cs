using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Path_finder_algorithm
{
    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button[,] array = new Button[16,16];

        Punkt[,] tablica_punktow = new Punkt[16, 16];
        int x = 0;
        int y = 0;

        static string x_imie;
        static string y_imie;
        string[] tab_xy = new string[2] { x_imie, y_imie };

        int x_planszy = 16;
        int y_planszy = 16;
        int rozmiar_planszy;
        int top = 12;
        int left = 12;
             
        int liczba_klikniec = 0;

        int x_meta;
        int y_meta;

        int x_start;
        int y_start;

        int x_obecny;
        int y_obecny;

        //-------------------------------------------

        public void ZnajdzSciezkie(Punkt[,] tablica)
        {
            int visited_points = 0;

            int x_spr_N, y_spr_N;
            int x_spr_S, y_spr_S;
            int x_spr_W, y_spr_W;
            int x_spr_E, y_spr_E;

            double f_N, f_S, f_W, f_E;

            x_obecny = x_start;
            y_obecny = y_start;

            bool spr_W = false;
            bool spr_E = false;
            bool spr_S = false;
            bool spr_N = false;

            //---------------------------------------------------------------------------------
            while (true)
            {
                visited_points++;
                //----------------------------------------------------------------------------;
                x_spr_N = x_obecny;
                y_spr_N = y_obecny - 1;

                x_spr_S = x_obecny;
                y_spr_S = y_obecny + 1;

                x_spr_W = x_obecny - 1;
                y_spr_W = y_obecny;

                x_spr_E = x_obecny + 1;
                y_spr_E = y_obecny;

                //-------------- CHECK IF END --------------------------------------------------------------
                if (x_spr_N == x_meta && y_spr_N == y_meta)
                {
                    break;
                }
                else if (x_spr_S == x_meta && y_spr_S == y_meta)
                {
                    break;
                }
                else if (x_spr_W == x_meta && y_spr_W == y_meta)
                {
                    break;
                }
                else if (x_spr_E == x_meta && y_spr_E == y_meta)
                {
                    break;
                }
                //-------CHECK IF POINT BELONGS TO THE ARRAY------------------------------------
                for (int i = 0; i <= 15; i++)
                {
                    for (int j = 0; j <= 15; j++)
                    {
                        if (x_spr_N == tablica[i, j].x && y_spr_N == tablica[i, j].y)
                        {
                            spr_N = true;
                            Console.WriteLine("spr_N nalezy do tablicy");
                            break;
                        }
                    }
                }
                //----------------------------
                for (int i = 0; i <= 15; i++)
                {
                    for (int j = 0; j <= 15; j++)
                    {
                        if (x_spr_W == tablica[i, j].x && y_spr_W == tablica[i, j].y)
                        {
                            spr_W = true;
                            Console.WriteLine("spr_W nalezy do tablicy");
                            break;
                        }
                    }
                }
                //-----------------------------
                for (int i = 0; i <= 15; i++)
                {
                    for (int j = 0; j <= 15; j++)
                    {
                        if (x_spr_E == tablica[i, j].x && y_spr_E == tablica[i, j].y)
                        {
                            spr_E = true;
                            Console.WriteLine("spr_E nalezy do tablicy");
                            break;
                        }
                    }
                }
                //----------------------------
                for (int i = 0; i <= 15; i++)
                {
                    for (int j = 0; j <= 15; j++)
                    {
                        if (x_spr_S == tablica[i, j].x && y_spr_S == tablica[i, j].y)
                        {
                            spr_S = true;
                            Console.WriteLine("spr_S nalezy do tablicy");
                            break;
                        }
                    }
                }
                //-------CHECK IF VISITED-------------------------------------------------------
                if (spr_N == true)
                {
                    Console.WriteLine("spr_N = true");
                    if (tablica[x_spr_N, y_spr_N].visited == false)
                    {
                        Console.WriteLine("spr_N.visited = false");
                        f_N = (visited_points * 1) + Math.Sqrt(Math.Pow(x_meta - x_spr_N, 2) + Math.Pow(y_meta - y_spr_N, 2));
                    }
                    else f_N = 1000;
                }
                else f_N = 100;
                //--------------------------------------------
                if (spr_S == true)
                {
                    if (tablica[x_spr_S, y_spr_S].visited == false)
                    {
                        f_S = (visited_points * 1) + Math.Sqrt(Math.Pow(x_meta - x_spr_S, 2) + Math.Pow(y_meta - y_spr_S, 2));
                    }
                    else f_S = 1000;
                }
                else f_S = 100;
                //--------------------------------------------
                if (spr_W == true)
                {
                    if (tablica[x_spr_W, y_spr_W].visited == false)
                    {
                        f_W = (visited_points * 1) + Math.Sqrt(Math.Pow(x_meta - x_spr_W, 2) + Math.Pow(y_meta - y_spr_W, 2));
                    }
                    else f_W = 1000;
                }
                else f_W = 100;
                //--------------------------------------------
                if (spr_E == true)
                {
                    if (tablica[x_spr_E, y_spr_E].visited == false)
                    {
                        f_E = (visited_points * 1) + Math.Sqrt(Math.Pow(x_meta - x_spr_E, 2) + Math.Pow(y_meta - y_spr_E, 2));
                    }
                    else f_E = 1000;
                }
                else f_E = 100;
                //--------------------------------------------------------------------------------
                //-----FIND min_f-----------------------------------------------------------------
                double[] wyniki_f = new double[] { f_N, f_E, f_S, f_W };

                double min_f = wyniki_f[0];
                for (int i = 1; i < wyniki_f.Length; i++)
                {
                    if (min_f > wyniki_f[i])
                    {
                        min_f = wyniki_f[i];
                    }
                }               
                //--------------------------------------------------------------------------------

                if (min_f == f_N)
                {
                    tablica[x_spr_N, y_spr_N].stan = 'O';
                    tablica[x_spr_N, y_spr_N].visited = true;

                    x_obecny = x_spr_N;
                    y_obecny = y_spr_N;

                }

                else if (min_f == f_S)
                {
                    tablica[x_spr_S, y_spr_S].stan = 'O';
                    tablica[x_spr_S, y_spr_S].visited = true;

                    x_obecny = x_spr_S;
                    y_obecny = y_spr_S;                   
                }

                else if (min_f == f_E)
                {
                    tablica[x_spr_E, y_spr_E].stan = 'O';
                    tablica[x_spr_E, y_spr_E].visited = true;

                    x_obecny = x_spr_E;
                    y_obecny = y_spr_E;                  
                }

                else if (min_f == f_W)
                {
                    tablica[x_spr_W, y_spr_W].stan = 'O';
                    tablica[x_spr_W, y_spr_W].visited = true;

                    x_obecny = x_spr_W;
                    y_obecny = y_spr_W;
                }
            }
        }

//---------------------------------------------------------------------------------------------------
        public void WypiszStan(Punkt [,] tablica, object sender)
        {
            Button button = sender as Button;
            for (int i = 0; i <= 15; i++)
            {               
                for (int j = 0; j <= 15; j++)
                {
                    if(tablica[i, j].stan == 'O')
                    {
                        array[i,j+1].BackColor = Color.Yellow;
                    }
                }
            }
        }
//-----------------------------------------------------------------------------------------------------
        public void ResetujStan(Punkt [,] tablica, object sender)
        {
            Button button = sender as Button;
            for (int i = 0; i <= 15; i++)
            {
                for (int j = 0; j <= 15; j++)
                {
                    if (tablica[i, j].stan == 'O' || tablica[i, j].stan == 'A' || tablica[i, j].stan == 'B')
                    {
                        tablica[i, j].stan = 'X';
                        tablica[i, j].visited = false;
                        array[i, j+1].BackColor = Color.Gainsboro;
                    }
                }
            }

            liczba_klikniec = 0;
            top = 12;
            left = 12;
        }
//---------------------------------------------------------------------------------------------------
        protected void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            liczba_klikniec++;

            if (liczba_klikniec == 1)
            {
                button.BackColor = Color.Green;
                for (int i = 0; i <= 15; i++)
                {
                    for (int j = 0; j <= 15; j++)
                    {
                        tab_xy = button.Name.Split(';');

                        if(tablica_punktow[i,j].x == int.Parse(tab_xy[0])&& tablica_punktow[i,j].y == int.Parse(tab_xy[1]) )
                        {
                            x_start = tablica_punktow[i, j].x;
                            y_start = tablica_punktow[i, j].y;
                            tablica_punktow[i, j].stan = 'A';
                            tablica_punktow[i, j].visited = true; 
                        }                       
                    }
                }                
                x_obecny = x_start;
                y_obecny = y_start;
            }

            if (liczba_klikniec == 2)
            {
                button.BackColor = Color.Red;
                for (int i = 0; i <= 15; i++)
                {
                    for (int j = 0; j <= 15; j++)
                    {
                        tab_xy = button.Name.Split(';');

                        if (tablica_punktow[i, j].x == int.Parse(tab_xy[0]) && tablica_punktow[i, j].y == int.Parse(tab_xy[1]))
                        {
                            x_meta = tablica_punktow[i, j].x;
                            y_meta = tablica_punktow[i, j].y;
                            tablica_punktow[i, j].stan = 'B';
                            tablica_punktow[i, j].visited = true;
                        }
                    }
                }
            }

            if(liczba_klikniec > 2)
            {
                button.BackColor = Color.Black;
                button.Enabled = false;
            }
        }
//--------------------------------------------------------------------------------------
        private void start_Click(object sender, EventArgs e)
        {         
            for (int i = 0; i <= 15; i++)
            {
                for (int j = 0; j <= 15; j++)
                {
                    tablica_punktow[i, j] = new Punkt(i, j, 'X', "punkt" + i + j, false);
                }
            }

            start.Enabled = false;
            rozmiar_planszy = x_planszy * y_planszy;

            for (int i = 0; i <= 15; i++)
            {
                for(int j = 0; j <= 15; j++)
                {
                    left = 12 + ((i * 35) + 2);
                    top = 12 + ((j * 35) + 2);
                    array[i,j] = new Button();
                    array[i,j].Left = left;
                    array[i,j].Top = top;
                    array[i,j].Name = x.ToString() + ";" + y.ToString();
                    array[i,j].Height = 35;
                    array[i,j].Width = 35;
                    array[i,j].Click += new EventHandler(button_Click);
                    array[i,j].BackColor = Color.Gainsboro;
                    //array[i, j].Text = i +";"+ j;
                    this.Controls.Add(array[i,j]);
                    
                    x = i;
                    y = j;
                }               
            }           
        }
//-----------------------------------------------------------------------------------------
  
        private void find_path_Click(object sender, EventArgs e)
        {
            ZnajdzSciezkie(tablica_punktow);
            WypiszStan(tablica_punktow, array);
        }

        private void RESET_Click(object sender, EventArgs e)
        {
            ResetujStan(tablica_punktow, array);
        }
    }


//-------------------------------KLASA PUNKT------------------------------------------------------------
    public class Punkt
    {
        //------------wlasciwosci------------------------------------
        public int x, y;
        public char stan;
        public string nazwa;
        public bool visited;
        // 'X' - domyslnie; 'O' - czesc sciezki; 'A' - start; 'B' - meta  

        //------------METODY-----------------------------------------
        public Punkt(int wsp_x, int wsp_y, char state, string name, bool odw) //konstruktor
        {
            x = wsp_x;
            y = wsp_y;
            stan = state;
            nazwa = name;
            visited = odw;
        }
    }
}
