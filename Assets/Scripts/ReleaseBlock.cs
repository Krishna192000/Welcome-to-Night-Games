using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReleaseBlock : MonoBehaviour {

	public LoadSaveData lsd;
	public GameObject ReleaseBlockPanel;
	public GameObject userName;
	public Text promptUser;

	private string uname;

	public void openReleaseBlockPanel (){
		if(PlayerPrefs.GetString("UserEmail") == "admin")
			ReleaseBlockPanel.SetActive (true);
	}
	public void closeReleaseBlockPanel(){
		ReleaseBlockPanel.SetActive (false);
	}

	public void Release()
	{
		uname = userName.GetComponent<InputField> ().text;
		if (lsd.login.ContainsKey (uname)) {
			PlayerPrefs.SetString ("Status","NORMAL");
			promptUser.text = "Block Released";
		}
		else
			promptUser.text = "This User doesn't exist";

	}

}
