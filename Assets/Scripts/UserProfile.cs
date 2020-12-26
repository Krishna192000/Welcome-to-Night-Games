using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class UserProfile : IComparable<UserProfile> {
	public string userName;
	public string datetime;
	public float timetaken ;
	public string status;

	public UserProfile(string UName, string newDateTime ,float TimeTaken, string Status){
		userName = UName;
		datetime = newDateTime;
		timetaken = TimeTaken;
		status = Status;
	}

	public int CompareTo(UserProfile other){
	
		if (other == null)
			return 1;
		else
			return (int)(timetaken - other.timetaken);
	}
	public void SetUserName(string UName)
	{
		userName = UName;
	}
	public void Setdatetime(string Datetime)
	{
		datetime = Datetime;
	}
	public void Settimetaken(float TimeTaken)
	{
		timetaken = TimeTaken;
	}
	public void Setstatus(string Status)
	{
		status = Status;
	}

	public string GetUserName()
	{
		return userName;
	}
	public string Getdatetime()
	{
		return datetime;
	}
	public float Gettimetaken()
	{
		return timetaken;
	}
	public string Getstatus()
	{
		return status;
	}
}
