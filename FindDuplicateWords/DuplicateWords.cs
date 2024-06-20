namespace FindDuplicateWords
{
    public class DuplicateWords
    {
        public static Dictionary<string, int> FindDuplicateWords(string input)
        {
            string[] words = input.Split(' ');

            Dictionary<string, int> dic = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (word != "")
                {
                    if (!dic.ContainsKey(word))
                    {
                        dic.Add(word, 1);
                    }
                    else
                    {
                        dic[word]++;
                    }
                }
            }

            return dic.Where(x => x.Value > 1).ToDictionary(x => x.Key, x => x.Value);
        }
    }
}
