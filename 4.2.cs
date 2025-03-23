namespace ConsoleApp1
{
    internal class Program
    {
            static void Main(string[] args)
            {
               
                string sent = Console.ReadLine();

                // Розділяємо рядок на слова
                string[] words = sent.Split(' ');

                //  кількість слів
                Console.WriteLine("word.Length=" + words.Length);

                // Обробляємо кожне слово
                for (int i = 0; i < words.Length; i++)
                {
                    string word = words[i];
                    int replCount = 0;
                    char[] modifiedWord = word.ToCharArray();

                    // Проходимо по кожному символу в слові
                    for (int j = 0; j < modifiedWord.Length; j++)
                    {
                        // Якщо символ - велика буква, заміняємо її на "*" і збільшуємо лічильник замін
                        if (char.IsUpper(modifiedWord[j]))
                        {
                            modifiedWord[j] = '*';
                            replCount++;
                        }
                    }

                    // Збираємо модифіковане слово і додаємо до результату
                    words[i] = new string(modifiedWord) + replCount.ToString();
                }

                // Об'єднуємо слова назад у рядок через пробіл
                sent = string.Join(" ", words);

                Console.WriteLine("\n" + sent);
                Console.ReadKey();
            }
        }
    }

        


