namespace Minesweeper.Logic
   
{
    public class Model
    {
        private Field[,] gameBoard = new Field[20, 20];
        
        public void DoTurn(string coordinate)
        {

            foreach (var field in gameBoard)
            {
                Console.WriteLine("Fortnite");
            }

            Console.WriteLine("Which field do you want to change?");
            string input = Console.ReadLine();
            input.ToUpper();


        }
    }

    public class Field 
    {

    }
}