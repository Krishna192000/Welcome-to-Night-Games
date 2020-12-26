using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class controller : MonoBehaviour {

	public GameObject hisSpaceshootPanel;
	//private SpaceshootHistory spaceshoothistory;

	void Awake()
	{
		//spaceshoothistory = GetComponent<SpaceshootHistory>();
	}

	public void StartGameButtonClick(){
		string datetime = System.DateTime.Now.ToString ("yyyy/MM/dd HH:mm:ss");
		PlayerPrefs.SetString ("dicDateTime1",datetime);
		SceneManager.LoadScene ("_Scene_0");
		SceneManager.LoadScene ("_Scene_0");
	}
	public void closeHistoryPanel(){
		hisSpaceshootPanel.SetActive (false);
	}
	public void ExitMenuButtonClick(){
		SceneManager.LoadScene ("AdminMainMenu");
	}
	public void openHistroyPanel(){
		hisSpaceshootPanel.SetActive (true);
	}
	public void congifPanel(){
		SceneManager.LoadScene ("ConfigurationScene");
	}
	public void gameLevels(){
		SceneManager.LoadScene ("GameLevelScene");
	}

}