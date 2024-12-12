
namespace Assignment_01
{

    using System;
    using System.Drawing;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    internal class Program
{
        
        private static void Main(string[] args)
        {
            #region Q1

            //Console.WriteLine("What's Your Number? ");

            //long Number;

            //while (!long.TryParse(Console.ReadLine(), out Number))
            //{
            //    Console.WriteLine("Invalid input.");
            //    Console.WriteLine("Enter your Number Again: ");
            //}
            //Console.WriteLine(Number);
            #endregion

            #region Q2

            //String Number01;
            //Number01 = "12X";

            //int Number02 = Convert.ToInt32(Number01);
            ////System.FormatException:
            ////'The input string '12X' was not in a correct format.'
            ////Coz we are trying to convert a string to int while 
            ////the string have numbers it has "X" aswell which can't 
            ////Be converted

            //Console.WriteLine(Number02);


            #endregion

            #region Q3

            //float Var01 = 9_223_372_036_854_775_807f;
            //float Var02 = 9_223_372_036_854_775_807f;

            //float Var03 = Var01 + Var02;

            //Console.WriteLine(Var03); //1.8446744E+19 the numbers will add up
            #endregion

            #region Q4

            //Console.WriteLine("What's Your String? ");
            //string Var = Console.ReadLine();
            //int Start = 0;//InCluded

            //int End = 7; //Execluded

            //string result;
            //result = Var.Substring(Start, End);
            //Console.WriteLine(result);

            #endregion

            #region Q5

            //int Var01 = 10;

            //int Var02 = Var01;

            //Console.WriteLine($"{Var01},{Var02}");
            //// here it will print 10,10 coz we assigend Var02 to Var01,
            ////it will copy the value of Var01

            //Var01 = 13;


            //Console.WriteLine($"{Var01},{Var02}");

            ////here the answer will be 13,10 not 13,13 coz we would have to
            ////reassign the vars again like that 'int Var02 = Var01'
            ////coz this is not a pointer if it it's just a copy
            #endregion

            #region Q6

            //Point One = new Point();
            //One.XAxis = 10;


            //Point Two = new Point();
            //Two = One;

            //Console.WriteLine(One.XAxis);
            //Console.WriteLine(Two.XAxis);

            //One.XAxis = 20;
            ////here when changing the value of XAxis it will change 
            ////in both "One" and "Two" coz that is a pointer which 
            ////is pointed towards the same location it doesnt only 
            ////take a copy but it take a reference

            //Console.WriteLine(One.XAxis);
            //Console.WriteLine(Two.XAxis);



            #endregion

            #region Q7

            //Console.WriteLine("First String: ");
            //string Var1 = Console.ReadLine();
            //Console.WriteLine("Second String: ");
            //string Var2 = Console.ReadLine();

            //string Var3 = Var1 + ' ' + Var2;
            //Console.WriteLine(Var3);
            #endregion

            #region Q8

            //double Principal, Rate, Time;

            //Console.WriteLine("Enter the Principal: ");
            //while (!double.TryParse(Console.ReadLine(), out Principal))
            //{
            //    Console.WriteLine("Enter The Principal Again: ");

            //}
            //Console.WriteLine("Enter the Rate: ");
            //while (!double.TryParse(Console.ReadLine(), out Rate))
            //{
            //    Console.WriteLine("Enter The Rate Again: ");

            //}
            //Console.WriteLine("Enter the Time: ");
            //while (!double.TryParse(Console.ReadLine(), out Time))
            //{
            //    Console.WriteLine("Enter The Time Again: ");

            //}

            //double interestRate = (Principal * Rate * Time) / 100;
            //Console.WriteLine(interestRate);
            #endregion

            #region Q9

            //double BMI, Height, Weight;


            //Console.WriteLine("Enter the Height: ");
            //while (!double.TryParse(Console.ReadLine(), out Height))
            //{
            //    Console.WriteLine("Enter The Height Again: ");

            //}
            //Console.WriteLine("Enter the Weight: ");
            //while (!double.TryParse(Console.ReadLine(), out Weight))
            //{
            //    Console.WriteLine("Enter The Weight Again: ");

            //}

            //BMI = Weight / (Height * Height);
            //Console.WriteLine(BMI);
            #endregion

            #region Q10


            //string Temp = Console.ReadLine();


            //Temp = int.Parse(Temp) < 10 ? "Just Cold" :
            //    int.Parse(Temp) > 30 ? "Just Hot": "Just Good";
            //Console.WriteLine(Temp);

            #endregion

            #region Q11

            //Console.WriteLine("Enter a Date: ");
            //DateTime userDate;
            //if (DateTime.TryParse(Console.ReadLine(), out userDate))
            //{
            //    Console.WriteLine($"The event is on {userDate:MM/dd/yyyy}");
            //    Console.WriteLine($"The event is on {userDate:MM-dd-yyyy}");
            //    Console.WriteLine($"The event is on {userDate:MM,dd,yyyy}");
            //}
            //else
            //{
            //    Console.WriteLine("Not a Valid Date");
            //}
            #endregion

            #region Q12
            //DateTime date = new DateTime(2024, 6, 14);
            //Console.WriteLine($"The event is on {date:MM/dd/yyyy}");
            ////the format is month first
            ////which is 06
            ////then day which is 14 then year which is 2024
            ////The event is on 06/14/2024 is the answer
            #endregion

            #region Q13

            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            //Console.WriteLine(d);
            ////the answer will be 1 coz (!(30<20)) here 30 is not 
            ////smaller that 20 so it will be false so we have (!flase)
            ////that is "true" true is also means 1 so the answer is one 
            #endregion

            #region Q14

            //Console.WriteLine(13 / 2.0 + " " + 13 % 2);
            ////the answer will be 6 and 1 
            ////13 % 2 --> 12 has six of 2 so the reminder of the 13 will be 1
            ////13/2 if we want to get 6.5 we have to cast one value 
            ////either we do this 13.0 / 2 Or 13/2.0
            #endregion

            #region Q15

            //int num = 1, z = 5;

            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);//5 3

            ////first we will go in the If not the else coz
            ////(num <= 0) --> (1 <= 0) is false
            ////!(false) --> true

            ////then ++num will add one that will be num = 2
            //// 2 + z++ the z will not be 6 yet it will still be 5
            ////so the answer of ++num + z++ = 7

            ////in the step the z will be increminted from the line before z++
            ////and we will add one aswell to the z so the answer will be 
            //// z = 6 + 1 = 7 

            ////the final asnwer will be 7 , 7

            #endregion
        }
    }

}
