using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayRockPaperScissorHistory : MonoBehaviour {

	public RockPaperScissorHistory hisRockPaperScissor ;
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

	foreach(Game3 g3 in hisRockPaperScissor.rockPaperScissorhis)
		{
			if (g3.userName == PlayerPrefs.GetString ("UserEmail")) 
			{
				string str1 = g3.userName;

				string str2 = g3.DateTime3;
				int value2 = g3.Score3;
				string str3 = "";

				if (value2 == 0)
					str3 = "Player wins";
				else if (value2 == 1)
					str3 = "Comp wins";
				else if (value2 == 2)
					str3 = "Tie wins";

				//Debug.Log ("key : " + str1 + " Value1 " + str2 + " Value2 " + value2 );
				GameObject go = (GameObject)Instantiate (playerScoreEntryPrefab);
				go.transform.Find ("Username").GetComponent<Text> ().text = "Key";

				//GameObject go = (GameObject)Instantiate(playerScoreEntryPrefab);
				go.transform.SetParent (this.transform);
				go.transform.Find ("Username").GetComponent<Text> ().text = str1;
				go.transform.Find ("Kills").GetComponent<Text> ().text = str2;
				go.transform.Find ("Deaths").GetComponent<Text> ().text = str3;
				go.transform.Find ("Assists").GetComponent<Text> ().text = "";

			}
		}
	}
}
