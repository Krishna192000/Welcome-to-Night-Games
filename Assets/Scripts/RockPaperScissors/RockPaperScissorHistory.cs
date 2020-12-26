using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;

public class RockPaperScissorHistory : MonoBehaviour {
	private bool flag = true;

	public static RockPaperScissorHistory instance;

	public Game3 g3;
	public List<Game3> rockPaperScissorhis = new List<Game3>();

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
		FileStream file1 = File.Create (Application.persistentDataPath + "/RockPaperScissor.gd");
		List<Game3> userRockList = new List<Game3>(rockPaperScissorhis);
		bf1.Serialize(file1, userRockList);
		file1.Close();file1.Close ();
	}
	public void LoadData(){
		//load login information 
		if(File.Exists(Application.persistentDataPath + "/RockPaperScissor.gd")) {
			BinaryFormatter bf1 = new BinaryFormatter();
			FileStream file1 = File.Open(Application.persistentDataPath + "/RockPaperScissor.gd", FileMode.Open);
			List<Game3> userRockList = (List<Game3>)bf1.Deserialize(file1);
			file1.Close ();
			rockPaperScissorhis  = new List<Game3> (userRockList);
		}

	}

	public void mySpecialFunction()
	{
		string str2 = PlayerPrefs.GetString ("UserEmail");
		g3.SetUserName3 (str2);
		string str1 = PlayerPrefs.GetString ("dicDateTime4");
		g3.SetDateTime3(str1);
		int int2 = PlayerPrefs.GetInt("Score4");
		g3.SetScore3 (int2);

		//rockPaperScissorhis.Clear ();

		foreach (Game3 myGame in rockPaperScissorhis) {
			if (myGame.DateTime3 == str1 && myGame.userName == str2) {
				rockPaperScissorhis.Remove (myGame);
			}
		}
		rockPaperScissorhis.Add (new Game3(str2, str1, int2));

		//Debug.Log (rockPaperScissorhis .Count());
		SaveData ();
		flag = false;
	}

}
