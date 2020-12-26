using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Game3 : IComparable<Game3> {
	public string userName;
	public string DateTime3;
	public int Score3;

	public Game3(string uName, string newDateTime ,int score){
		userName = uName;
		DateTime3 = newDateTime;
		Score3 = score;
	}

	public int CompareTo(Game3 other){

		if (other == null)
			return 1;
		else
			return (int)(Score3 - other.Score3) ;
	}

	public void SetUserName3(string uName)
	{
		userName = uName;
	}

	public void SetDateTime3(string dateTime3)
	{
		DateTime3 = dateTime3;
	}
	public void SetScore3(int score3)
	{
		Score3 = score3;
	}

	public string GetDateTime3()
	{
		return DateTime3;
	}
	public int GetScore3()
	{
		return Score3;
	}
}
