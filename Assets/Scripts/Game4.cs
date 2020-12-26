using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Game4 : IComparable<Game3> {
		public string userName;
		public string DateTime4;
		public int Score4;

		public Game4(string uName, string newDateTime ,int score){
			userName = uName;
			DateTime4 = newDateTime;
			Score4 = score;
		}

		public int CompareTo(Game3 other){

			if (other == null)
				return 1;
			else
				return (int)(Score4 - other.Score3) ;
		}

		public void SetUserName4(string uName)
		{
			userName = uName;
		}

	public void SetDateTime4(string dateTime4)
	{
		DateTime4 = dateTime4;
	}
	public void SetScore4(int score4)
	{
		Score4 = score4;
	}


	public string GetDateTime4()
	{
		return DateTime4;
	}
	public int GetScore4()
	{
		return Score4;
	}
}
