using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FirstSceneScript : MonoBehaviour {

	public void buttonClick(int i){
		if (i == 0) {
			SceneManager.LoadScene ("MainMenuScene");

		} else if (i == 1) {
			SpaceshootHistory.instance.mySpecialFunction ();
			SceneManager.LoadScene ("AdminMainMenu");
		}
	}

	void Awake()
	{
		//AudioMenuScript.S.changeBackgroundSound(1);
		//AudioController.instance.backgroundMusicSource.Play ();
		AudioController.instance.playBackgroundMusic();
		AudioController.instance.backgroundMusicSource.loop = true;
		//DontDestroyOnLoad (AudioController.instance.backgroundMusicSource);
	}

	// Use this for initialization
	void Start () {
		
	}
		
	// Update is called once per frame
	void Update () {
		
	}


}
