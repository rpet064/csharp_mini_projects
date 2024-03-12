// Solution for https://learn.microsoft.com/en-us/training/modules/csharp-arrays-operations/7-challenge-2
namespace FilterOutBs
{
    class Program
    {
        string[] orderStreamArray = Array.Empty<string>();


        public void FilterBs(string orderStream)
        {
            orderStreamArray = orderStream.Split(',');

            for (int i = 0; i < orderStreamArray.Length; i++)
            {
                string arrayItem = orderStreamArray[i];
                if (arrayItem.Substring(0, 1) == "B")
                {
                    Console.WriteLine(arrayItem);
                }
            }
        }
        static void Main()
        {
            const string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

            Program FilterOutBs = new Program();
            FilterOutBs.FilterBs(orderStream);
        }
    }
}