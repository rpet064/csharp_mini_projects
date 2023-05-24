// Fizzbuzz

namespace FizzBuzz
{
    class Program {

        public string FizzBuzz(int number){
            string output = "";
            
            if (number % 3 == 0){
                output += "fizz";
            } 
            if (number % 5 == 0){
                output += "buzz";
            }
            if (output.Length == 0){
                return number.ToString();
            }
            return output;
        }
    static void Main()
        {
            string num;
            Program fizzBuzz = new Program();
            for (int i = 0; i < 100; i++){
                num = fizzBuzz.FizzBuzz(i);
                Console.WriteLine(num);

            }
        }
    }
}
