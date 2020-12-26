using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MyGameManager : MonoBehaviour {

	public LoadSaveData lsd;

	public void LoadMainMenuScene()
	{
		SceneManager.LoadScene ("MainMenu");
	}
	public void LoadChangePasswordScene()
	{
		SceneManager.LoadScene ("changePasswordScene");
	}
	public void LoadLoginScene()
	{
		List<UserProfile> newUser = new List<UserProfile>();
		newUser.Add (new UserProfile (PlayerPrefs.GetString("UserEmail"),PlayerPrefs.GetString("date/time"), PlayerPrefs.GetFloat("TimeTaken"), PlayerPrefs.GetString("Status")));

		for (int i = 0; i < newUser.Count; i++) {
			//if (lsd.userData.Contains(PlayerPrefs.GetString ("UserEmail")))
				//lsd.userData.Remove (PlayerPrefs.GetString ("UserEmail"));
			lsd.userData.Add(newUser [i]);
		}
		SceneManager.LoadScene ("LoginScene");
	}
	public void onlyLoadLoginScene()
	{
		SceneManager.LoadScene ("LoginScene");
	}
	public void LoadStartGame()
	{
		SceneManager.LoadScene ("StartGame");
	}
	 string uname ,pwd;
	public void ButtonClick(){

		uname= PlayerPrefs.GetString ("UserEmail");
		Debug.Log ("USername : " + uname);
		pwd= PlayerPrefs.GetString ("UserPassword");
		Debug.Log ("Password : " + pwd);
		Debug.Log(PlayerPrefs.GetString("date/time"));
		Debug.Log(PlayerPrefs.GetFloat("TimeTaken"));
	}
}