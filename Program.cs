/**
 * https://www.youtube.com/watch?v=YrtFtdTTfv0
 */

namespace first_app
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWord helloWord = new HelloWord();
            //helloWord.helloWord();

            DataTypes dataType = new DataTypes();
            //dataType.dataType();

            StringChars stringChars = new StringChars();
            //stringChars.stringChars();

            StringToNumberConversion stringToNumber = new StringToNumberConversion();
            //stringToNumber.stringToNumberConversion();

            Bool boolType = new Bool();
            //boolType.boolType();

            Operators operators = new Operators();
            //operators.operators();

            VarConstKeyword varConstKeyword = new VarConstKeyword();
            //varConstKeyword.varConstKeyword();

            ConsoleInOut consoleInOut = new ConsoleInOut();
            //consoleInOut.consoleInputOutput();

            ConditionalStatment conditionalStatments = new ConditionalStatment();
            //conditionalStatments.conditionalStatment();

            Loops loops = new Loops();
            //loops.loops();

            Format format = new Format();
            //format.format();

            TryParse tryParse = new TryParse();
            //tryParse.tryParse();

            FizzBuzz fizzBuzz = new FizzBuzz();
            //fizzBuzz.fizzBuzz();

            StringOperations stringOperations = new StringOperations();
            //stringOperations.stringOperations();
            //stringOperations.reverseString();

            List list = new List();
            //list.list();

            ArrayBasic array = new ArrayBasic();
            //array.array();

            Distionary_Basic distionary = new Distionary_Basic();
            //distionary.distionary();

            EvenOdd evenOdd = new EvenOdd();
            //evenOdd.evenOdd();
            evenOdd.multiplication();

        }
    }
}