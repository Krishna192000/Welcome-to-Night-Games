using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class LoadSceneManager : MonoBehaviour {

	public AudioScript myAudioScript1;
	public Text promptMessage;

	public loginSheet ls;
	public void LoadExitButton (){
		Application.Quit ();
	}
	public void LoadMainMenu(){
		int count = 0;
		if (ls.validateLogin (Email, Password)) {
			PlayerPrefs.SetString ("UserEmail", Email);
			PlayerPrefs.SetString ("UserPassword", Password);
			PlayerPrefs.SetString ("date/time", System.DateTime.Now.ToString ("yyyy/MM/dd HH:mm:ss"));
			if (count >= 3)
				promptMessage.text = "You are blocked, admin needs to release the blocks";
			else {
				PlayerPrefs.SetInt ("bgMusicChoice", 1);
				myAudioScript1.playBackgroundMusic ();
				if (Email.Equals ("admin")) {
					promptMessage.text = "Welcome";
					SceneManager.LoadScene ("AdminMainMenu");
				} else {
					promptMessage.text = "Welcome";
					SceneManager.LoadScene ("UserMainMenu");
				}
			}
		} else {
			count++;
			promptMessage.text = "Error";
			print("IncorrectPassword");
			if (count == 3 && !(Email.Equals ("admin"))) {
				PlayerPrefs.SetString ("Status", "BLOCKED");
			}
		}
	}

	public GameObject email;
	public GameObject password;
	//public GameObject login;

	//public Button btnLogin;

	private string Email;
	private string Password;
	public ScoreManager scoreManager;

	void Start()
	{
		Screen.orientation = ScreenOrientation.Portrait;
		PlayerPrefs.SetInt ("bgMusicChoice", 1);
		myAudioScript1.playBackgroundMusic ();
		//scoreManager = gameObject.GetComponent<ScoreManager>();

	}

	void Update()
	{
		//set data to string from input fields
		Email = email.GetComponent<InputField>().text;
		Password = password.GetComponent<InputField> ().text;
		promptMessage.text = promptMessage.text;
		//btnLogin = login.GetComponent<Button> ();
		//btnLogin.onClick.AddListener (validateLogin);
	}
}

