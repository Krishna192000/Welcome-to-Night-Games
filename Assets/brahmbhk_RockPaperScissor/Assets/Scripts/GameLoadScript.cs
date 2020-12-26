using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoadScript : MonoBehaviour {
	public AudioSource destroySource;
	public AudioSource buttonClick;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		DontDestroyOnLoad(destroySource.gameObject);
	}
	public void openRockPaperScissorScene()
	{
		SceneManager.LoadScene ("MyScene");
	}
	public void closeRockPaperScissorScene()
	{
		SceneManager.LoadScene ("AdminMainMenu");
	}
	public void moouseClick()
	{
		buttonClick.Play ();
	}

}
