using System;
using System.Collections.Generic;
namespace Eternas
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack Game = new Stack();
            WhitePlay White = new WhitePlay();
            GreenPlay Green = new GreenPlay();
            int i, boncuksayisi = 32;
            for (i = 2; i < boncuksayisi + 2; i++)
            {

                if (i < 8)
                {
                    if (i % 2 == 0)
                    {
                        int s = White.ChoiceStick();
                        char color = White.color;
                        Game.AddStack(s, color);
                        Game.PrintStack();
                        //beyaz oynar
                    }
                    else
                    {
                        int s = Green.ChoiceStick();
                        char color = Green.color;
                        Game.AddStack(s, color);
                        Game.PrintStack();
                        //yeşil oynar
                    }
                    //henüz kimse kazanmış olamaz, no control

                }
                else
                {
                    if (i % 2 == 0)
                    {
                        int s = White.ChoiceStick();
                        char color = White.color;
                        Game.AddStack(s, color);
                        Game.PrintStack();
                        if (Game.ControlStack(s, color))
                        {
                            Console.WriteLine("Kazanan: Beyaz (W)");
                            Console.ReadKey();
                            return;
                        }
                        //beyaz oynar
                    }
                    else
                    {
                        int s = Green.ChoiceStick();
                        char color = Green.color;
                        Game.AddStack(s, color);
                        Game.PrintStack();
                        if (Game.ControlStack(s, color))
                        {
                            Console.WriteLine("Kazanan: Yeşil (G)");
                            Console.ReadKey();
                            return;
                        }
                        //yeşil oynar
                    }
                }

            }
            Console.Write("Berabere");
            Console.ReadKey();
            return;
        }
    }

    public class Stack
    {
        public Stack<char> S1 = new Stack<char>();
        public Stack<char> S2 = new Stack<char>();
        public Stack<char> S3 = new Stack<char>();
        public Stack<char> S4 = new Stack<char>();
        public Stack<char> S5 = new Stack<char>();
        public Stack<char> S6 = new Stack<char>();
        public Stack<char> S7 = new Stack<char>();
        public Stack<char> S8 = new Stack<char>();
        public void AddStack(int s, char color)
        {
            switch (s)
            {
                case 1:
                    S1.Push(color);
                    break;

                case 2:
                    S2.Push(color);
                    break;

                case 3:
                    S3.Push(color);
                    break;

                case 4:
                    S4.Push(color);
                    break;

                case 5:
                    S5.Push(color);
                    break;

                case 6:
                    S6.Push(color);
                    break;

                case 7:
                    S7.Push(color);
                    break;

                case 8:
                    S8.Push(color);
                    break;

            }
        }

        public void PrintStack()
        {
            Console.Write("S1 ");
            foreach (char oge in S1)
                Console.Write(oge);
            Console.WriteLine("");

            Console.Write("S2 ");
            foreach (char oge in S2)
                Console.Write(oge);
            Console.WriteLine("");

            Console.Write("S3 ");
            foreach (char oge in S3)
                Console.Write(oge);
            Console.WriteLine("");

            Console.Write("S4 ");
            foreach (char oge in S4)
                Console.Write(oge);
            Console.WriteLine("");

            Console.Write("S5 ");
            foreach (char oge in S5)
                Console.Write(oge);
            Console.WriteLine("");

            Console.Write("S6 ");
            foreach (char oge in S6)
                Console.Write(oge);
            Console.WriteLine("");

            Console.Write("S7 ");
            foreach (char oge in S7)
                Console.Write(oge);
            Console.WriteLine("");

            Console.Write("S8 ");
            foreach (char oge in S8)
                Console.Write(oge);
            Console.WriteLine("\n\n");
        }

        public bool ControlStack(int s, char color)
        {
            switch (s)
            {
                case 1:
                    char[] Dizi = S1.ToArray();
                    int counter = 0;
                    for (int i = 0; i < Dizi.Length; i++)
                    {
                        if (Dizi[i] == color)
                        {
                            counter++;
                        }
                    }
                    if (counter == 4)
                        return true;
                    else
                        return false;
                    //break;

                case 2:
                    char[] Dizi2 = S2.ToArray();
                    int counter2 = 0;
                    for (int i = 0; i < Dizi2.Length; i++)
                    {
                        if (Dizi2[i] == color)
                        {
                            counter2++;
                        }
                    }
                    if (counter2 == 4)
                        return true;
                    else
                        return false;
                    //break;

                case 3:
                    char[] Dizi3 = S3.ToArray();
                    int counter3 = 0;
                    for (int i = 0; i < Dizi3.Length; i++)
                    {
                        if (Dizi3[i] == color)
                        {
                            counter3++;
                        }
                    }
                    if (counter3 == 4)
                        return true;
                    else
                        return false;
                    //break;

                case 4:
                    char[] Dizi4 = S4.ToArray();
                    int counter4 = 0;
                    for (int i = 0; i < Dizi4.Length; i++)
                    {
                        if (Dizi4[i] == color)
                        {
                            counter4++;
                        }
                    }
                    if (counter4 == 4)
                        return true;
                    else
                        return false;
                    //break;

                case 5:
                    char[] Dizi5 = S5.ToArray();
                    int counter5 = 0;
                    for (int i = 0; i < Dizi5.Length; i++)
                    {
                        if (Dizi5[i] == color)
                        {
                            counter5++;
                        }
                    }
                    if (counter5 == 4)
                        return true;
                    else
                        return false;
                    //break;

                case 6:
                    char[] Dizi6 = S6.ToArray();
                    int counter6 = 0;
                    for (int i = 0; i < Dizi6.Length; i++)
                    {
                        if (Dizi6[i] == color)
                        {
                            counter6++;
                        }
                    }
                    if (counter6 == 4)
                        return true;
                    else
                        return false;
                    //break;

                case 7:
                    char[] Dizi7 = S7.ToArray();
                    int counter7 = 0;
                    for (int i = 0; i < Dizi7.Length; i++)
                    {
                        if (Dizi7[i] == color)
                        {
                            counter7++;
                        }
                    }
                    if (counter7 == 4)
                        return true;
                    else
                        return false;
                    //break;

                case 8:
                    char[] Dizi8 = S8.ToArray();
                    int counter8 = 0;
                    for (int i = 0; i < Dizi8.Length; i++)
                    {
                        if (Dizi8[i] == color)
                        {
                            counter8++;
                        }
                    }
                    if (counter8 == 4)
                        return true;
                    else
                        return false;
                    //break;

            }
            return false;
        }

    }



    public class WhitePlay //ÇİFT
    {
        public char color = 'W';
        public int ChoiceStick()
        {
            Random r = new Random();
            int sticknum = r.Next(1, 9);
            return sticknum;
        }

    }
    public class GreenPlay //TEK
    {
        public char color = 'G';
        public int ChoiceStick()
        {
            Random r = new Random();
            int sticknum = r.Next(1, 9);
            return sticknum;
        }
    }

}
