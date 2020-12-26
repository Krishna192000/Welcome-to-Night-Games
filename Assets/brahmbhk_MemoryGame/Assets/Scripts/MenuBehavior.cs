using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuBehavior : MonoBehaviour {
	public AudioSource gameObject2;

	public void triggerMenuBehavior(int i)
	{
		switch (i) {
		default:
		case (1):
			SceneManager.LoadScene ("Level12");
			break;
		case (2):
			SceneManager.LoadScene ("Level18");
			break;
		case(0):
			SceneManager.LoadScene ("AdminMainMenu");
			break;
		}
	}

	public void clickVoice()
	{
		gameObject2.Play ();
	}
}
