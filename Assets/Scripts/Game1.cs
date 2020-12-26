using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Game1 : IComparable<Game1> {
	public string userName;
	public string DateTime1;
	public int Score1 = 0;
	public string Level1;

	public Game1(string uName, string newDateTime ,int score){
		userName = uName;
		DateTime1 = newDateTime;
		Score1 = score;
	}

	public int CompareTo(Game1 other){

		if (other == null)
			return 1;
		else
			return (int)(Score1 - other.Score1);
	}

	public void SetUserName1(string uName)
	{
		userName = uName;
	}
	public void SetDateTime1(string dateTime1)
	{
		DateTime1 = dateTime1;
	}
	public void SetScore1(int score1)
	{
		Score1 = score1;
	}
	public void SetLevel1(string level1)
	{
		Level1 = level1;
	}


	public string GetDateTime1()
	{
		return DateTime1;
	}
	public int GetScore1()
	{
		return Score1;
	}
	public string GetLevel1()
	{
		return Level1;
	}
}
