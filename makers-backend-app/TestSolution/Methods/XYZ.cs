using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolution.Methods
{
    public class XYZ
    {
        /**
         * Metodo para devolver el valor absoluto de la resta de la sumatoria de la diagonales de una matriz cuadrada.
         * **/
        public static int xyz(List<List<int>> arr)
        {
            int sumP = 0; // Sumatoria de todos los numeros en la diagonal
            int sumS = 0; // Sumatoria de los numeros del centro.

            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    if (i == j)
                    {
                        sumP += (arr[i][j]);
                    }
                    if (((arr.Count - 1) - i) == j)
                    {
                        sumS += (arr[i][j]);
                    }
                }
            }
            return Math.Abs(sumP - sumS);
        }
    }
}
