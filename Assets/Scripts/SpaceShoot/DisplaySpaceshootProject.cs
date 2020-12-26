using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplaySpaceshootProject : MonoBehaviour {

	public SpaceshootHistory his ;
	public GameObject playerScoreEntryPrefab;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void  Update(){
		
		while(this.transform.childCount > 0) {
			Transform c = this.transform.GetChild(0);
			c.SetParent(null);  // Become Batman
			Destroy (c.gameObject);
		}
		//go.transform.Find ("Kills").GetComponent<Text>().text = "Value";
		//for(int i = 0; i < hisapplePicker.applePickerhis.Count(); i++) {
		//	Debug.Log ("this is my list");

		//}

		foreach(Game1 g1 in his.spacehis)
		{
			if (g1.userName == PlayerPrefs.GetString ("UserEmail")) {
				
				string str1 = g1.userName;

				string str2 = g1.DateTime1;
				int value2 = g1.Score1;
				string str3 = g1.Level1;
				if (str3 == null)
					str3 = "Bronze";
				//Debug.Log ("key : " + str1 + " Value1 " + str2 + " Value2 " + value2 );
				GameObject go = (GameObject)Instantiate (playerScoreEntryPrefab);
				//	go.transform.Find ("Username").GetComponent<Text>().text = "Key";

				//GameObject go = (GameObject)Instantiate(playerScoreEntryPrefab);
				go.transform.SetParent (this.transform);
				go.transform.Find ("Username").GetComponent<Text> ().text = str1;
				go.transform.Find ("Kills").GetComponent<Text> ().text = str2;
				go.transform.Find ("Deaths").GetComponent<Text> ().text = value2.ToString ();
				go.transform.Find ("Assists").GetComponent<Text> ().text = str3;
			}
		}

	}

}
