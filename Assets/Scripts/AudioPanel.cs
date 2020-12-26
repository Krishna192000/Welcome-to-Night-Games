using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioPanel : MonoBehaviour {

	public Slider Volume1;
	public Dropdown Dropdown1;

	public AudioScript myAudioScript;

	List<string> forDropdown1 = new List<string>(){"BgMusic1", "BgMusic2", "BgMusic3"};

	// Use this for initialization
	void Start () {
		Dropdown1.AddOptions(forDropdown1);
	}

	public void setBackgroundMusicVolume(float value)
	{
		myAudioScript.setBackgroundMusicVolume (value);
	}

	public void changeBackgroundSound(int choice)
	{
		if (PlayerPrefs.GetInt ("bgMusicChoice") != choice) {
			PlayerPrefs.SetInt ("bgMusicChoice", choice);
			myAudioScript.playBackgroundMusic();
		}
	}
}
