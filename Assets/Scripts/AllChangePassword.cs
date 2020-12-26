using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllChangePassword : MonoBehaviour {

	public LoadSaveData lsd;
	public GameObject ChangePasswordPanel;
	public GameObject confirmPassword;
	public GameObject password;
	public Text promptUser;
	private string Password, ConfirmPassword, OldPassword, userEmail;

	public void openChangePasswordPanel (){
		ChangePasswordPanel.SetActive (true);
	}
	public void closeChangePasswordPanel(){
		ChangePasswordPanel.SetActive (false);
	}

	public void changePassword()
	{
		Password = password.GetComponent<InputField> ().text;
		ConfirmPassword = confirmPassword.GetComponent<InputField> ().text;

		OldPassword = PlayerPrefs.GetString ("UserPassword");
		userEmail = PlayerPrefs.GetString ("UserEmail");

		if (OldPassword.Equals (Password) && Password.Equals (ConfirmPassword))
			promptUser.text = "Password cannot be the same as the old one";
		else if (Password.Equals (ConfirmPassword) && !(Password.Equals(userEmail))) {
			lsd.login.Remove (userEmail);
			lsd.login.Add (userEmail, Password);
			promptUser.text = "Password changed successfully";
		}
		else
			promptUser.text = "Error";
	}

}
