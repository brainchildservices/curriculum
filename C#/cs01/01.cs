using System;
namespace Brainchild.Curriculum.Solutions {
    /*
    Write a program that prints the numbers from 1 to 100 and for multiples of '3' print "Fizz" instead of the number 
    and for the multiples of '5' print "Buzz".

    1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, 
    Fizz ...
    */
    public class FizzBuzz{
        ///Accept one number and return a string(Fizz or Buzz or the number ) based on the aforementioned logic 
        public string Print(int number) {

                string element= number % 3 == 0 ? "Fizz" : number % 5 == 0 ? "Buzz" : number.ToString();
                return element;
            
        }
        ///Accept one number and return an array of strings(Fizz or Buzz or the number ) for each value 0 to num passed to the below function
        public string[] Print2(int num){

                string[] strings = new string[ num ];
                int i = 0;
                do {
                     strings[ i ] = Print( i + 1 );
                     i++;
                } while ( i < num );

            return strings;
        }
    }
}