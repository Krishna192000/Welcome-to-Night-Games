using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

	public void buttonClick(int i){
		if (i == 0) {
			SceneManager.LoadScene ("_Scene_0");
		} else if (i == 1) {
			SceneManager.LoadScene ("GameLevelScene");
		} else if (i == 2) {
			SceneManager.LoadScene ("ConfigurationScene");
		} else if (i == 3) {
			
		}else if(i == 4)
			SceneManager.LoadScene ("FirstScene");
		
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
