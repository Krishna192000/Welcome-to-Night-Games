using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitToAdminMenu : MonoBehaviour {

	public SpaceshootHistory ssh;
	public ApplePickerHistory aph;
	public RockPaperScissorHistory rpsh;
	public MemoryGameHistory mgh;

	public void exitButton(int i)
	{
		if (i == 1) {
			ssh.mySpecialFunction ();
			SceneManager.LoadScene ("AdminMainMenu");
		}
		else if (i == 2) {
			aph.mySpecialFunction ();
			SceneManager.LoadScene ("AdminMainMenu");
		}
		else if (i == 3) {
			rpsh.mySpecialFunction ();
			SceneManager.LoadScene ("AdminMainMenu");
		}
		else if (i == 4) {
			mgh.mySpecialFunction ();
			SceneManager.LoadScene ("AdminMainMenu");
		}
	}
}
