using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeKyJuly19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IList<UserScore> userScores = new List<UserScore>();

            userScores.Add(new UserScore(1, 12, "2022-07-19"));
            userScores.Add(new UserScore(2, 10, "2022-07-18"));
            userScores.Add(new UserScore(3, 11, "2022-07-14"));
            userScores.Add(new UserScore(1, 9, "2022-07-10"));
            userScores.Add(new UserScore(1, 8, "2022-07-08"));
            userScores.Add(new UserScore(3, 8, "2022-07-08"));

            var ordered = from u in userScores orderby u.Score descending
                          where u.UserId == 1 && u.Score > 8 select u;

            foreach(UserScore u in ordered){
                Console.WriteLine(u.UserId + "\t" + u.Score + "\t" + u.Date);
            }

        }
    }
}

