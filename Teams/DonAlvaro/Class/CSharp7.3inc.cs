/***

using System;
using System.Collections;
using System.Text;

namespace Program
{
    class Point
    {   
        public int X  { get;}
        public int Y {get;}

        public string Label{ //Expression-bodied get/set accessors

            get => label;
            set => this.Label = value ?? "Default label";
        }
        public Point(double x, double y) => (X,Y) = (x,y); //EXPression-bodied Constructor, 

        //Expression Bodied Finalizer
        //~ExpressionMembersExamples() => Console.Error.WriteLine("Finalized!"); Consider using SafeHandle class instead of managing
        //unmanaged resources directly

        //Deconstruct Method provides a set of out arguments for each of the properties you want to extract. Consider
        //this method that provides a deconstructor to extracts the X and Y coordinates.
        public void Deconstruct(out int x, out int y) => (x,y) = (X,Y);

        static void main(string[] args) //Main can now have return types of int, C#7.1 Task or Task<int> return types.
        //May not need be public but still static
        {
            //Tuples //this names only exist at compile time
            (string Alpha, string Beta) namedLetters = ("a", "b");
            System.Console.WriteLine($"Named Letters: alpha:{namedLetters.Alpha}, beta:{namedLetters.Beta}");
            
            //Tuple Assignment Specifying the names of the fields on the right-hand side of the assignment
            var alphabetStart = (Alpha: "a", Beta: "b");
            System.Console.WriteLine( $"Alphabet Start alpha: {alphabetStart.Alpha}, beta: {alphabetStart.Beta}");

            //unpacking or deconstructing a tuple members of a tuple that were returned from a method.
            //Declaring separate variables for each of the values in the tuple.
            //(int max, int min) = Range(numbers);

            //Extracting the individual fields by assigning a Point to a tuple.
            var p = new Point(3,2);
            (int X, int Y) = p;

            int count = 5;
            string label = "Colors used in the map.";
            var pair = (count, label); // element names are "count" and "label"

            var (_, pop, _) = QueryCityData("New York City"); // Discards underscore variables are ignored after Deconstructing

            //Async main

            //Local Functions
            IEnumerable<char> characters = AlphabetSubset3('a','z');
            System.Console.WriteLine(characters);

        }

        //method example for discards
        private static (string name, int pop, double size) QueryCityData(string name)
        {
            if (name == "New York City")
                return (name, 8175133, 468.48);

            return ("", 0, 0);

        }

        //Local Functions
            //Many designs for classes include methods that are called from only one location.
            //These additional private methods keep each method small and focused.
            //Local functions enable you to declare methods inside the context of another method.
            //Local functions make it easier for readers of the class to see that the local method
            //is only called from the context in which it is declared.
        public static IEnumerable<char> AlphabetSubset3(char start, char end)
        {
            if (start < 'a' || start > 'z')
                throw new ArgumentOutOfRangeException(paramName: nameof(start), message: "start must be a letter");
                //throwing argument exceptions can now be used as throw expression
            if (end < 'a' || end > 'z')
                throw new ArgumentOutOfRangeException(paramName: nameof(end), message: "end must be a letter");

            if (end <= start)
                throw new ArgumentException($"{nameof(end)} must be greater than {nameof(start)}");

            return alphabetSubsetImplementation();

            IEnumerable<char> alphabetSubsetImplementation()
            {
                for (var c = start; c < end; c++)
                    yield return c;
            }
        }
        
        //Switch expression is no longer restricted to integral types, Enum types, string, or a nullable type. Any type maybe used.
        //Can test the type of the switch expression in each case label.
        //may add a when clause to further test conditions on a variable.
        //Order of Case labels is now important. the first branch to match is executed; others are skipped.
        //C# 7.1 the pattern expression for is and switch type pattern may have the type of a generic parameter.
        //Useful for checking types that may be either struct or class types and want to avoid boxing.
        public static int SumPositiveNumbers(IEnumerable<object> sequence)
        {
            int sum = 0;
            foreach (var i in sequence)
            {
                switch (i)
                {
                    case 0:
                        break;
                    case IEnumerable<int> childSequence:
                    {
                        foreach(var item in childSequence)
                            sum += (item > 0) ? item : 0;
                        break;
                    }
                    case int n when n > 0:
                        sum += n;
                        break;
                    case null:
                        throw new NullReferenceException("Null found in sequence");
                    default:
                        throw new InvalidOperationException("Unrecognized type");
                }
            }
            return sum;
        }
        //case 0: is a constant pattern
        //case IEnumerable<int> childSequence: is a declaration pattern.
        //case int n when n > 0: is a declaration pattern with an additional when condition
        //case null: is the null constant pattern
        //default: is the familiar default case.

    

    }

}
***/