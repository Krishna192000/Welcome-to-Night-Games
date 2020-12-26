using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AudioMenuScript : MonoBehaviour {


	private FirstSceneScript FirstSceneGameobject;

	public Slider Volume1;
	public Slider Volume2;
	public Slider Volume3;
	public Slider Volume4;

	public Dropdown Dropdown1;
	public Dropdown Dropdown2;
	public Dropdown Dropdown3;
	public Dropdown Dropdown4;


	List<string> forDropdown1 = new List<string>(){"Music_bg", "Galaga_bg", "Ghostbuster_bg"} ;
	List<string> forDropdown2 = new List<string>(){"YouWinSound", "SuperMario"} ;
	List<string> forDropdown3 = new List<string>(){"explosion_asteroid", "explosion_enemy", "explosion_player"} ;
	List<string> forDropdown4 = new List<string>(){"Weapon_Enemy", "Weapon_Player", "Mario_Coin"} ;

	public void buttonClick(int i){
		if (i == 0) {
			SceneManager.LoadScene ("ConfigurationScene");
		}  
	}

	// Use this for initialization
	void Start () {
		populateList();
	}

	void populateList()
	{
		Dropdown1.AddOptions(forDropdown1);
		Dropdown2.AddOptions(forDropdown2);
		Dropdown3.AddOptions(forDropdown3);
		Dropdown4.AddOptions(forDropdown4);
	}
	// Update is called once per frame
	void Update () {

	}

	//latest
	public void setBackgroundMusicVolume(float value)
	{
		AudioController.instance.backgroundMusicSource.volume = value;	
	}

	public void setWinningMusicVolume(float value)
	{
		AudioController.instance.winningSource.volume = value;	
	}

	public void setShootingMusicVolume(float value)
	{
		AudioController.instance.shootingSource.volume = value;	
	}

	public void setDestroyMusicVolume(float value)
	{
		AudioController.instance.destroySource.volume = value;	
	}


	public void changeBackgroundSound(int choice)
	{

		if (PlayerPrefs.GetInt ("backgroundMusicChoice") != choice) {
			//AudioController.instance.backgroundMusicSource.clip = backgroundMusicChoice (choice);
			PlayerPrefs.SetInt ("backgroundMusicChoice", choice);
			AudioController.instance.playBackgroundMusic();

			//AudioController.instance.backgroundMusicSource.Play ();
			print("Changed to " + choice);
		}
	}

	public void changeWinningSound(int choice)
	{
		PlayerPrefs.SetInt ("winningMusicChoice", choice);

		//AudioController.instance.winningSource.clip = winningMusicChoice (choice);
		//AudioController.instance.winningSource.Play ();
		AudioController.instance.playWinningMusic();
	}

	public void changeShootingSound(int choice)
	{
		PlayerPrefs.SetInt ("shootingMusicChoice", choice);

		//AudioController.instance.shootingSource.clip = shootingMusicChoice (choice);
		//AudioController.instance.shootingSource.Play ();
		AudioController.instance.playShootingMusic();
	}

	public void changeDestroySound(int choice)
	{
		PlayerPrefs.SetInt ("destroyMusicChoice", choice);

		//AudioController.instance.winningSource.clip = destroyMusicChoice (choice);
		//AudioController.instance.destroySource.Play ();
	    AudioController.instance.playDestroyMusic();
	}
}
