using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;

public class ApplePickerHistory : MonoBehaviour {

	public static ApplePickerHistory instance;	
	private bool flag = true;


	public Game2 g2;
	public List<Game2> applePickerhis = new List<Game2>();

	public GameObject playerScoreEntryPrefab;
	// Use this for initialization
	
	// Update is called once per frame
	void Start () {
		LoadData ();
	}

	void Update(){
		if(flag)
			mySpecialFunction ();
		//LoadData ();
		//SaveData ();
	}
	public void SaveData(){
		//save login information
		BinaryFormatter bf1 = new BinaryFormatter();
		FileStream file1 = File.Create (Application.persistentDataPath + "/ApplePicker.gd");
		List<Game2> userAppleList = new List<Game2>(applePickerhis);
		bf1.Serialize(file1, userAppleList);
		file1.Close();file1.Close ();
	}
	public void LoadData(){
		//load login information 
		if(File.Exists(Application.persistentDataPath + "/ApplePicker.gd")) {
			BinaryFormatter bf1 = new BinaryFormatter();
			FileStream file1 = File.Open(Application.persistentDataPath + "/ApplePicker.gd", FileMode.Open);
			List<Game2> userAppleList = (List<Game2>)bf1.Deserialize(file1);
			file1.Close ();
			applePickerhis = new List<Game2> (userAppleList);
		}

	}

	public void mySpecialFunction()
	{
		string str2 = PlayerPrefs.GetString ("UserEmail");
		g2.SetUserName (str2);
		string str1 = PlayerPrefs.GetString ("dicDateTime");
		g2.SetDateTime2 (str1);
		int int2 = PlayerPrefs.GetInt("AppleScore");
		g2.SetScore2 (int2);

		//applePickerhis.Clear ();

		foreach (Game2 myGame in applePickerhis) {
			if (myGame.DateTime2 == str1 && myGame.userName == str2) {
				applePickerhis.Remove (myGame);
			}
		}

		applePickerhis.Add (new Game2(str2, str1, int2));

		//Debug.Log (applePickerhis.Count());
		SaveData ();
		flag = false;
	}
}
