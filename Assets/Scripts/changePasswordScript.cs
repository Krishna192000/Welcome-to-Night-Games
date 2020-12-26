using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changePasswordScript : MonoBehaviour {

	public LoadSaveData lsd;
	public GameObject changePwd;
	public GameObject pwd;
	public GameObject UserName;
	private string  sPwd,sChangePwd, sUname;
	public Text promptMessage;

	public void checkPassword (){
		
		sUname = UserName.GetComponent<InputField> ().text;
		sPwd = pwd.GetComponent<InputField> ().text;
		sChangePwd = changePwd.GetComponent<InputField> ().text;

		if (pwd.Equals(sUname) && sChangePwd.Equals(sUname))  {
			promptMessage.text = "Please Enter Again....";
			} 
		else if (sChangePwd.Equals (sPwd) && lsd.login.ContainsKey (sUname) && !(sUname.Equals(sPwd))) {
			promptMessage.text = "Successfull";
			lsd.login.Remove (sUname);
			lsd.login.Add (sUname, sPwd);
			PlayerPrefs.SetString ("Status","NORMAL");
			SceneManager.LoadScene ("LoginScene");
		}

	}
	void Update()
	{
		promptMessage.text = promptMessage.text;
	}
}
