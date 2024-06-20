namespace FindDuplicateWords
{
    /*
     * Write a program to find duplicate words in a input line of Strings and also write the unit test cases 
     * to validate your code.
     */
    public class Program
    {
        static void Main(string[] args)
        {
            string str = "this test is good this test will work fine";

            var duplicates = DuplicateWords.FindDuplicateWords(str);

            foreach (var item in duplicates)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Value);
            }
        }
        
    }
}
