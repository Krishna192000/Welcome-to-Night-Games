using UnityEngine;
using System.Collections;


//The objective of this script is to initialize the playerprefs to the correct default values immediately when the game is started up.
//Therefore, this script is added to the start screen.
//This is necessary in the case that the user does not enter any configurations menus to change any of the values for the game to store.
//Therefore, the player can go immediately to play the game and everything will function correctly.

public class preInitializer : MonoBehaviour {

	void Start () {
		PlayerPrefs.DeleteAll();

		PlayerPrefs.SetInt ("backgroundMusicChoice", 1);
		PlayerPrefs.SetInt ("destroyMusicChoice", 1);
		PlayerPrefs.SetInt ("shootingMusicChoice", 1);
		PlayerPrefs.SetInt ("winningMusicChoice", 1);


		PlayerPrefs.SetInt("level", 1);
		PlayerPrefs.SetInt("backgroundImageIndex", 0);
		PlayerPrefs.SetFloat("backgroundScaleX", 1f);
		PlayerPrefs.SetFloat("backgroundScaleY", 1f);


		PlayerPrefs.SetInt("enemy0Colour", 0);
		PlayerPrefs.SetInt("enemy1Colour", 0);
		PlayerPrefs.SetInt("enemy2Colour", 0);
		PlayerPrefs.SetInt("enemy3Colour", 0);
		PlayerPrefs.SetInt("enemy4Colour", 0);

		PlayerPrefs.SetInt("enemy0PointsIndex", 0);
		PlayerPrefs.SetInt("enemy1PointsIndex", 1);
		PlayerPrefs.SetInt("enemy2PointsIndex", 2);
		PlayerPrefs.SetInt("enemy3PointsIndex", 3);
		PlayerPrefs.SetInt("enemy4PointsIndex", 4);

		if (!PlayerPrefs.HasKey("bronzeMaxEnemies")) { PlayerPrefs.SetInt("bronzeMaxEnemies", 2); }
		if (!PlayerPrefs.HasKey("bronzeE0")) { PlayerPrefs.SetInt("bronzeE0", 1); }
		if (!PlayerPrefs.HasKey("bronzeE1")) { PlayerPrefs.SetInt("bronzeE1", 1); }
		if (!PlayerPrefs.HasKey("bronzeE2")) { PlayerPrefs.SetInt("bronzeE2", 1); }
		if (!PlayerPrefs.HasKey("bronzeE3")) { PlayerPrefs.SetInt("bronzeE3", 0); }
		if (!PlayerPrefs.HasKey("bronzeE4")) { PlayerPrefs.SetInt("bronzeE4", 0); }
		if (!PlayerPrefs.HasKey("bronzeWinScore")) { PlayerPrefs.SetInt("bronzeWinScore", 100); }

		if (!PlayerPrefs.HasKey("silverMaxEnemies")) { PlayerPrefs.SetInt("silverMaxEnemies", 4); }
		if (!PlayerPrefs.HasKey("silverE0")) { PlayerPrefs.SetInt("silverE0", 1); }
		if (!PlayerPrefs.HasKey("silverE1")) { PlayerPrefs.SetInt("silverE1", 1); }
		if (!PlayerPrefs.HasKey("silverE2")) { PlayerPrefs.SetInt("silverE2", 1); }
		if (!PlayerPrefs.HasKey("silverE3")) { PlayerPrefs.SetInt("silverE3", 1); }
		if (!PlayerPrefs.HasKey("silverE4")) { PlayerPrefs.SetInt("silverE4", 0); }
		if (!PlayerPrefs.HasKey("silverWinScore")) { PlayerPrefs.SetInt("silverWinScore", 150); }

		if (!PlayerPrefs.HasKey("goldMaxEnemies")) { PlayerPrefs.SetInt("goldMaxEnemies", 6); }
		if (!PlayerPrefs.HasKey("goldE0")) { PlayerPrefs.SetInt("goldE0", 1); }
		if (!PlayerPrefs.HasKey("goldE1")) { PlayerPrefs.SetInt("goldE1", 1); }
		if (!PlayerPrefs.HasKey("goldE2")) { PlayerPrefs.SetInt("goldE2", 1); }
		if (!PlayerPrefs.HasKey("goldE3")) { PlayerPrefs.SetInt("goldE3", 1); }
		if (!PlayerPrefs.HasKey("goldE4")) { PlayerPrefs.SetInt("goldE4", 1); }
		if (!PlayerPrefs.HasKey("goldWinScore")) { PlayerPrefs.SetInt("goldWinScore", 200); }
	} 
}//end of PlayerPrefInitializer