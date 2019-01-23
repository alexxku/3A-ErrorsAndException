using System;


namespace ErrorsAndException
{
    public class Circles__hemispheres__and_triangles
    {
        public double triangles()

        {

            //Variables.
            double a, b, c, p, A;

            //Ask user for input.
            Console.WriteLine("Enter the three sides of the triangle. ");
            restart:
            try
            {
                
                Console.Write("\nSide a: ");
                a = Convert.ToInt32(Console.ReadLine());
                if (a <= 0)
                {
                    Console.WriteLine("\nInvalid Value.");
                    goto restart;
                }
                Console.Write("\nSide b: ");
                b = Convert.ToInt32(Console.ReadLine());
                if (b <= 0)
                {
                    Console.WriteLine("\nInvalid Value.");
                    goto restart;
                }
                Console.Write("\nSide c: ");
                c = Convert.ToInt32(Console.ReadLine());
                if (c <= 0)
                {
                    Console.WriteLine("\nInvalid Value.");
                    goto restart;
                }
                Console.WriteLine();
            }
            catch (Exception error)
            {
                Console.WriteLine($"\n{error.Message.ToString()}");
                goto restart;
            }

            //Calculate sides and Area.
            p = (a + b + c) / 2;
            A = Math.Sqrt((p * (p - a)) * (p * (p - b)) * (p * (p - c)));

            return A;

        }

        public double Acircle()
        {
            //Variables
            double radius;
            double pi = Math.PI;
            double A;

            //Ask the user for an input.
            restart:
            try
            {
                Console.Write("Enter a number for the radius: ");
                radius = Convert.ToInt32(Console.ReadLine());
                if (radius < 0)
                {
                    Console.WriteLine("\nInvalid Value.");
                    goto restart;
                }
                Console.WriteLine();

            }
           catch(Exception error)
            {
                Console.WriteLine($"\n{error.Message.ToString()}");
                goto restart;
            }

            //Calculate Area
            A = pi * (Math.Pow(radius, 2));

            return A;
        }

        public double CCircle()
        {
            //Variables
            double radius;
            double pi = Math.PI;
            double C;

            //Ask the user for an input.
            restart:
            try
            {
                Console.Write("Enter a number for the radius: ");
                radius = Convert.ToInt32(Console.ReadLine());
                if (radius < 0)
                {
                    Console.WriteLine("\nInvalid Value.");
                    goto restart;
                }
                Console.WriteLine();

            }
            catch (Exception error)
            {
                Console.WriteLine($"\n{error.Message.ToString()}");
                goto restart;
            }

            //Calculate Circumference
            C = 2 * pi * radius;

            return C;

        }

        public double hemisphere()
        {
            //Variables.
            double r;
            double pi = Math.PI;
            double V;

            //Ask user for input.
            restart:
            try
            {
                Console.Write("Enter a number for the radius: ");
                r = Convert.ToInt32(Console.ReadLine());
                if (r <= 0)
                {
                    Console.WriteLine("\nInvalid Value.");
                    goto restart;
                }

                Console.WriteLine();

            }
            catch (Exception error)
            {
                Console.WriteLine($"\n{error.Message.ToString()}");
                goto restart;
            }

            //Calculate volume of hemisphere.
            V = (((4 * (pi * Math.Pow(r, 3))) / 3) / 2);

            return V;   
        }

    }
}
