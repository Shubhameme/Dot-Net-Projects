namespace Arrays
{
    public class Arrays
    {
        public static void Main(string[] args)
        {

            int[,] mularray = new int[4, 2];
            mularray[0, 0] = 11; mularray[0, 1] = 12;
            mularray[1, 0] = 13; mularray[1, 1] = 14;
            mularray[2, 0] = 15; mularray[2, 1] = 16;
            mularray[3, 0] = 17; mularray[3, 1] = 18;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(mularray[i, j]);


                }
                Console.WriteLine();
            }
        }

    }
}
