using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorsAndException
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("1. Area of a Triangle\n\n2. Area of a Circle\n\n3. Circumference of a Circle\n\n4. Volume of a Hemisphere\n\n"
                + "5. Quadratic Formula\n\n6. Checked values\n\n7. Finally blocks\n\n");
            restart:
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception error)
            {
                Console.WriteLine($"\n{error.Message.ToString()}");
                goto restart;
            }

            switch (choice)
            {
                case 1:
                    AT();
                    break;
                case 2:
                    AC();
                    break;
                case 3:
                    CC();
                    break;
                case 4:
                    H();
                    break;
                case 5:
                    Quad();
                    break;
                case 6:
                    CHECKEDmenu();
                    break;
                case 7:
                    FINALLYmenu();
                    break;

            }

        }

        static void AT()
        {
            Circles__hemispheres__and_triangles Triangle = new Circles__hemispheres__and_triangles();
            double TotalTriangle;
            TotalTriangle = Triangle.triangles();
            Console.WriteLine($"The Area of the Triangle is {TotalTriangle}");
            Console.ReadLine();

        }

        static void AC()
        {
            Circles__hemispheres__and_triangles AreaCircle = new Circles__hemispheres__and_triangles();
            double TotalACircle;

            TotalACircle = AreaCircle.Acircle();

            Console.WriteLine($"The Area of the Circle is {TotalACircle}");
            Console.ReadLine();
        }

        static void CC()
        {
            Circles__hemispheres__and_triangles CircumferenceCircle = new Circles__hemispheres__and_triangles();
            double TotalCCircle;

            TotalCCircle = CircumferenceCircle.CCircle();

            Console.WriteLine($"The Circumference of the Circle is {TotalCCircle}");
            Console.ReadLine();

        }

        static void H()
        {
            Circles__hemispheres__and_triangles Hemisphere = new Circles__hemispheres__and_triangles();
            double TotalHemisphere;

            TotalHemisphere = Hemisphere.hemisphere();

            Console.WriteLine($"The Volume of the Hemisphere is {TotalHemisphere}");
            Console.ReadLine();


        }

        static void Quad()
        {
            Comprehensive_exceptions__quadratic_formula_error Quadratic = new Comprehensive_exceptions__quadratic_formula_error();

            Quadratic.QuadracticFormula();
        }

        static void CHECKEDmenu()
        {
            int choice;
            Variable_overflow CHECKEDTriangle = new Variable_overflow();
            Variable_overflow CHECKEDACircle = new Variable_overflow();
            Variable_overflow CHECKEDCCircle = new Variable_overflow();
            Variable_overflow CHECKEDHemisphere = new Variable_overflow();
            Variable_overflow CHECKEDQUADRATIC = new Variable_overflow();

            Console.WriteLine("++++++CHECKED++++++\n\n1. Area of a Triangle\n\n2. Area of a Circle\n\n3. Circumference of a Circle\n\n4. Volume of a Hemisphere\n\n"
                + "5. Quadratic Formula\n\n");
            restart:
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception error)
            {
                Console.WriteLine($"\n{error.Message.ToString()}");
                goto restart;
            }

            switch (choice)
            {
                case 1:
                    double a;
                    a = CHECKEDTriangle.CHECKEDtriangles();
                    Console.WriteLine($"The Area of the Triangle is {a}");
                    Console.ReadLine();
                    break;
                case 2:
                    double b;
                    b = CHECKEDACircle.CHECKEDAcircle();
                    Console.WriteLine($"The Area of the Circle is {b}");
                    Console.ReadLine();
                    break;
                case 3:
                    double c;
                    c = CHECKEDCCircle.CHECKEDCCircle();
                    Console.WriteLine($"The Circumference of the Circle is {c}");
                    Console.ReadLine();
                    break;
                case 4:
                    double d;
                    d = CHECKEDHemisphere.CHECKEDhemisphere();
                    Console.WriteLine($"The Volume of the Hemisphere is {d}");
                    Console.ReadLine();
                    break;
                case 5:
                    CHECKEDQUADRATIC.CHECKEDQuadracticFormula();
                    break;
            }
        }

        static void FINALLYmenu()
        {
            int choice;
            Finally_block FINALLYtriangle = new Finally_block();
            Finally_block FINALLYACircle = new Finally_block();
            Finally_block FINALLYCCircle = new Finally_block();
            Finally_block FINALLYhemisphere = new Finally_block();
            Finally_block FINALLYquadratic = new Finally_block();

            Console.WriteLine("++++++FINALLY BLOCK ++++++\n\n1. Area of a Triangle\n\n2. Area of a Circle\n\n3. Circumference of a Circle\n\n4. Volume of a Hemisphere\n\n"
                + "5. Quadratic Formula\n\n");
            restart:
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception error)
            {
                Console.WriteLine($"\n{error.Message.ToString()}");
                goto restart;
            }

            switch (choice)
            {
                case 1:
                    double a;
                    a = FINALLYtriangle.triangles();
                    Console.WriteLine($"The Area of the Triangle is {a}");
                    Console.ReadLine();
                    break;
                case 2:
                    double b;
                   b = FINALLYACircle.Acircle();
                    Console.WriteLine($"The Area of the Circle is {b}");
                    Console.ReadLine();
                    break;
                case 3:
                    double c;
                    c = FINALLYCCircle.CCircle();
                    Console.WriteLine($"The Circumference of the Circle is {c}");
                    Console.ReadLine();
                    break;
                case 4:
                    double d;
                    d = FINALLYhemisphere.hemisphere();
                    Console.WriteLine($"The Volume of the Hemisphere is {d}");
                    Console.ReadLine();

                    break;
                case 5:
                    FINALLYquadratic.QuadracticFormula();
                    break;
            }
        }
    }
}
