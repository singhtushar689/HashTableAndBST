namespace HashTableAndBST
{
    internal class HashMap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string[] Words = "to be or not to be".Split(" ");
            MyMapNode<int, string> hash = new MyMapNode<int, string>(5);
            for (int i = 0; i < Words.Length; i++)
            {
                hash.Add(i, Words[i]);
            }
            Console.WriteLine("****************************************************************\n");
            for (int i = 0; i < Words.Length; i++)
            {
                Console.WriteLine("value at index " + i + " is: " + hash.Get(i));
            }
            Console.WriteLine("****************************************************************\n");
            //print freqency of each word in Hash table
            int[] freqency = new int[Words.Length];
            //declare if that word already visited or not
            int visited = -1;
            for (int i = 0; i < Words.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < Words.Length; j++)
                {
                    if (Words[i] == Words[j])
                    {
                        count++;
                        freqency[j] = visited;
                    }
                }
                if (freqency[i] != visited)
                {
                    freqency[i] = count;
                }
            }
            //Print the frequency of each word in Hash table
            for (int i = 0; i < Words.Length; i++)
            {
                if (freqency[i] != visited)
                {
                    Console.WriteLine(" Frequency of '" + Words[i] + "' is " + freqency[i]);
                }
            }
        }
    }
}