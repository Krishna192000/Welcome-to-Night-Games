using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLevelScript : MonoBehaviour {

	public void buttonClick(int i){
		if (i == 0) {
			SceneManager.LoadScene ("Bronze_Scene");

		} else if (i == 1) {
			SceneManager.LoadScene ("Silver_Scene");
		}else if (i == 2) {
			SceneManager.LoadScene ("Gold_Scene");
		}else if (i == 4)
		{
			SceneManager.LoadScene ("MainMenuScene");

		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
