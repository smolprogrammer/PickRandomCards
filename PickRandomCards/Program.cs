using PickRandomCards;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of cards to pick: ");
        string line = Console.ReadLine();
        if (int.TryParse(line, out int numberOfCards))
        {
            string[] cards = CardPicker.PickSomeCards(numberOfCards);
            foreach (string card in cards)
            {
                Console.WriteLine(card);
            }
        }
        else
        {
            Console.WriteLine("Try to enter a valid number.");
        }
    }
}