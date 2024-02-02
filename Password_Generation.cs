
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int stringlen = rand.Next(8, 8);
            int randValue;
            string str = "";
            char letter;
            for (int i = 0; i < stringlen; i++)
            {

                
                randValue = rand.Next(0, 26);

                
                letter = Convert.ToChar(randValue + 65);

                 
                str = str + letter;
            }
            Console.WriteLine("Generated password:" + str);
        }
    }
}
