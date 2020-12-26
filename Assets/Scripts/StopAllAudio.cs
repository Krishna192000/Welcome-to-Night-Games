using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAllAudio : MonoBehaviour {
	private AudioSource[] allAudioSources;
	public AudioScript myAudioScript1;

	// Use this for initialization
	void Start () {
		if (Application.loadedLevelName != "AdminMainMenu" || Application.loadedLevelName != "UserMainMenu") {
			Stop ();
			PlayOne ();
		}
	}
	public void Awake() {
		allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];	
	}

	public void Stop() {
		print ("Stopping all music");
		foreach (AudioSource audioS in allAudioSources) {
			audioS.Stop ();
		}
	}
	public void PlayOne()
	{
		myAudioScript1.playBackgroundMusic ();
	}
}
