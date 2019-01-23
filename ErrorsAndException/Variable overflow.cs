using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorsAndException
{
    class Variable_overflow
    {
        public void CHECKEDQuadracticFormula()
        {
            //Variables.
            double a, b, c, addx, subx;
            bool answer1, answer2;

            //Ask for user's input.
            Console.WriteLine("Using the Quadratic Formula to get x.\nEnter the coefficients for the terms a, b, c to make ax^2 + bx + c = 0 TRUE.\n");
            restart:
            try
            {
                Console.Write("a = ");
                //Convert user's first input string to integer.
                a = checked ((long)Convert.ToInt32(Console.ReadLine()));
                if (a <= 0)
                {
                    Console.WriteLine("\nInvalid Value.");
                    goto restart;
                }
                Console.Write("b = ");
                //Convert user's second input string to integer.
                b = checked((long)Convert.ToInt32(Console.ReadLine()));
                if (b <= 0)
                {
                    Console.WriteLine("\nInvalid Value.");
                    goto restart;
                }
                Console.Write("c = ");
                //Convert user's third input string to integer.
                c = checked ((long)(Convert.ToInt32(Console.ReadLine())));
                if (c <= 0)
                {
                    Console.WriteLine("\nInvalid Value.");
                    goto restart;
                }
                //Space.
                Console.WriteLine();
            }
            catch (OverflowException error)
            {
                Console.WriteLine($"\n{error.ToString()}");
                goto restart;
            }

            //Decision statement. If a is any number but 0. Execute block code.
            if (a != 0)
            {
                //Calculate the addition part of quadratic formula. Accessing function AddQuadraticFormula method.
                addx = CHECKEDAddQuadraticFormula(a, b, c);
                //Calculate the subtraction part of quadratic formula. Accessing function SubQuadraticFormula method.
                subx = CHECKEDSubQuadraticFormula(a, b, c);

                //Decision statement. If quadratic formula solutions are all real numbers. Execute block code.
                if (((addx <= 0) || (addx >= 0)) && (((subx <= 0) || (subx >= 0))))
                {
                    //Display quadratic formula solutions.
                    Console.Write("Quadratic Formula: ");
                    Console.Write($"x = {addx}; ");
                    Console.WriteLine($"x = {subx}");

                    //Calculate if quadratic equation is equal to 0 using the first quadratic formula solution.
                    //Accessing function QuadracticEquation method.  
                    
                    answer1 =  (CHECKEDQuadracticEquation(addx, a, b, c));
                   
                    //Display first quadratic equation with inputs and answers.
                    Console.WriteLine($"\nThis solution makes ax^2 + bx + c = 0 \n({a})({addx})^2 + ({b})({addx}) + {c} = 0 \n{answer1}\n");

                    //Calculate if quadratic equation is equal to 0 using the second quadratic formula solution.
                    //Accessing function QuadracticEquation method.
                    answer2 = CHECKEDQuadracticEquation(subx, a, b, c);
                    //Display second quadratic equation with inputs and answers.
                    Console.WriteLine($"This solution makes ax^2 + bx + c = 0 \n({a})({subx})^2 + ({b})({subx}) + {c} = 0 \n{answer1}\n");

                }

                //Quadratic formula solutions are not real numbers. Imaginaries.
                else
                {
                    Console.WriteLine("Invalid. Sqaure root of a negative number will give you an imaginary number.");
                }
            }

            //Cannot divide by 0.
            else
            {
                Console.WriteLine("ERROR. a cannot be 0 since denominator will be be 0. ");
            }

            //Prevents console from closing until user presses enter.
            Console.ReadLine();
        }

        //Quadratic formula method with parameters. Addition section of QF.
        double CHECKEDAddQuadraticFormula(double A, double B, double C)
        {
            //Variable
            double X = 0;

            //Calculate for X.
            try
            {
                
            X = checked ((long)((-B) + Math.Sqrt(Math.Pow(B, 2) - (4 * A * C))) / (2 * A));
                
            }
            catch (OverflowException error)
            {
                Console.WriteLine($"\n{error.ToString()}");
                
            }
            //Return value to the method.
            return X;
        }

        //Quadratic formula method. Subration section.
        double CHECKEDSubQuadraticFormula(double A, double B, double C)
        {
            //Variable.
            double X = 0;
            try
            {
                //Calculate for X.
                X = checked ((long)(-B) - Math.Sqrt(Math.Pow(B, 2) - (4 * A * C))) / (2 * A);
            }
            catch (OverflowException error)
            {
                Console.WriteLine($"\n{error.ToString()}");
            }
            //Return value to the method.
            return X;
        }

        //Quadratic equation method. True or false.
        bool CHECKEDQuadracticEquation(double X, double A, double B, double C)
        {
            //Assign variable by calculating the quadratic equation.
            try
            {
                double answer = 0;

                answer = checked((long)((A * Math.Pow(X, 2)) + (B * X) + C));

                if ((answer < .001) && (answer > -.001))
                {
                    //Return boolean true to method
                    return true;
                }
                //If answer is not equal to 0. Execute block code.
                else
                {
                    //Return boolean false to method.
                    return false;
                }
            
            }
            catch (OverflowException error)
            {
                Console.WriteLine($"\n{error.ToString()}");

                return false;
            }
            //Decision statement. If answer is equal to 0. Execute block code.
        }
        public double CHECKEDtriangles()

        {

            //Variables.
            double a, b, c, p, A;

            //Ask user for input.
            Console.WriteLine("Enter the three sides of the triangle. ");
            restart:
            try
            {

                Console.Write("\nSide a: ");
                a = checked ((long)Convert.ToInt32(Console.ReadLine()));
                if (a <= 0)
                {
                    Console.WriteLine("\nInvalid Value.");
                    goto restart;
                }
                Console.Write("\nSide b: ");
                b = checked ((long)Convert.ToInt32(Console.ReadLine()));
                if (b <= 0)
                {
                    Console.WriteLine("\nInvalid Value.");
                    goto restart;
                }
                Console.Write("\nSide c: ");
                c = checked ((long)Convert.ToInt32(Console.ReadLine()));
                if (c <= 0)
                {
                    Console.WriteLine("\nInvalid Value.");
                    goto restart;
                }
                Console.WriteLine();

                p = checked ((long)(a + b + c) / 2);
                A = checked ((long)Math.Sqrt((p * (p - a)) * (p * (p - b)) * (p * (p - c))));
            }
            catch (OverflowException error)
            {
                Console.WriteLine($"\n{error.ToString()}");
                goto restart;
            }     

            return A;

        }

        public double CHECKEDAcircle()
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
                radius = checked ((long)Convert.ToInt32(Console.ReadLine()));
                if (radius < 0)
                {
                    Console.WriteLine("\nInvalid Value.");
                    goto restart;
                }
                Console.WriteLine();

                A = checked ((long)pi * (Math.Pow(radius, 2)));


            }
            catch (OverflowException error)
            {
                Console.WriteLine($"\n{error.ToString()}");
                goto restart;
            }

            //Calculate Area

            return A;
        }

        public double CHECKEDCCircle()
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
                radius = checked ((long)Convert.ToInt32(Console.ReadLine()));
                if (radius < 0)
                {
                    Console.WriteLine("\nInvalid Value.");
                    goto restart;
                }
                Console.WriteLine();

                C = checked ((long)2 * pi * radius);


            }
            catch (OverflowException error)
            {
                Console.WriteLine($"\n{error.ToString()}");
                goto restart;
            }
            return C;
        }

        public double CHECKEDhemisphere()
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
                r = checked ((long)Convert.ToInt32(Console.ReadLine()));
                if (r <= 0)
                {
                    Console.WriteLine("\nInvalid Value.");
                    goto restart;
                }

                Console.WriteLine();

                V = checked((long)(((4 * (pi * Math.Pow(r, 3))) / 3) / 2));
            }
            catch (OverflowException error)
            {
                Console.WriteLine($"\n{error.ToString()}");
                goto restart;
            }

            return V;
        }
    }
}
