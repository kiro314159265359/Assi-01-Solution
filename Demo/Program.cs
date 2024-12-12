
namespace Demo
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            #region VarDeclaration

            //int Number;
            //int Number1 = 1;
            //int N01=1, N02=2, N03=3;

            //Console.WriteLine(N01);
            //N01 = 6;
            //Console.WriteLine(N01);
            #endregion

            #region DataTypes
            //Int32 NewVar = 3;// --> same as int
            //Int64 NewVar1 = 6;// --> same as long


            #endregion

            #region PointClass

            //Point P01;

            //P01 = new Point();
            //Console.WriteLine(P01.XAxis);
            //Console.WriteLine(P01.YAxis);
            //Console.WriteLine(P01);

            //Point P02 = new Point();

            //P02.XAxis = 10;

            //Console.WriteLine(P01.XAxis);
            //Console.WriteLine(P02.XAxis);

            //P01 = P02;
            //Console.WriteLine(P01.XAxis);
            //Console.WriteLine(P02.XAxis);
            #endregion

            #region Object

            // void print(int x)
            //{
            //    Console.WriteLine(x);
            //}


            // void print1(string x)
            //{
            //    Console.WriteLine(x);
            //}

            // void print2(Point x)
            //{
            //    Console.WriteLine(x);
            //}

            // void print3(object x)
            //{
            //    Console.WriteLine(x);
            //}

            //Object O01 = new object();
            // O01 = 1;
            // O01 = 2.2;
            //O01 = 'A';
            // O01 = true;

            //O01 = new Point();
            // O01.GetType();
            //Console.WriteLine(O01.ToString());
            // O01.GetHashCode();
            //O01.Equals(O01.GetType());


            #endregion

            #region Casting

            //int Number01 = 10;

            //double Number02 = Number01;

            //double Number02 = (double)Number01;

            //double Number01 = 2.5;

            //int Number02 = (int)Number01;

            #endregion

            #region CastingFunc
            //Console.WriteLine("What's Your Name? ");
            //int Age = int.Parse(Console.ReadLine());
            //Console.WriteLine(Age);
            #endregion

            #region Convert
            //Console.WriteLine("What's Your Name? ");
            //int Age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Age);


            #endregion

            #region TryParse

            //Console.WriteLine("What's Your Name? ");

            //int Age;     

            //while (!int.TryParse(Console.ReadLine(), out Age)) {
            //    Console.WriteLine("Invalid input.");
            //}
            //Console.WriteLine(Age);

            #endregion

            #region Fractions

            //double Var1 = 1.5;

            //float Var2 = 1.5f;

            //decimal Var3 = 1.5m;

            //int Var4 = 1_000_000_000;


            #endregion

            #region Operators

            //int x = 10;
            //x++; //Post fix 
            //++x; //prefix

            //x--; //Post fix 
            //--x; //prefix

            //binary
            // + - / * %

            //int Var1 = 1, Var2 = 2, Var3 = 3, Var4 = 4;

            //int Sum = Var1 + Var2;

            //double Mul = Var3 * Var4;

            //double Division = Var4 / Var3;

            //double Mod = Var3 % Var4;


            //int x = 4;

            //x += 3;
            //x -= 3;
            //x /= 3;
            //x *= 3;
            //x %= 3;


            //int Var01 = 6;
            //int Var02 = 6;

            //Console.WriteLine(Var01 == Var02);
            //Console.WriteLine(Var01 != Var02);
            //Console.WriteLine(Var01 >= Var02);
            //Console.WriteLine(Var01 <= Var02);
            //Console.WriteLine(Var01 > Var02);
            //Console.WriteLine(Var01 < Var02);

            //Console.WriteLine(!false);
            //Console.WriteLine(false || false);
            //Console.WriteLine(true && false); --> Short circle if first 
            //one is false then the answer will be false and if true 
            //it will return true

            //Console.WriteLine(!false);
            //Console.WriteLine(false & false);
            //Console.WriteLine(true | false);


            //string flag = 4 > 2 ? "True" : "False";
            //Console.WriteLine(flag);


            #endregion


        }
    }

}