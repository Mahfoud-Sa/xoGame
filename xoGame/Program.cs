using System;

namespace xoGame
{
    class Program
    {
        static void InfTable(int x, int o)
        {
            Console.WriteLine("                    ////////////////////////////////////////////////////////////////////////////\n" +
                              "                    ////////////////////////////////////////////////////////////////////////////\n" +
                              "                    ///////                   X                      O                   ///////\n" +
                             $"                    ///////                   {x}                      {o}                   ///////\n" +
                              "                    ///////                                                              ///////\n ");
        }
        static void PrintShap(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine(" ");
            }
        }
        
        static bool In(int[] arry, int value)
        {
            bool temp = false;
            foreach (int elem in arry)
            {
                if (elem == value)
                    temp = true;

            }
            return temp;

        }
        static void AdX(string[,] matrix, int row_, int column)
        {
            int col = column;///first col =0 second=22 thired =46
            

int row = row_;// first row=0 second row =6 third row =13

            matrix[0 + row, 9 + col] = " xx";//number of index
            matrix[0 + row, 10 + col] = "";
            matrix[0 + row, 11 + col] = "";
            matrix[0 + row, 18 + col] = " xx";
            matrix[0 + row, 19 + col] = "";
            matrix[0 + row, 20 + col] = "";

            matrix[1 + row, 11 + col] = " xx";
            matrix[1 + row, 12 + col] = "";
            matrix[1 + row, 13 + col] = "";
            matrix[1 + row, 16 + col] = " xx";
            matrix[1 + row, 17 + col] = "";
            matrix[1 + row, 18 + col] = "";

            matrix[2 + row, 13 + col] = "";
            matrix[2 + row, 15 + col] = "xxx";
            matrix[2 + row, 16 + col] = "";


            matrix[3 + row, 11 + col] = " xx";
            matrix[3 + row, 12 + col] = "";
            matrix[3 + row, 13 + col] = "";
            matrix[3 + row, 16 + col] = " xx";
            matrix[3 + row, 17 + col] = "";
            matrix[3 + row, 18 + col] = "";

            matrix[4 + row, 9 + col] = " xx";
            matrix[4 + row, 10 + col] = "";
            matrix[4 + row, 11 + col] = "";
            matrix[4 + row, 18 + col] = " xx";
            matrix[4 + row, 19 + col] = "";
            matrix[4 + row, 20 + col] = "";


        }
        static void AdO(string[,] matrix, int row_, int column)
        {
            int col = column;///first col =0 second=22 thired =46
            

int row = row_;// first row=0 second row =6 third row =13

            matrix[0 + row, 14 + col] = "ooo";//number of index
            matrix[0 + row, 16 + col] = "";
            matrix[0 + row, 17 + col] = "";




            matrix[1 + row, 13 + col] = "oo";
            matrix[1 + row, 12 + col] = "";
            matrix[1 + row, 18 + col] = "oo";
            matrix[1 + row, 17 + col] = "";

            matrix[2 + row, 11 + col] = "o";
            matrix[2 + row, 19 + col] = "o";



            matrix[3 + row, 13 + col] = "oo";
            matrix[3 + row, 12 + col] = "";
            matrix[3 + row, 18 + col] = "oo";
            matrix[3 + row, 17 + col] = "";

            matrix[4 + row, 14 + col] = "ooo";//number of index
            matrix[4 + row, 15 + col] = "";
            matrix[4 + row, 16 + col] = "";


        }
        static bool IsEmty(int[] arry, int x)
        {
            return arry[x - 1] == 0;
        }
        static bool Win_x(string[,] arry)
        {
            // function to chick if x won

            if (arry[0, 9] == " xx" && arry[0, 9 + 22] == " xx" && arry[0, 9 + 46] == " xx" || arry[6, 9] == " xx" && arry[6, 9 + 22] == " xx" && arry[6, 9 + 46] == " xx" || arry[13, 9] == " xx" && arry[13, 9 + 22] == " xx" && arry[13, 9 + 46] == " xx"
|| arry[0, 9] == " xx" && arry[6, 9] == " xx" && arry[13, 9] == " xx" || arry[0, 9 + 22] == " xx" && arry[6, 9 + 22] == " xx" && arry[13, 9 + 22] == " xx" || arry[0, 9 + 46] == " xx" && arry[6, 9 + 46] == " xx" && arry[13, 9 + 46] == " xx"
|| arry[0, 9] == " xx" && arry[6, 9 + 22] == " xx" && arry[13, 9 + 46] == " xx" || arry[0, 9 + 46] == " xx" && arry[6, 9 + 22] == " xx" && arry[13, 9] == " xx")
            {
                return true;

            }
            return false;
        }
        static bool Win_o(string[,] arry)
        {
            // function to chick if o won


            if (arry[0, 14] == "ooo" && arry[0, 14 + 22] == "ooo" && arry[0, 14 + 46] == "ooo" || arry[6, 14] == "ooo" && arry[6, 14 + 22] == "ooo" && arry[6, 14 + 46] == "ooo" || arry[13, 14] == "ooo" && arry[13, 14 + 22] == "ooo" && arry[13, 14 + 46] == "ooo"
             || arry[0, 14] == "ooo" && arry[6, 14] == "ooo" && arry[13, 14] == "ooo" || arry[0, 14 + 22] == "ooo" && arry[6, 14 + 22] == "ooo" && arry[13, 14 + 22] == "ooo" || arry[0, 14 + 46] == "ooo" && arry[6, 14 + 46] == "ooo" && arry[13, 14 + 46] == "ooo"
             || arry[0, 14] == "ooo" && arry[6, 14 + 22] == "ooo" && arry[13, 14 + 46] == "ooo" || arry[0, 14 + 46] == "ooo" && arry[6, 14 + 22] == "ooo" && arry[13, 14] == "ooo")
            {
                return true;

            }
            return false;
        }

        static bool Chick_win(string[,] array,ref int x, ref int o, ref int c,  ref int countertostop,int playerchoice, ref int PlayAgain)
            {

                if (Win_x(array))
                {
                    
                    
                    Console.Clear();

                    c = 1;

                    x += 1;// the x denoted to the number of x win
                if (playerchoice == 1)//color
                {
                    if (x > o) { Console.ForegroundColor = ConsoleColor.Green; }
                    else if (o > x) { Console.ForegroundColor = ConsoleColor.Red; }
                    else if (o == x) { Console.ForegroundColor = ConsoleColor.White; }
                }
                else if (playerchoice == 2)
                {
                    if (o > x) { Console.ForegroundColor = ConsoleColor.Green; }
                    else if (x > o) { Console.ForegroundColor = ConsoleColor.Red; }
                    else if (o == x) { Console.ForegroundColor = ConsoleColor.White; }
                }


                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n" +
                            "                    ////////////////////  XX      XX  /////  XX      XX  /////  XX      XX  ////////////////////\n" +
                            "                    ////////////////////    XX  XX    /////    XX  XX    /////    XX  XX    ////////////////////\n" +
                            "                    ////////////////////      XX      /////      XX      /////      XX      ////////////////////\n" +
                            "                    ////////////////////    XX  XX    /////    XX  XX    /////    XX  XX    ////////////////////\n" +
                            "                    ///////////////////   XX       XX /////  XX       XX /////  XX       XX ////////////////////\n" +
                            "                    press 1 to play Again \n" +
                            "                    press 2  Exit...\n");
                     PlayAgain = ChickNumber(1, 2, " ");
                    return true;
                 }
                else if (Win_o(array))
                {
                    c = 2;
                    o += 1;
                    if (playerchoice == 1)//color
                    {
                        if (x > o) { Console.ForegroundColor = ConsoleColor.Green; }
                        else if (o > x) { Console.ForegroundColor = ConsoleColor.Red; }
                        else if (o == x) { Console.ForegroundColor = ConsoleColor.White; }
                    }
                    else if (playerchoice == 2)
                    {
                        if (o > x) { Console.ForegroundColor = ConsoleColor.Green; }
                        else if (x > o) { Console.ForegroundColor = ConsoleColor.Red; }
                        else if (o == x) { Console.ForegroundColor = ConsoleColor.White; }
                    }

                    Console.Clear();
                    
                    Console.Write("\n\n\n\n\n\n\n\n\n\n" +
                               "                    ////////////////////      ooo      /////      ooo      /////      ooo      ////////////////////\n" +
                               "                    ////////////////////    oo   oo    /////    oo   oo    /////    oo   oo    ////////////////////\n" +
                               "                    ////////////////////   oo     oo   /////   oo     oo   /////   oo     oo   ////////////////////\n" +
                               "                    ////////////////////    oo   oo    /////    oo   oo    /////    oo   oo    ////////////////////\n" +
                               "                    ///////////////////       ooo      /////      ooo      /////      ooo      ////////////////////\n" +
                               "                    press 1 to play Again \n" +
                               "                    press 2  Exit...\n");
                PlayAgain = ChickNumber(1, 2, " ");
                return true;

                }// chick if o won

                else if (countertostop == 9)
                {
                    if (playerchoice == 1)//color
                    {
                        if (x > o) { Console.ForegroundColor = ConsoleColor.Green; }
                        else if (o > x) { Console.ForegroundColor = ConsoleColor.Red; }
                        else if (o == x) { Console.ForegroundColor = ConsoleColor.White; }
                    }
                    else if (playerchoice == 2)
                    {
                        if (o > x) { Console.ForegroundColor = ConsoleColor.Green; }
                        else if (x > o) { Console.ForegroundColor = ConsoleColor.Red; }
                        else if (o == x) { Console.ForegroundColor = ConsoleColor.White; }
                    }
                    Console.Clear();


                    Console.Write("\n\n\n\n\n\n\n\n\n\n" +
                    " ////////////////////  XX      XX  /////      ooo      /////  XX      XX  /////      ooo      ////////////////////\n" +
                    " ///////////////////     XX  XX    /////    oo   oo    /////    XX  XX    /////    oo   oo    ////////////////////\n" +
                    " ///////////////////       XX      /////   oo     oo   /////      XX      /////   oo     oo   ////////////////////\n" +
                    " ///////////////////     XX  XX    /////    oo   oo    /////    XX  XX    /////    oo   oo    ////////////////////\n" +
                    " ///////////////////   XX      XX  /////      ooo      /////  XX      XX  /////      ooo      ////////////////////\n" +
                    "                    press Enter to play Again \n" +
                    "                    press 1 to play Again \n" +
                    "                    press 2  Exit...\n");
                PlayAgain = ChickNumber(1, 2, " ");
                return true;
                }

            return false;
        }
        static int ChickNumber(int strt, int end,string message)
        {
            Console.WriteLine(message);

            string numbers = "0123456789";

            while (true)
            {
                string temp = Console.ReadLine();

                if (numbers.Contains(temp) == false || temp == "")
                {
                    Console.WriteLine("You Have Chose a Number ");
                    continue;
                }
                int x = Convert.ToInt32(temp);
                if (x > strt - 1 && x < end + 1)
                {
                    return x;

                }
                Console.WriteLine($"You Have Chose Between {strt} To {end} ");
                continue;
            }
        }
        static void Main(string[] args)
            {
            int xx = 1;
            do
            {
                
                int counter = 0;//counter to kner who to play x or o
                int NuOfXWin = 0;
                int NuOfOWin = 0;
                int playerchoice = 1;// varible to choice between x or o to start play
                Console.WriteLine("\n \n \n \n \n \n \n \n \n \n" +
                           "                    XOXOXOXOXOXOXOXOXOXOXOXO OXXOXOXOXOXOXOXOXOXOXOX XOXOXXOXOXOXOXOXOXOXOXOX\n" +
                           "                    XOXOXOXOXOXOXOXOXOXOXOXO OXXOXOXOXOXOXOXOXOXOXOX XOXOXXOXOXOXOXOXOXOXOXOX\n" +
                           "                    XXXXXXXXXXXXXXXXXXXXXXXO   WELCOME TO XO GAME    XOOOOOOOOOOOOOOOOOOOOOOO\n" +
                           "                    XOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOX\n" +
                           "                    XOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOX\n" +
                           "                    PRESS ANY KEY TO START...");
                Console.ReadKey();
                Console.Clear();
                playerchoice =counter= ChickNumber(1, 2, "\n \n \n \n " +

                            "                    ////////////////////////////////////////////////////////////////////////\n" +
                            "                    ////////////////////////////////////////////////////////////////////////\n" +
                            "                    ////////////////////////   WELCOME TO XO GAME   ////////////////////////\n" +
                            "                    ////////////////////////////////////////////////////////////////////////\n" +
                            "                    ////////////////////////////////////////////////////////////////////////\n" +
                            "\n \n \n \n" +

                            "                    //////////////////// XX      XX  /////      ooo      ///////////////////\n" +
                            "                    ///////////////////    XX  XX    /////    oo   oo    ///////////////////\n" +
                            "                    ///////////////////      XX      /////   oo     oo   ///////////////////\n" +
                            "                    ///////////////////    XX  XX    /////    oo   oo    ///////////////////\n" +
                            "                    ///////////////////  XX      XX  /////      ooo      ////////////////// \n" +
                            "                    press 1 to start play with X \n" +
                            "                    and 2 to start play with O");
               

            Start: //Start the game

                //game counters
                string[,] body = {
                   /* first line*/  {"                       ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "},
                                    {"                       ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," " },
                                    {"                       ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," " },
                                    {"                       ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "},
                                    {"                       ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," " },
                                    {"                       ", "_", "_","_", "_","_","_", "_", "_","_", "_","_","_", "_", "_","_", "_","_","_", "_", "_","_", "_","_","|", "_", "_", "_","_", "_","_","_", "_", "_","_", "_","_","_", "_", "_","_", "_","_","_", "_", "_","_", "_","_","|", "_", "_", "_","_", "_","_","_", "_", "_","_", "_","_","_", "_", "_","_", "_","_","_", "_", "_","_", "_","_" },
                               
                  /* second line*/  {"                       ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "},
                                    {"                       ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," " },
                                    {"                       ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," " },
                                    {"                       ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "},
                                    {"                       ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," " },
                                    {"                       ", "_", "_","_", "_","_","_", "_", "_","_", "_","_","_", "_", "_","_", "_","_","_", "_", "_","_", "_","_","|", "_", "_", "_","_", "_","_","_", "_", "_","_", "_","_","_", "_", "_","_", "_","_","_", "_", "_","_", "_","_","|", "_", "_", "_","_", "_","_","_", "_", "_","_", "_","_","_", "_", "_","_", "_","_","_", "_", "_","_", "_","_" },
                                
                 /* third line*/    {"                       ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "},
                                    {"                       ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," " },
                                    {"                       ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," " },
                                    {"                       ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "},
                                    {"                       ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," " },
                                    {"                       ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," ","|", " ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," "," ", " ", " "," ", " "," " }
            };
                int[] placplayed = new int[9];
                int[] full = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };//array that 
                string x;//number that user define 
                string Num = "123456789";//string that allow the user to choice
                int countToStop = 0;//counter that use to knew if the body of xo is full
                int PlayAgain = 1;
                int UsertChoice = 1;

                Console.Clear();
                while (true)
                {
                    Console.Write("\n \n \n \n");
                    InfTable(NuOfXWin, NuOfOWin);
                    PrintShap(body);


                    while (true)// to chick the number if it between 1-9
                    {

                        UsertChoice = ChickNumber(1, 9, " ");

                        if (In(placplayed, UsertChoice) == false)//to chick if the place is all ready taken
                        {
                            placplayed[UsertChoice - 1] = UsertChoice;//to add number that user choice to array
                            countToStop += 1;

                            break;
                        }
                        Console.Write("This Plase is was tacking\n try another place\n");
                    }// to chick the input frome user

                    //choce number to put in it's correct place
                    switch (UsertChoice)//to print the shap in it,s place
                    {

                        case 1:
                            if (counter % 2 != 0)
                            {
                                AdX(body, 0, 0);

                            }
                            else
                            {
                                AdO(body, 0, 0);
                            }
                            counter += 1;
                            break;
                        case 2:
                            if (counter % 2 != 0)
                            {
                                AdX(body, 0, 22);

                            }
                            else
                            {
                                AdO(body, 0, 22);
                            }
                            counter += 1;
                            break;
                        case 3:

                            if (counter % 2 != 0)
                            {
                                AdX(body, 0, 46);

                            }
                            else
                            {
                                AdO(body, 0, 46);
                            }
                            counter += 1;
                            break;
                        case 4:

                            if (counter % 2 != 0)
                            {
                                AdX(body, 6, 0);

                            }
                            else
                            {
                                AdO(body, 6, 0);
                            }
                            counter += 1;
                            break;
                        case 5:

                            if (counter % 2 != 0)
                            {
                                AdX(body, 6, 22);

                            }
                            else
                            {
                                AdO(body, 6, 22);
                            }
                            counter += 1;
                            break;
                        case 6:

                            if (counter % 2 != 0)
                            {
                                AdX(body, 6, 46);

                            }
                            else
                            {
                                AdO(body, 6, 46);
                            }
                            counter += 1;
                            break;
                        case 7:

                            if (counter % 2 != 0)
                            {
                                AdX(body, 13, 0);

                            }
                            else
                            {
                                AdO(body, 13, 0);
                            }
                            counter += 1;
                            break;
                        case 8:

                            if (counter % 2 != 0)
                            {
                                AdX(body, 13, 22);

                            }
                            else
                            {
                                AdO(body, 13, 22);
                            }
                            counter += 1;
                            break;

                        case 9:

                            if (counter % 2 != 0)
                            {
                                AdX(body, 13, 46);

                            }
                            else
                            {
                                AdO(body, 13, 46);
                            }
                            counter += 1;
                            break;

                        default:
                            Console.WriteLine("Try Number Between 1-9");
                            break;
                    }
                    //chick the win
                    if (Chick_win(body, ref NuOfXWin, ref NuOfOWin, ref counter, ref countToStop, playerchoice, ref PlayAgain))
                    {
                        //chick if the user want to play again
                        if (PlayAgain == 1) goto Start;
                        else break;//Exit from the loop

                    }

                    Console.Clear();


                }
                Console.Clear();
                
                xx = ChickNumber(1, 2, "\n \n \n \n \n \n \n \n \n \n" +
                    "                    ////////////////////////////////////////////////////////////////////////\n" +
                    "                                                 YOUR Secor is                              \n" +
                    $"                    time x won {NuOfXWin}\n" +
                    $"                    time o won {NuOfOWin}\n\n" +
                    "                    XOXOXOXOXOXOXOXOXOXOXOXOXOX\n" +
                    "                    XOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOXOXOXOXOXXOXOXOXOXOXOXOXOXOX\n" +
                    "                    With all MyWich :Mahfoud Mohammed Bin Sabbah\n" +
                    "                    Press 1 to Exit" +
                    "                    Press 2 Start Again");
                
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White; 


            } while ( xx !=1);

        }

    }
}


 
