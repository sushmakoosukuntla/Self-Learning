using System;
using System.Collections.Generic;
using System.Text;

namespace StopWatchStackOverFlowProject
{
    class Program
    {
        //Playing around stopwatch*****************************************************************
        static void Main(string[] args)
        {
            int option;
            var watch = new StopWatch();
            do
            {
                Console.WriteLine("1-start\n2-stop\n3-duration\n0-quit ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        watch.Start();
                        break;
                    case 2:
                        watch.Stop();
                        break;
                    case 3:
                        Console.WriteLine(watch.Duration());
                        break;

                }
            }
            while (option != 0);

            //*****************************************************************************************************

            //CALLING POST******************************************************************************************

            Post one = new Post("Learning", "Learning OOPS");
            Console.WriteLine("Title is :" + one.title);
            Console.WriteLine("Description is :" + one.description);
            Console.WriteLine("craeted on :" + one.createdOn);
            Console.WriteLine("vote count is :" + one.voteCount);
            one.UpVote();
            Console.WriteLine("vote count is :" + one.voteCount);
            one.DownVote();
            Console.WriteLine("vote count is :" + one.voteCount);


        }

    }
}
