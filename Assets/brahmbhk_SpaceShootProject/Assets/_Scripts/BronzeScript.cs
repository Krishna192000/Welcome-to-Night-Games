using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class BronzeScript : MonoBehaviour {

	public Dropdown totalEnemies,totalScore;

	public Toggle E1,E2,E3,E4,E5;
	//public Text t1,t2,t3;
	void Awake(){

		totalEnemies.value=PlayerPrefs.GetInt("BronzeEnemies");


	}
	public void setTotalScore(int index){
		string sc =totalScore.options[totalScore.value].text ;
		//t3.text ="Selected Value is "+sc ;
		int s =  System.Convert.ToInt32(sc);
		PlayerPrefs.SetInt ("totalBronzeScores",s );

	}
	public void setTotalEnemies(int index){
		string sc =totalEnemies.options[totalEnemies.value].text ;
		//t1.text ="Selected Value is "+sc ;
		int s =  System.Convert.ToInt32(sc);
		//System.Console.WriteLine ("TotalEnemies" + index);
		PlayerPrefs.SetInt ("BronzeEnemies", s);
	}
	public void onValueChanged(){

		bool e1Select, e2Select, e3Select, e4Select, e5Select;
		e1Select = E1.GetComponent<Toggle> ().isOn;
		e2Select = E2.GetComponent<Toggle> ().isOn;
		e3Select = E3.GetComponent<Toggle> ().isOn;
		e4Select = E4.GetComponent<Toggle> ().isOn;
		e5Select = E5.GetComponent<Toggle> ().isOn;


		if (e1Select) {
			PlayerPrefs.SetInt ("E1Bronze", 1);
		}
		if (e2Select) {
			PlayerPrefs.SetInt ("E2Bronze", 1);
		}
		if (e3Select) {
			PlayerPrefs.SetInt ("E3Bronze", 1);
		}
		if (e4Select) {
			PlayerPrefs.SetInt ("E4Bronze", 1);
		}if (e5Select) {
			PlayerPrefs.SetInt ("E5Bronze", 1);
		}




	}

	public void ButtonClick(){
	
		SceneManager.LoadScene ("MainMenuScene");
	
	}
}
