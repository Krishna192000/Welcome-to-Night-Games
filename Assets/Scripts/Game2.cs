using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Game2 : IComparable<Game2> {
	public string userName;
	public string DateTime2;
	public int Score2;

	public Game2(string uName, string newDateTime ,int score){
		userName = uName;
		DateTime2 = newDateTime;
		Score2 = score;
	}

	public int CompareTo(Game2 other){

		if (other == null)
			return 1;
		else
			return (int)(Score2 - other.Score2);
	}

	public void SetUserName(string uName)
	{
		userName = uName;
	}
	public void SetDateTime2(string dateTime2)
	{
		DateTime2 = dateTime2;
	}
	public void SetScore2(int score2)
	{
		Score2 = score2;
	}

	public string GetDateTime2()
	{
		return DateTime2;
	}
	public int GetScore2()
	{
		return Score2;
	}

}
