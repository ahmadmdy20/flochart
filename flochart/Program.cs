using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flochart
{
    class mashin
    {
        //متغیر جمع
        double j1, j2, jkol;

        //متغیر تفریق
        double t1, t2, tkol;
        public void jaminput()
        {
            Console.WriteLine("Enter First number?");
            j1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number?");
            j2 = Convert.ToDouble(Console.ReadLine());
            jkol = j1 + j2;


        }
        public void jamprint()
        {
            
            
            Console.Write("javab  : "+jkol);
            Console.ReadKey();
            Console.Clear();

            
        }
        public void tafinput()
        {
            Console.WriteLine("Enter First number?");
            t1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second number?");
            t2 = Convert.ToDouble(Console.ReadLine());
            tkol = t1 - t2;
        }
        public void tafprint()
        {
            Console.WriteLine("javab  : "+tkol);
            Console.ReadKey();
            Console.Clear();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int baz, baz2;
            while (true)
            {
                
            start:
                string entekhabM;
                Console.WriteLine("Start?");
                Console.WriteLine("Welcome to robot!");
                Console.WriteLine("1==Mashin hesab");
                Console.WriteLine("2==sang kagaz geychi");
                Console.WriteLine("3==game");
                mashin mashinhesab = new mashin();
                string entekhab = Console.ReadLine();
                if (entekhab == "1")
                {
                    Console.Clear();
                jam1:
                    Console.WriteLine("1==jam");
                    Console.WriteLine("2==tafrig");
                    entekhabM = Console.ReadLine();

                    if (entekhabM == "1")
                    {
                        mashinhesab.jaminput();
                        mashinhesab.jamprint();
                        Console.WriteLine(" Enter Clear !");
                       
                        Console.ReadKey();
                        Console.Clear();
                        goto start;
                    }

                    else if (entekhabM == "2")
                    {
                        mashinhesab.tafinput();
                        mashinhesab.tafprint();
                        Console.WriteLine(" Enter Clear !");
                        Console.ReadKey();
                        Console.Clear();
                        goto jam1;
                    }
                    else
                    {
                        Console.WriteLine("Eror");
                        Console.ReadKey();
                        Console.Clear();
                        goto jam1;
                    }
                }
                else if (entekhab == "2")
                {
                dobar:
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1==sang");
                    Console.WriteLine("2==gaychi");
                    Console.WriteLine("3==khagaz");
                    int baziSKG = Convert.ToInt32(Console.ReadLine());
                    int r;
                    Random random = new Random();
                    r = random.Next(1, 3);
                    Console.WriteLine("Number Compeuter!"+r);
                    Console.ReadKey();
                    if (baziSKG == 1 && r == 2 || baziSKG == 2 && r == 3 || baziSKG == 3 && r == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("User Win     enter to ready game? ");
                        Console.ReadKey();
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Bazgasht be bazi==1");
                        Console.WriteLine("Bazgasht be home==2");
                        baz2 = Convert.ToInt32(Console.ReadLine());
                        if (baz2 == 1)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                           goto dobar;
                        }
                        else if (baz2 == 2)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            
                            goto start;
                        }
                       
                    }
                    else if (baziSKG == r)
                    {
                        Console.WriteLine("Mosavi          enter to redy  game? ");
                        Console.ReadKey();
                        Console.Clear();
                        goto dobar;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Computer Win      enter to ready game? ");
                        Console.ReadKey();
                        Console.Clear();
                        goto dobar;
                    }
                }
                else if(entekhab=="3")
                {
                poo:
                    Console.WriteLine("Enter num aval");
                    int had = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    for (int i = 1; i <= 10; i++)
                    {
                        int you = Convert.ToInt32(Console.ReadLine());
                        if (had == you)
                        {
                            Console.WriteLine("Bordy to khat  : " + i);
                            Console.WriteLine("Enter clear !");
                            Console.ReadKey();
                            Console.WriteLine("Bazgasht be bazi == 1");
                            Console.WriteLine("Bazgasht be home == 2");
                             baz = Convert.ToInt32(Console.ReadLine());
                             if (baz == 1)
                             {
                                 Console.Clear();
                                goto poo;
                             }
                             else
                             {
                                 Console.Clear();
                                 goto start;
                             }
                           
                            
                        }
                        else if (had < you) 
                        {
                            Console.WriteLine("Kochik tar");
                        }
                        else if (had > you)
                        {
                            Console.WriteLine("bozorg tar");
                        }
                        else
                        {
                            Console.WriteLine("Eror 3");
                            Console.ReadKey();
                            Console.Clear();
                            goto poo;
                        }
                        
                    }
                }

                else
                {
                    Console.WriteLine("Eror 2");
                    Console.ReadKey();
                    Console.Clear();
                    goto start;

                }
            }
         
            

            Console.ReadKey();
          
            
            
          
        }
    }
}
