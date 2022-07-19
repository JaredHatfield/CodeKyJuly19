using System;
namespace CodeKyJuly19
{
	public class UserScore
	{
		public UserScore(int userId, int score, String date)
		{
			this.UserId = userId;
			this.Score = score;
			this.Date = date;
		}
		public int UserId
        {
			get;
			set;
        }

		public int Score
		{
			get;
			set;
		}


		public String Date
		{
			get;
			set;
		}
	}
}

