using System;
using System.Collections.Generic;
using WinFormsApp1.Utils;

namespace WinFormsApp1.Services
{
    /// <summary>
    /// Class that solves square equation by
    /// three coefficients: a, b and c.
    /// </summary>
    public static class SquareEquationService
    {
        /// <summary>
        /// Solves the square equation
        /// </summary>
        /// <param name="a">Coefficient A</param>
        /// <param name="b">Coefficient B</param>
        /// <param name="c">Coefficient C</param>
        /// <returns>Solve result with dictionary of solves.
        /// If no solves, returns empty dictionary. If '<paramref name="a"/>'
        /// is zero, returns <see cref="Failed{TValue}"/></returns>
        public static OperationResult<Dictionary<string, double>> Solve(int a, int b, int c)
        {
            var d = b * b - 4 * a * c;
            if (d < 0)
            {
                return new Success<Dictionary<string, double>>(
                    value: new Dictionary<string, double>()
                );
            }
            
            if (a == 0)
            {
                return new Failed<Dictionary<string, double>>(
                    cause: new DivideByZeroException("Coefficient A is zero")
                );
            }
            
            var squareD = Math.Sqrt(d);
            if (d == 0)
            {
                return new Success<Dictionary<string, double>>(
                    value: new Dictionary<string, double>
                    {
                        {
                            "x", -b / 2 * a
                        }
                    }
                );
            }

            return new Success<Dictionary<string, double>>(
                value: new Dictionary<string, double>
                {
                    {
                        "x1", (-b + squareD) / 2 * a
                    },
                    {
                        "x2", (-b - squareD) / 2 * a
                    }
                }
            );
        }
    }
}