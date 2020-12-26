using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour {
	public Text timerText;
	private float startTime;
	private bool finish=false;
	private bool gamePaused = false;

	public GameObject pausepanel;
	//public static bool gameIsPaused = false;
	// Use this for initialization
	void Start () {

		startTime = Time.time;
		pausepanel.SetActive (false);

	}

	// Update is called once per frame
	void Update () {
		if (finish)
			return;
		if (!gamePaused) {
			float t = Time.time - startTime;
			string minutes = ((int)t / 60).ToString ();
			string seconds = (t % 60).ToString ("f2");
			timerText.text = minutes + ":" + seconds;
		}
	}
	public void finished(){
		finish = true;
		timerText.color = Color.yellow;
	}
	public void ButtonClick(int i ){
		if (i == 0) {
			pausepanel.SetActive (true);
			gamePaused = true;
			//Time.timeScale = 0f;
		}else if (i == 1) { // resume
			Time.timeScale = 1;
			//SceneManager.LoadScene ("_Scene_0");
			//SceneManager.UnloadScene ("_Scene_0");
			pausepanel.SetActive (false);
			gamePaused = false;
		} else if (i == 2) { // restart
			Time.timeScale = 1;
			SceneManager.LoadScene ("_Scene_0");
		}else if (i == 3) { // mainmenu
			SceneManager.LoadScene ("AdminMainMenu");
		}
	}
}