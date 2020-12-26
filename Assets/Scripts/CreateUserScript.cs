using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateUserScript : MonoBehaviour {
	
	public GameObject CreateUserPanel;
	public Text promptUser;
	public InputField UserEmail;
	public LoadSaveData lsd;

	public void openCreateUserPanel (){
		if(PlayerPrefs.GetString("UserEmail") == "admin")
			CreateUserPanel.SetActive (true);
	}
	public void closeCreateUserPanel(){
		CreateUserPanel.SetActive (false);
	}

	public bool createUser(string Email){
		
		if (!lsd.login.ContainsKey (Email)) {
			string Password = Email;
			lsd.login.Add (Email, Password);
			lsd.SaveData ();
			return true;
		} 
		else {
			return false;
		}
	}

	public void updatePromptMessage (){
		string sEmail = UserEmail.GetComponent<InputField> ().text;
		bool userCreated = createUser(sEmail);
		if (userCreated) {

			promptUser.text = "User Created Successfully";
			//closeCreateUserPanel ();

		} else {
			promptUser.text = "User already exists";

		}
	}
}
