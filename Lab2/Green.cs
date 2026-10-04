using System.Collections.Generic;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;

        public double Task1(int n)
        {
            double answer = 0;

            // code here
            for (int i = 2; i <= n; i += 2)
            {
                answer += (double)i / (i + 1);
            }
            // end

            return answer;
        }

        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            for (int i = 0; i <= n; i++)
            {
                answer += System.Math.Pow(x, -i);
            }
            // end

            return answer;
        }

        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long factorial = 1;

            for (int i = 0; i <= n; i++)
            {
                if (i > 0)
                {
                    factorial *= i;
                }

                answer += factorial;
            }
            // end

            return answer;
        }

        public double Task4(double x)
        {
            double answer = 0;

            // code here
            int n = 1;

            while (true)
            {
                double term = System.Math.Sin(n * System.Math.Pow(x, n));

                if (System.Math.Abs(term) < E)
                {
                    break;
                }

                answer += term;
                n++;
            }
            // end

            return answer;
        }

        public int Task5(double x)
        {
            int answer = 1;

            // code here
            while (true)
            {
                double current = 1.0 / System.Math.Pow(x, answer);
                double previous = 1.0 / System.Math.Pow(x, answer - 1);

                if (System.Math.Abs(current - previous) < E)
                {
                    break;
                }

                answer++;
            }
            // end

            return answer;
        }

        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1;

            while (elem < limit)
            {
                elem *= 2;
                answer += elem;
            }
            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            // code here
            double length = L;

            while (length > Da)
            {
                length /= 2;
                answer++;
            }
            // end

            return answer;
        }
        //checar8
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b + E; x += h)
            {
                double S = 0;
                int i = 0;

                while (true)
                {
                    double term = System.Math.Pow(-1, i)
                                * System.Math.Pow(x, 2 * i + 1)
                                / (2 * i + 1);

                    S += term;

                    if (System.Math.Abs(term) < E)
                    {
                        break;
                    }

                    i++;
                }

                SS += S;
                SY += System.Math.Atan(x);
            }
            // end

            return (SS, SY);
        }
    }
}