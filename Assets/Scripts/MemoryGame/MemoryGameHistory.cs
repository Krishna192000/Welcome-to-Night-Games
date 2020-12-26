using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using UnityEngine.SceneManagement;

public class MemoryGameHistory : MonoBehaviour {
	private bool flag = true;

	public static MemoryGameHistory instance;
	public Game4 g3;
	public List<Game4> memoryGamehis = new List<Game4>();

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
		FileStream file1 = File.Create (Application.persistentDataPath + "/MemoryGame.gd");
		List<Game4> userMemoryList = new List<Game4>(memoryGamehis);
		bf1.Serialize(file1, userMemoryList);
		file1.Close();file1.Close ();
	}
	public void LoadData(){
		//load login information 
		if(File.Exists(Application.persistentDataPath + "/MemoryGame.gd")) {
			BinaryFormatter bf1 = new BinaryFormatter();
			FileStream file1 = File.Open(Application.persistentDataPath + "/MemoryGame.gd", FileMode.Open);
			List<Game4> userMemoryList = (List<Game4>) bf1.Deserialize(file1);
			file1.Close ();
			memoryGamehis  = new List<Game4> (userMemoryList);
		}

	}
	public void ExitMenuButtonClick(){
		SceneManager.LoadScene ("AdminMainMenu");
	}
	public void mySpecialFunction()
	{
		string str2 = PlayerPrefs.GetString ("UserEmail");
		g3.SetUserName4 (str2);
		string str1 = PlayerPrefs.GetString ("dicDateTime4");
		g3.SetDateTime4(str1);
		int int2 = PlayerPrefs.GetInt("Score4");
		g3.SetScore4(int2);

		//memoryGamehis.Clear();

		foreach (Game4 myGame in memoryGamehis) {
			if (myGame.DateTime4 == str1 && myGame.userName == str2 && myGame.Score4 == int2) {
				memoryGamehis.Remove (myGame);
			}
		}

		memoryGamehis.Add (new Game4(str2, str1, int2));

		//Debug.Log (memoryGamehis .Count());
		SaveData ();
		flag = false;
	}
}
