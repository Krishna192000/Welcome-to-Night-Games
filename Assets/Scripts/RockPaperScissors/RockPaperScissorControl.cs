using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RockPaperScissorControl : MonoBehaviour {
	public GameObject historyRockPaperScissorPanel;

	/*public void openApplePickerPanel (){
		ApplePickerPanel.SetActive (true);
	}
	public void closeApplePickerPanel(){
		ApplePickerPanel.SetActive (false);
	}*/
	public void StartGameButtonClick(){
		string datetime = System.DateTime.Now.ToString ("yyyy/MM/dd HH:mm:ss");
		PlayerPrefs.SetString ("dicDateTime3",datetime);
		SceneManager.LoadScene ("RockPaperScissorScene");
	}
	public void closeHistoryPanel(){
		historyRockPaperScissorPanel.SetActive (false);

	}
	public void ExitMenuButtonClick(){
		RockPaperScissorHistory.instance.mySpecialFunction ();
		SceneManager.LoadScene ("AdminMainMenu");
	}
	public void openHistroyPanel(){
		historyRockPaperScissorPanel.SetActive (true);
	}
}
