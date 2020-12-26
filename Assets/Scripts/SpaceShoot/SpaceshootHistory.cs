
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using UnityEngine.UI;
	using System;
	using System.IO;
	using System.Runtime.Serialization.Formatters.Binary;
	using System.Linq;
	using UnityEngine.SceneManagement;

	public class SpaceshootHistory : MonoBehaviour {
	private bool flag = true;

	public static SpaceshootHistory instance;
		public Game1 g1;
		public List<Game1> spacehis = new List<Game1>();

		public GameObject playerScoreEntryPrefab;
		// Use this for initialization


		// Update is called once per frame
		void Start () {
			LoadData ();
		}

		void Update(){
		if (flag)
			mySpecialFunction ();
			//LoadData ();
			//SaveData ();
		}
		public void SaveData(){
			//save login information
			BinaryFormatter bf1 = new BinaryFormatter();
			FileStream file1 = File.Create (Application.persistentDataPath + "/Spaceshoot.gd");
		List<Game1> userSpaceList = new List<Game1>(spacehis);
			bf1.Serialize(file1, userSpaceList);
			file1.Close();file1.Close ();
		}
		public void LoadData(){
			//load login information 
		if(File.Exists(Application.persistentDataPath + "/Spaceshoot.gd")) {
				BinaryFormatter bf1 = new BinaryFormatter();
			FileStream file1 = File.Open(Application.persistentDataPath + "/Spaceshoot.gd", FileMode.Open);
				List<Game1> userSpaceList = (List<Game1>) bf1.Deserialize(file1);
				file1.Close ();
			spacehis  = new List<Game1> (userSpaceList);
			}
		}

	public void mySpecialFunction()
	{
		string str2 = PlayerPrefs.GetString ("UserEmail");
		g1.SetUserName1 (str2);
		string str1 = PlayerPrefs.GetString ("dicDateTime1");
		g1.SetDateTime1(str1);
		int int2 = PlayerPrefs.GetInt("Score1");
		g1.SetScore1 (int2);

		//spacehis.Clear ();
		foreach (Game1 myGame in spacehis) {
			if (myGame.DateTime1 == str1 && myGame.userName == str2 && myGame.Score1 == int2) {
				spacehis.Remove (myGame);
			}
		}

		spacehis.Add (new Game1(str2, str1, int2));

		//Debug.Log (spacehis .Count());
		SaveData ();
		flag = false;
	}
}