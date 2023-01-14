namespace HashTableAndBST
{
    internal class HashMap
    {
        static void HashFunction(string[] args)
        {
            Console.WriteLine("\n****************************************************************");
            Console.WriteLine("Press 1 : For Search word in sentence\nPress 2 : For search word in Paragraph");
            Console.WriteLine("\n****************************************************************");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    string[] str1 = "to be or not to be".Split(" ");
                    MyMapNode<int, string> sentenceHash = new MyMapNode<int, string>(5);
                    for (int i = 0; i < str1.Length; i++)
                    {
                        sentenceHash.Add(i, str1[i]);
                    }
                    Console.WriteLine("****************************************************************\n");
                    for (int i = 0; i < str1.Length; i++)
                    {
                        Console.WriteLine("value at index " + i + " is: " + sentenceHash.Get(i));
                    }
                    Console.WriteLine("****************************************************************\n");
                    sentenceHash.findFreq(str1);
                    break;
                case 2:
                    string[] str2 = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations".Split(" ");
                    MyMapNode<int, string> paragraphHash = new MyMapNode<int, string>(5);
                    for (int i = 0; i < str2.Length; i++)
                    {
                        paragraphHash.Add(i, str2[i]);
                    }
                    Console.WriteLine("****************************************************************\n");
                    for (int i = 0; i < str2.Length; i++)
                    {
                        Console.WriteLine("value at index " + i + " is: " + paragraphHash.Get(i));
                    }
                    Console.WriteLine("****************************************************************\n");
                    paragraphHash.findFreq(str2);
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}

        
       
           
                
            
        
    
