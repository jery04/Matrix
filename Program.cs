using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Matrix
{
    class Program
    {
        static void ImprimirColor(string a)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(a);
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void Main(string[] args)
        {
            bool a = true;
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("" +
    "██▄   ▄██  ▄██████▄  ████████  ▄█████▄  ▀▀  ██   ██\n" +
    "██▀█▄█▀██  ██    ██     ██  █  ██    █  ██   ▀▄▄▄▀\n" +
    "██     ██  █████ ██     ██     ██▀▀██   ██   ▄▀▀▀▄ \n" +
    "██     ██  ██    ██     ██     ██   ██  ██  ██   ██(f×c)");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1-Sumar Matrices\n2-Restar Matrices\n3-Multiplicar Matrices\n" +
                                  "4-Multiplicar Matriz-Escalar\n5-Dividir Matriz-Escalar\n6-Determinante de una Matriz\n" +
                                  "7-Método de Cramer\n8-Matriz Transpuesta\n9-Matriz Adjunta\n10-Matriz Inversa\n11-Salir");
                string respuesta = Console.ReadLine();
                Console.Clear();

                switch (respuesta)
                {
                    case "1":
                        do
                        {
                            ImprimirColor("Sumar Matrices");
                            double[][,] matrix = new double[2][,];
                                for (int x = 0; x < 2; x++)
                                {
                                    Console.Write("Ingrese Filas-Columnas(f×c): ");
                                    string[] FxC = Console.ReadLine().Split('x',' ');
                                    int f = int.Parse(FxC[0]);
                                    int c = int.Parse(FxC[1]);
                                    matrix[x] = new double[f, c];
                                    MatrixM.LeerMatrix(matrix[x]);
                                    Console.WriteLine();
                                }
                            MatrixM.VerMatrix(MatrixM.SumarMatrix(matrix[0], matrix[1]));

                            Console.WriteLine("/n1-Repetir\n2-Menu");
                            if (Console.ReadLine() == "2") { Console.Clear(); break; }
                            else Console.Clear();
                        } while (true);
                        break;

                    case "2":
                        do
                        {
                            ImprimirColor("Restar Matrices");
                            double[][,] matrix = new double[2][,];
                                for (int x = 0; x < 2; x++)
                                {
                                    Console.Write("Ingrese Filas-Columnas(f×c): ");
                                    string[] FxC = Console.ReadLine().Split('x',' ');
                                    int f = int.Parse(FxC[0]);
                                    int c = int.Parse(FxC[1]);
                                    matrix[x] = new double [f, c];
                                    MatrixM.LeerMatrix(matrix[x]);
                                    Console.WriteLine();
                                }
                            MatrixM.VerMatrix(MatrixM.RestarMatrix(matrix[0], matrix[1]));

                            Console.WriteLine("\n1-Repetir\n2-Menu");
                            if (Console.ReadLine() == "2") { Console.Clear(); break; }
                            else Console.Clear();
                        } while (true);
                        break;

                    case "3":
                        do
                        {
                            ImprimirColor("Multiplicar Matrices");
                            double[][,] matrix = new double[2][,];
                                for (int x = 0; x < 2; x++)
                                {
                                    Console.Write("Ingrese Filas-Columnas(f×c): ");
                                    string[] FxC = Console.ReadLine().Split('x',' ');
                                    int f = int.Parse(FxC[0]);
                                    int c = int.Parse(FxC[1]);
                                    matrix[x] = new double[f, c];
                                    MatrixM.LeerMatrix(matrix[x]);
                                    Console.WriteLine();
                                }
                            MatrixM.VerMatrix(MatrixM.MultiMatrix(matrix[0], matrix[1]));

                            Console.WriteLine("\n1-Repetir\n2-Menu");
                            if (Console.ReadLine() == "2") { Console.Clear(); break; }
                            else Console.Clear();
                        } while (true);
                        break;

                    case "4":
                        do
                        {
                            ImprimirColor("Multiplicar Matrices-Escalar");
                            double[,] matrix;
                            Console.Write("Ingrese Filas-Columnas(f×c): ");
                            string[] FxC = Console.ReadLine().Split('x',' ');
                            int f = int.Parse(FxC[0]);
                            int c = int.Parse(FxC[1]);
                            matrix = new double[f, c];
                            MatrixM.LeerMatrix(matrix);
                            Console.Write("\nIngrese Escalar: ");
                            int escalar = int.Parse(Console.ReadLine());

                            MatrixM.VerMatrix(MatrixM.MultipEscalar(matrix, escalar));

                            Console.WriteLine("\n1-Repetir\n2-Menu");
                            if (Console.ReadLine() == "2") { Console.Clear(); break; }
                            else Console.Clear();
                        } while (true);
                        break;

                    case "5":
                        do
                        {
                            ImprimirColor("Dividir Matrices-Escalar");
                            double[,] matrix;

                            Console.Write("Ingrese Filas-Columnas(f×c): ");
                            string[] FxC = Console.ReadLine().Split('x',' ');
                            int f = int.Parse(FxC[0]);
                            int c = int.Parse(FxC[1]);
                            matrix = new double[f, c];
                            MatrixM.LeerMatrix(matrix);
                            Console.Write("\nIngrese Escalar: ");
                            int escalar = int.Parse(Console.ReadLine());

                            MatrixM.VerMatrix(MatrixM.DividirEscalar(matrix, escalar));

                            Console.WriteLine("\n1-Repetir\n2-Menu");
                            if (Console.ReadLine() == "2") { Console.Clear(); break; }
                            else Console.Clear();
                        } while (true);
                        break;

                    case "6":
                        do
                        {
                            ImprimirColor("Determinante de una Matriz");
                            double[,] matrix;

                            Console.Write("Ingrese Filas-Columnas(f×c): ");
                            string[] FxC = Console.ReadLine().Split('x',' ');
                            int f = int.Parse(FxC[0]);
                            int c = int.Parse(FxC[1]);
                            matrix = new double[f, c];
                            MatrixM.LeerMatrix(matrix);

                            Console.WriteLine($"\ndet(M)=|M|= {MatrixM.Determinante(matrix)}\n");

                            Console.WriteLine("1-Repetir\n2-Menu");
                            if (Console.ReadLine() == "2") { Console.Clear(); break; }
                            else Console.Clear();
                        } while (true);

                        break;

                    case "7":
                        do
                        {
                            ImprimirColor("Método de Cramer");
                            double[,] matrix;

                            Console.Write("Ingrese Filas-Columnas(f×c): ");
                            string[] FxC = Console.ReadLine().Split('x',' ');
                            int f = int.Parse(FxC[0]);
                            int c = int.Parse(FxC[1]);
                            matrix = new double[f, c];
                            MatrixM.LeerMatrix(matrix);

                            Console.WriteLine();
                            MatrixM.Cramer(matrix);

                            Console.WriteLine("\n1-Repetir\n2-Menu");
                            if (Console.ReadLine() == "2") { Console.Clear(); break; }
                            else Console.Clear();
                        } while (true);
                        break;

                    case "8":
                        do
                        {
                            ImprimirColor("Matriz Transpuesta");

                            double[,] matrix;
                            Console.Write("Ingrese Filas-Columnas(f×c): ");
                            string[] FxC = Console.ReadLine().Split('x',' ');
                            int f = int.Parse(FxC[0]);
                            int c = int.Parse(FxC[1]);
                            matrix = new double[f, c];
                            MatrixM.LeerMatrix(matrix);

                            Console.WriteLine("\nTranspuesta:");
                            MatrixM.VerMatrix(MatrixM.Transpuesta(matrix));

                            Console.WriteLine("\n1-Repetir\n2-Menu");
                            if (Console.ReadLine() == "2") { Console.Clear(); break; }
                            else Console.Clear();
                        } while (true);
                        break;

                    case "9":
                        do
                        {
                            ImprimirColor("Matriz Adjunta");
                            double[,] matrix;

                            Console.Write("Ingrese Filas-Columnas(f×c): ");
                            string[] FxC = Console.ReadLine().Split('x',' ');
                            int f = int.Parse(FxC[0]);
                            int c = int.Parse(FxC[1]);
                            matrix = new double[f, c];
                            MatrixM.LeerMatrix(matrix);

                            Console.WriteLine("\nAdjunta:");
                            MatrixM.VerMatrix(MatrixM.Adjunta(matrix));
                            Console.WriteLine("\n1-Repetir\n2-Menu");
                            if (Console.ReadLine() == "2") { Console.Clear(); break; }
                            else Console.Clear();
                        } while (true);
                        break;

                    case "10":
                        do
                        {
                            ImprimirColor("Matriz Inversa");
                            double[,] matrix;

                            Console.Write("Ingrese Filas-Columnas(f×c): ");
                            string[] FxC = Console.ReadLine().Split('x',' ');
                            int f = int.Parse(FxC[0]);
                            int c = int.Parse(FxC[1]);
                            matrix = new double[f, c];
                            MatrixM.LeerMatrix(matrix);

                            if (MatrixM.Determinante(matrix) != 0)
                            {
                                MatrixM.VerMatrix(MatrixM.Inversa(matrix));
                            }
                            else Console.WriteLine("\nLa matriz no es inversible, pues det(M)= 0.");

                            Console.WriteLine("\n1-Repetir\n2-Menu");
                            if (Console.ReadLine() == "2") { Console.Clear(); break; }
                            else Console.Clear();
                        } while (true);
                        break;
                    case "11":
                        a = false;
                        break;
                }
            } while (a);
        }
    }
}
