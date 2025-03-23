namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                // Курси валют 
                decimal usdToUah = 37; // 1 USD = 37 UAH
                decimal usdToEu = 0.91m; // 1 USD = 0.91 EUR
                decimal uahToUsd = 1 / usdToUah; // 1 UAH = 1 / 37 USD
                decimal euToUsd = 1 / usdToEu; // 1 EUR = 1 / 0.91 USD

                Console.WriteLine("Введіть кількість та валюту (USD, UAH, EU), щоб конвертувати.");

              
                Console.Write("Введіть суму: ");
                decimal amount = decimal.Parse(Console.ReadLine());

                Console.Write("Введіть валюту для введеної суми (USD, UAH, EU): ");
                string fromCurrency = Console.ReadLine().ToUpper();

                Console.Write("Введіть валюту, в яку хочете конвертувати (USD, UAH, EU): ");
                string toCurrency = Console.ReadLine().ToUpper();

                decimal convertedAmount = 0;

               
                if (fromCurrency == "USD" && toCurrency == "UAH")
                    convertedAmount = amount * usdToUah;
                else if (fromCurrency == "USD" && toCurrency == "EU")
                    convertedAmount = amount * usdToEu;
                else if (fromCurrency == "UAH" && toCurrency == "USD")
                    convertedAmount = amount * uahToUsd;
                else if (fromCurrency == "UAH" && toCurrency == "EU")
                    convertedAmount = amount * uahToUsd * usdToEu;
                else if (fromCurrency == "EU" && toCurrency == "USD")
                    convertedAmount = amount * euToUsd;
                else if (fromCurrency == "EU" && toCurrency == "UAH")
                    convertedAmount = amount * euToUsd * usdToUah;

           
                Console.WriteLine($"Результат конвертації: {convertedAmount:F2} {toCurrency}");
            }
        }

    }


