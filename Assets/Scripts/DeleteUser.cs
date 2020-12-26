using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteUser : MonoBehaviour {

	public LoadSaveData lsd;
	public GameObject DeleteUserPanel;
	public GameObject userName;
	public Text promptUser;

	private string uname;

	public void openDeleteUserPanelPanel (){
		if(PlayerPrefs.GetString("UserEmail") == "admin")
			DeleteUserPanel.SetActive (true);
	}
	public void closeDeleteUserPanelPanel(){
		DeleteUserPanel.SetActive (false);
	}

	public void Delete()
	{
		uname = userName.GetComponent<InputField> ().text;
		if (lsd.login.ContainsKey (uname)) {
			lsd.login.Remove (uname);
			promptUser.text = "Deleted Successfully";
		}
		else
			promptUser.text = "This User doesn't exist";
		
	}
}
