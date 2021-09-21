using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace testingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------String 1 Codingbat Title and Category--------//
            StringBuilder input = new StringBuilder();
            char userInput = 'y';


            do
            {
                input.Clear();
                
                Console.WriteLine("\t\tCategory List Codingbat String-1");
                string[,] x = { { "1. helloName", "\t\t2. makeAbba", "\t\t3. makeTags" },
                { "4. makeOutWord", "\t\t5.  extraEnd", "\t\t6. firstTwo" },
                { "7. firstHalf", "\t\t8. withoutEnd", "\t\t9. comboString" },
                { "10. nonStart", "\t\t11. left2", "\t\t12. right2" },
                { "13. theEnd", "\t\t14. withoutEnd2", "\t15. middleTwo" },
                { "16. endsLy", "\t\t17. nTwice", "\t\t18. twoChar" },
                { "19. middleThree", "\t20. hasBad", "\t\t21. atFirst" },
                { "22. lastChars", "\t\t23. conCat", "\t\t24. lastTwo" },
                { "25. seeColor", "\t\t26. frontAgain", "\t\t27. minCat" },
                { "28. extraFront", "\t\t29. without2", "\t\t30. deFront" },
                { "31. startWord", "\t\t32. withoutX", "\t\t33. withoutX2" }};
                //row count
                for (int a = 0; a < 11; a++)
                {
                    //column count
                    for (int b = 0; b < 3; b++)
                    {
                        Console.Write(x[a, b] + " ");
                    }
                    Console.WriteLine();
                }

                
                Console.Write("\nEnter Category Number: ");
                switchCase switch1 = new switchCase();
                switch1.SwitchTo();
            } while (userInput == 'y');            
            //helloName
            /*helloName hello = new helloName();
            hello.helloName1();
            */

            //makeAbba
            /*makeAbbaApp makeAbba1 = new makeAbbaApp();
            makeAbba1.makeAbba();
            */

            //makeTags
            /*
            makeTagsApp makeTag = new makeTagsApp();
            makeTag.tags();*/

            //makeOutOwrd
            /*makeOutWordApp makeout = new makeOutWordApp();
            makeout.makeOutWord();*/

            //extraEnd
            /*extraEndApp extraEnd1 = new extraEndApp();
            extraEnd1.extraEnd();*/

            //firstTwo
            /*firstTwoApp firstTwo1 = new firstTwoApp();
            firstTwo1.firstTwo();*/

            //withoutEnd
            /*withoutEndApp withoutEnd1 = new withoutEndApp();
            withoutEnd1.withoutEnd();*/
        }
    }
}
