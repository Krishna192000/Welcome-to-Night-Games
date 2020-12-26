using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;
public class MemoryGameControl : MonoBehaviour {
	public GameObject hisMemoryGamePanel;
 
	public void StartGameButtonClick(){
		string datetime = System.DateTime.Now.ToString ("yyyy/MM/dd HH:mm:ss");
		PlayerPrefs.SetString ("dicDateTime4",datetime);
		SceneManager.LoadScene ("MemoryGameScene");
	}
	public void closeHistoryPanel(){
		hisMemoryGamePanel.SetActive (false);

	}
	public void ExitMenuButtonClick(){
		MemoryGameHistory.instance.mySpecialFunction ();
		SceneManager.LoadScene ("AdminMainMenu");
	}
	public void openHistroyPanel(){
		hisMemoryGamePanel.SetActive (true);
	}
}
