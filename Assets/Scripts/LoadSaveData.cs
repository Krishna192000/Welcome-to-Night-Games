using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class LoadSaveData : MonoBehaviour {

	public GameObject playerScoreEntryPrefab;

	// Use this for initialization
	void Start () {
		//PlayerPrefs.SetInt ("backgroundMusicChoice", 1);
		LoadData ();
		if(!login.ContainsKey("admin"))
			login.Add ("admin", "admin");
	}
	
	// Update is called once per frame
	void Update () {
		SaveData ();
		LoadData ();

		while(this.transform.childCount > 0) {
			Transform c = this.transform.GetChild(0);
			c.SetParent(null);  // Become Batman
			Destroy (c.gameObject);
		}


		if (PlayerPrefs.GetString ("UserEmail") == "admin") {
				foreach (UserProfile uf in userData) {
				{
					string key = uf.userName;
					float finalTime = uf.timetaken;
					string dateTime = uf.datetime;
					string Status = uf.status;
					GameObject go = (GameObject)Instantiate (playerScoreEntryPrefab);

					//GameObject go = (GameObject)Instantiate(playerScoreEntryPrefab);
					go.transform.SetParent (this.transform);
					go.transform.Find ("Username").GetComponent<Text> ().text = key;
					go.transform.Find ("Kills").GetComponent<Text> ().text = dateTime;
					go.transform.Find ("Deaths").GetComponent<Text> ().text = finalTime.ToString ();
					go.transform.Find ("Assists").GetComponent<Text> ().text = Status;
				}
			}
		}
		else
		{
			foreach (UserProfile uf in userData) 
				{
				if (uf.userName == PlayerPrefs.GetString ("UserEmail")) 
					{
					string key = uf.userName;
						float finalTime = uf.timetaken;
						string dateTime = uf.datetime;
						string Status = uf.status;
						GameObject go = (GameObject)Instantiate (playerScoreEntryPrefab);

						//GameObject go = (GameObject)Instantiate(playerScoreEntryPrefab);
						go.transform.SetParent (this.transform);
						go.transform.Find ("Username").GetComponent<Text> ().text = "";
						go.transform.Find ("Kills").GetComponent<Text> ().text = dateTime;
						go.transform.Find ("Deaths").GetComponent<Text> ().text = finalTime.ToString ();
						go.transform.Find ("Assists").GetComponent<Text> ().text = "";
					}
				}
			}
		}

		
	public Dictionary<string, string> login = new Dictionary<string, string>();
	public List<UserProfile> userData = new List<UserProfile>();


	public void SaveData(){
		//save login information
		BinaryFormatter bf1 = new BinaryFormatter();
		FileStream file1 = File.Create (Application.persistentDataPath + "/Login.gd");
		Dictionary<string, string> userList = new Dictionary<string, string>(login);
		bf1.Serialize(file1, userList);
		file1.Close();


		//Save user information
		BinaryFormatter bf2 = new BinaryFormatter ();
		FileStream file2 = File.Create (Application.persistentDataPath + "/Users.gd"); 
		List< UserProfile> data = new List<UserProfile>(userData);
		bf2.Serialize (file2, data);
		file2.Close ();
	}



	public void LoadData(){
		//load login information 
		if(File.Exists(Application.persistentDataPath + "/Login.gd")) {
			BinaryFormatter bf1 = new BinaryFormatter();
			FileStream file1 = File.Open(Application.persistentDataPath + "/Login.gd", FileMode.Open);
			Dictionary<string, string> userList = (Dictionary<string,string>)bf1.Deserialize(file1);
			file1.Close ();
			login = new Dictionary<string, string> (userList);
		}


		//load user information
		if(File.Exists(Application.persistentDataPath + "/Users.gd")) { 
			BinaryFormatter bf2 = new BinaryFormatter();
			FileStream file2 = File.Open(Application.persistentDataPath + "/Users.gd", FileMode.Open);
			List<UserProfile> data = (List< UserProfile>)bf2.Deserialize(file2);
			file2.Close();
			userData = new List<UserProfile> (data); 
		}

	}
	
}
