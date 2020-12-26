using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoldScript : MonoBehaviour {

	public Dropdown totalEnemies,totalScore;

	public Toggle E1,E2,E3,E4,E5;
	//public Text t1,t2,t3;
	void Awake(){

		totalEnemies.value=PlayerPrefs.GetInt("GoldEnemies");


	}
	public void setTotalScore(int index){
		string sc =totalScore.options[totalScore.value].text ;
		//t3.text ="Selected Value is "+sc ;
		int s =  System.Convert.ToInt32(sc);
		PlayerPrefs.SetInt ("totalScores",s );

	}
	public void setTotalEnemies(int index){
		string sc =totalEnemies.options[totalEnemies.value].text ;
		//t1.text ="Selected Value is "+sc ;
		int s =  System.Convert.ToInt32(sc);
		//System.Console.WriteLine ("TotalEnemies" + index);
		PlayerPrefs.SetInt ("GoldEnemies", s);
	}
	public void buttonClick(int i){
		if (i == 0) {
			//SceneManager.LoadScene ("MainMenuScene");

		} else if (i == 1) {
			SceneManager.LoadScene ("GameLevelScene");
		}
	}
	public void onValueChanged(){

		bool e1Select, e2Select, e3Select, e4Select, e5Select;
		e1Select = E1.GetComponent<Toggle> ().isOn;
		e2Select = E2.GetComponent<Toggle> ().isOn;
		e3Select = E3.GetComponent<Toggle> ().isOn;
		e4Select = E4.GetComponent<Toggle> ().isOn;
		e5Select = E5.GetComponent<Toggle> ().isOn;


		if (e1Select) {
			//t2.text ="E1 Selected" ;
			PlayerPrefs.SetInt ("E1Select", 1);

		}
		if (e2Select) {
			//t2.text ="E2 Selected";
			PlayerPrefs.SetInt ("E2Select", 1);

		}
		if (e3Select) {
			//t2.text="E3 Selected";
			PlayerPrefs.SetInt ("E3Select", 1);

		}
		if (e4Select) {
			//t2.text="E4 Selected";
			PlayerPrefs.SetInt ("E4Select", 1);

		}if (e5Select) {
			//t2.text ="E5 Selected";
			PlayerPrefs.SetInt ("E5Select", 1);

		}




	}
}
