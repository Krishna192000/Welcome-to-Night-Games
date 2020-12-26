using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loginSheet : MonoBehaviour {

	public LoadSaveData lsd;

	public bool validateLogin(string newEmail, string newPassword)
	{
		if (newEmail.Equals ("admin") && newPassword.Equals (lsd.login ["admin"])) {
			//Debug.Log (" Admin Login ");
			return true;
		}
		else if (newEmail.Equals (newPassword) && newPassword.Equals(lsd.login [newEmail])) {
			//Debug.Log ("New User Created ");
			SceneManager.LoadScene("changePasswordScene");
		} 
		else if (lsd.login.ContainsKey (newEmail)) {
			string myPassword = lsd.login [newEmail];
			if (myPassword.Equals (newPassword))
				return true;
		}
		return false;
	}
}

