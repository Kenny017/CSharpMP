using System;
using System.Collections.Generic;
using System.Text;

namespace testingApp
{
    class switchCase
    {
        public void SwitchTo()
        {
            int cat = Convert.ToInt32(Console.ReadLine());

            switch (cat)
            {
                case 1:
                    helloName hello = new helloName();
                    hello.helloName1();
                    break;
                case 2:
                    makeAbbaApp makeAbba1 = new makeAbbaApp();
                    makeAbba1.makeAbba();
                    break;
                case 3:
                    makeTagsApp makeTag = new makeTagsApp();
                    makeTag.tags();
                    break;
                case 4:
                    makeOutWordApp makeout = new makeOutWordApp();
                    makeout.makeOutWord();
                    break;
                case 5:
                    extraEndApp extraEnd1 = new extraEndApp();
                    extraEnd1.extraEnd();
                    break;
                case 6:
                    firstTwoApp firstTwo1 = new firstTwoApp();
                    firstTwo1.firstTwo();
                    break;
                case 7:
                    withoutEndApp withoutEnd1 = new withoutEndApp();
                    withoutEnd1.withoutEnd();
                    break;
                case 8:
                    firstHalfApp firstHalf1 = new firstHalfApp();
                    firstHalf1.firstHalf();
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;


                default:
                    if (cat > 33 || cat <= 0)
                    {

                        tryAgainClass tryAgain = new tryAgainClass();
                        tryAgain.TryAgain();
                    }
                    break;

            }
        }
    }
}