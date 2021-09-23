using System;

namespace ExerciseStackOverFlowPost
{
    class Program
    {   /** 
            Design a class called Post. This class models a StackOverflow Post. It should have
            properties for title, description, and the date/time it was created.

            In this exercise, you will learn that a StackOverflow post should provide methods for
            up-voting and down-voting. You should give the ability to set the Vote property from
            the outside, because otherwise, you may accidentally change the votes of a class to 0
            or to a random number. And this is how we create bugs in our program. The class should
            always protect its state and hide its implementation detail.

            Aim of this exercise is to help you understand that classes should encapsulate data
            AND behaviour around that data. Beginners tend to create classes that are purely
            data containers, and other classes that are purely behaviour (methods) providers.
            This is not object-oriented programming. This is procedural programming. Such programs
            are very fragile. Making a change breaks many parts of the code.

        **/
        static void main(string[] args)
        {
            StackOverFlowPost Post1 = new StackOverFlowPost("Coding Problems","A post regarding coding problems and their solutions");
            Post1.DownVote();
            Post1.DownVote();
            Post1.UpVote();
            Post1.UpVote();
            Post1.UpVote();

            Console.WriteLine($"Current Vote: {Post1.currentVote()}, Created at: {Post1.DatePostCreated()}");
        }
    }

    class StackOverFlowPost
    {
        public string Title { get; set; }
        public string Description { get; set; }
        private readonly DateTime DateCreated = DateTime.Now;

        private int _vote = 0;
        //private int _downVote = 0;

        public StackOverFlowPost()
        {
            Title = "";
            Description = "";
        }

        public StackOverFlowPost(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public void UpVote() => _vote++;

        public void DownVote() => _vote--;

        public int currentVote() => _vote;

        public DateTime DatePostCreated()
        {
            return DateCreated;
        }
    }
}
