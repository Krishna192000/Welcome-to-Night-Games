using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConfigurationScript : MonoBehaviour {

		public void buttonClick(int i){
		if (i == 0) {
			SceneManager.LoadScene ("EnemiesMenu");

		} else if (i == 1) {
			SceneManager.LoadScene ("AudioMenu");
		} else if (i == 2) {
			SceneManager.LoadScene ("BackGroundScene");
		} else if (i == 3) {
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
