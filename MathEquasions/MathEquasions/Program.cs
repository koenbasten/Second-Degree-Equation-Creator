internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            // FORMAT
            // AX^2 + BX + C = D
            double a, b, c, d, x1, x2;
            Random r = new Random();

            //Create the random numbers
            a = r.Next(-100, 100);
            b = r.Next(-100, 100);
            c = r.Next(-100, 100);
            d = r.Next(-100, 100);

            double D = (b * b) - 4 * (a * (c - d)); // Calculating the discriminant

            if (a != 0 && a != 1 && a != -1 && b != 0 && b != 1 && b != -1 && c != 0 && c != 1 && c != -1 && d != 0 && d != 1 && d != -1 && c != d && d != a && a != b && b !=c) // Check that nothing is 0(for dividing by 0) or 1/-1 (too easy) and that the variables arent the same(also too easy)
            {
                if (D < 0)
                {

                }
                else if (D == 0)
                {
                    x1 = (-b / (2 * a));
                }
                else if (D > 0)
                {
                    x1 = (-b + Math.Sqrt(D)) / (2 * a); // Calculating the X values
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);

                    if (x1 % 1 == 0 && x2 % 1 == 0) //From here it's just converting the equation in the correct format for displaying
                    {
                        if (b > 0)
                        {
                            if (c > 0)
                            {
                                Console.WriteLine($"{a}X^2 + {b}X + {c} = {d}");
                            }
                            else
                            {
                                Console.WriteLine($"{a}X^2 + {b}X {c} = {d}");
                            }
                        }
                        else
                        {
                            if (c > 0)
                            {
                                Console.WriteLine($"{a}X^2 {b}X + {c} = {d}");
                            }
                            else
                            {
                                Console.WriteLine($"{a}X^2 {b}X {c} = {d}");
                            }
                        }
                        Console.WriteLine($"X={x1}, X={x2}");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}