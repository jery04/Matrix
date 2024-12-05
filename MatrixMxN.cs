using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    // test v1.1
    class MatrixM
    {
        //Hecho por Jery;
        static public double[,] Transpuesta(double[,] matrix)
        {
            double[,] transpuesta = new double[matrix.GetLength(1), matrix.GetLength(0)];

            for (int f = 0; f < transpuesta.GetLength(0); f++)
            {
                for (int c = 0; c < transpuesta.GetLength(1); c++)
                {
                    transpuesta[f, c] = matrix[c, f];
                }
            }
            return transpuesta;
        }
        static public void LeerMatrix(double[,] matrix)
        {
            for (int f = 0; f < matrix.GetLength(0); f++)
            {
                string[] elementos = Console.ReadLine().Split(' ');

                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[f, c] = int.Parse(elementos[c]);
                }
            }
        }
        static public void VerMatrix(double [,] matrix )
        {
            for (int f = 0; f < matrix.GetLength(0); f++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[f, c] + " ");
                }
                Console.WriteLine();
            }
        }
        static public double[,] SumarMatrix(double[,] matrix1, double[,] matrix2)
        {
            double[,] newMatrix = new double[matrix1.GetLength(0), matrix1.GetLength(1)];
            for (int f = 0; f < matrix1.GetLength(0); f++)
            {
                for (int c = 0; c < matrix1.GetLength(1); c++)
                {
                     newMatrix[f, c] = matrix1[f, c] + matrix2[f, c];
                }
            }
            return newMatrix;
        }
        static public double[,] RestarMatrix(double[,] matrix1, double[,] matrix2)
        {
            double[,] newMatrix = new double[matrix1.GetLength(0), matrix1.GetLength(1)];
            for (int f = 0; f < matrix1.GetLength(0); f++)
            {
                for (int c = 0; c < matrix1.GetLength(1); c++)
                {
                    newMatrix[f, c] = matrix1[f, c] - matrix2[f, c];
                }
            }
            return newMatrix;
        }
        static public double[,] MultipEscalar(double[,] matrix, double escalar)
        {
            double[,] newMatrix = new double[matrix.GetLength(0), matrix.GetLength(1)];
            for (int f = 0; f < matrix.GetLength(0); f++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    newMatrix[f, c] = Math.Round((matrix[f, c] * escalar), 2);
                }
            }
            return newMatrix;
        }
        static public double[,] DividirEscalar(double[,] matrix, double escalar)
        {
            double[,] newMatrix = new double[matrix.GetLength(0), matrix.GetLength(1)];
            for (int f = 0; f < matrix.GetLength(0); f++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    newMatrix[f, c] = Math.Round((matrix[f, c] / escalar), 2);
                }
            }
            return newMatrix;
        }
        static public double[,] MultiMatrix(double[,] matrix1, double[,] matrix2 )
        {
            double[,] newMatrix = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
            for (int f = 0; f < newMatrix.GetLength(0); f++)
            {
                for (int c = 0; c < newMatrix.GetLength(1); c++)
                {
                    newMatrix[f, c] = Multiplica(matrix1, matrix2, f, c);
                }
            }
            return newMatrix;
        }
        static private double Multiplica(double[,] matrix1, double[,] matrix2, int ff, int cc)
        {
            double element = 0;
            int c = 0;
            while (c < matrix1.GetLength(1))
            {
                for (int f = 0; f < matrix2.GetLength(0); f++)
                {
                    element += matrix1[ff, c] * matrix2[f, cc];
                    c++;
                }
            }
            return Math.Round(element);
        }
        static private double[,] SubMatrix(double[,] matrix, int i, int j)
        {
            int x = 0, y = 0;
            double[,] newMatrix = new double[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

            for (int f = 0; f < matrix.GetLength(0); f++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (f != i && c != j)
                    {
                        newMatrix[x, y] = matrix[f, c];
                        y++;
                        if (y == newMatrix.GetLength(1)) { y = 0; x++; }
                    }
                }
            }
            return newMatrix;
        }
        static private double[,] SubMatrix(double[,] matrix, int j)
        {
            int x = 0, y = 0;
            double[,] newMatrix = new double[matrix.GetLength(0), matrix.GetLength(1) - 1];

            for (int f = 0; f < matrix.GetLength(0); f++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (c != j)
                    {
                        newMatrix[x, y] = matrix[f, c];
                        y++;
                        if (y == newMatrix.GetLength(1)) { y = 0; x++; }
                    }
                }
            }
            return newMatrix;
        }
        static public double Determinante(double[,] matrix)
        {
            double dete = 0;
            if (matrix.Length == 1)
                dete = matrix[0,0];
            else
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                    dete += matrix[0, c] * Math.Pow(-1, c + 2) * Determinante(SubMatrix(matrix, 0, c));
            }
            return dete;
        }
        static private double[,] IntercambiarColumnas(double[,] matrix, int c1, int c2)
        {
            double[,] newMatrix = new double[matrix.GetLength(0), matrix.GetLength(1)];
            for (int f = 0; f < matrix.GetLength(0); f++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    newMatrix[f, c] = matrix[f, c];
                }
            }
            for (int f = 0; f < matrix.GetLength(0); f++)
            {
                newMatrix[f, c1] = matrix[f, c2];
            }

            return newMatrix;
        }
        static public void Cramer(double[,] matrix)
        {
            char[] alfab = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k' };
            double[] soluciones = new double[matrix.GetLength(1) - 1];
            double detSystem = Determinante(SubMatrix(matrix, matrix.GetLength(1) - 1));

            for (int c = 0; c < soluciones.Length; c++)
            {
                double detSoluc = Determinante(SubMatrix(IntercambiarColumnas(matrix, c, matrix.GetLength(1) - 1), matrix.GetLength(1) - 1));
                soluciones[c] = Math.Round((detSoluc / detSystem), 2);
                Console.WriteLine($"{alfab[c]} = {soluciones[c]}");
            }
        }
        static public double[,] Adjunta(double[,] matrix)
        {
            double[,] adjunta = new double[matrix.GetLength(0),matrix.GetLength(1)];

            for (int f = 0; f < matrix.GetLength(0); f++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    adjunta[f, c] = Math.Pow(-1, f+c+2) * Determinante(SubMatrix(matrix, f, c));
                }
            }
            return adjunta;
        }
        static public double[,] Inversa(double[,] matrix)
        {
            if (Determinante(matrix) != 0)
            {
                Console.WriteLine("\nInversa:");
                double det = Determinante(matrix);
                matrix = Transpuesta(Adjunta(matrix));
                
                return DividirEscalar(matrix, det); ;
            }
            return matrix;
        }

        //El método NameMatrix.GetLength(0) devuelve el # filas de la matrix
        //El método NameMatrix.GetLength(1) devuelve el # columnas de la matrix
    }
}
