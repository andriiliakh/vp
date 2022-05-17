char[] variables = new char[5] { 'x', 'y', 'z', 'u', 'v' };
const int n = 5;
int flag, iter = 0;
double nevyazka;
double[] x = new double[n];
double[] x_new = new double[n];
double[,] a = new double[n, n + 1] {
        { 0.43,  0.045, -0.02,  0.03, -0.02,    0.78},
        { 0.12,  0.37,   0.02,  0,    -0.01,   -0.38},
        { 0.01,  0.032,  0.356,-0.02,  0.05,    1.91},
        { 0.12, -0.11,   0,     0.49,  0.112,  -1.464},
        { -0.05, 0,      0.025,-0.01,  0.294,   2.362}
};

double eps = 0.00001;

do
{
    iter++;
    flag = 0;
    for (int i = 0; i < n; i++)
    {
        x_new[i] = x[i];
        for (int j = 0; j < n; j++)
        {
            x_new[i] -= a[i, j] * x[j];
        }
        x_new[i] += a[i, n];
        if (Math.Abs(x_new[i] - x[i]) <= eps)
            flag++;
    }
    for (int i = 0; i < n; i++)
    {
        x[i] = x_new[i];
    }
} while (flag < n);

Console.WriteLine("Tochnist = " + eps + "\n");

Console.WriteLine("Kilkist iteratsiy = " + iter + "\n");

Console.WriteLine("Rozvyazok systemy:");

for (int i = 0; i < n; i++)
{
    Console.WriteLine(variables[i] + " = " + x[i]);
}

Console.WriteLine("\nNevyazka:");

for (int i = 0; i < n; i++)
{
    nevyazka = 0;
    for (int j = 0; j < n; j++)
    {
        nevyazka += a[i, j] * x[j];
    }
    nevyazka -= a[i, n];
    Console.WriteLine(nevyazka);
}