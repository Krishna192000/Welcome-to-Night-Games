using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SilverScript : MonoBehaviour {

	public void buttonClick(int i){
		if (i == 0) {
			//SceneManager.LoadScene ("MainMenuScene");

		} else if (i == 1) {
			SceneManager.LoadScene ("GameLevelScene");
		}
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
