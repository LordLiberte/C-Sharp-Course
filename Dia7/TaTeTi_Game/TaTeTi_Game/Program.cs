using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TaTeTi_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[,] board = new string[3, 3];
            string Player1 = "X";
            string Player2 = "O";
            string currentPlayer = Player1;
            bool gameWon = false;

            board = new string[,]
            {
                { "1", "2", "3" },
                { "4", "5", "6" },
                { "7", "8", "9" }
            };

            void RepresentarCasillero()
            {
                for (int i = 0; i < board.GetLength(0); i++)
                {

                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        Console.Write("| " + board[i, j] + " |");
                        if (j == board.GetLength(1) - 1)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }

            RepresentarCasillero(); 
            while (!gameWon)
            {
                string input = SeleccionarCasilla();
                int casilla = int.Parse(input) - 1;
                int row = casilla / 3;
                int col = casilla % 3;
                if (board[row, col] != "X" && board[row, col] != "O")
                {
                    board[row, col] = currentPlayer;
                    RepresentarCasillero();
                }
                else
                {
                    Console.WriteLine("Casilla ya ocupada. Intenta de nuevo.");
                    continue;
                }
            }

            string SeleccionarCasilla()
            {
                Console.WriteLine($"Selecciona una casilla (1-9) para {currentPlayer}: ");
                string input = Console.ReadLine();
                int casilla;
                while (!int.TryParse(input, out casilla) || casilla < 1 || casilla > 9)
                {
                    Console.WriteLine("Entrada inválida. Por favor, selecciona un número entre 1 y 9.");
                    input = Console.ReadLine();
                }
                return input;
            }


        }
    }
}
