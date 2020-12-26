
	using UnityEngine;
	using System.Collections;
	using UnityEngine.UI;
	using UnityEngine.SceneManagement;

	//This script deals with saving and assigning the player configurations set in the background menu.
	public class Background : MonoBehaviour {

		//Hold a reference to the background choices dropdown to change its value to the one currently assigned
		public Dropdown backgroundChoices;
		public Image[] backgroundImages;


		//Hold a reference to the slider to change its value to the one currently assignmed
		public Slider backgroundScaleX;
		public Slider backgroundScaleY;

		//Upon opening the background menu, set the currently selected background image to the dropdown and the scaling factors to the slider
		void Awake()
		{
			backgroundScaleX.value = PlayerPrefs.GetFloat("backgroundScaleX");
			backgroundScaleY.value = PlayerPrefs.GetFloat("backgroundScaleY");
			backgroundChoices.value = PlayerPrefs.GetInt("backgroundImageIndex");
		}

		//Called by the dropdown menu to set the correct background image in the game
		public void setBackgroundIndex (int index)
		{
		for (int i = 0; i < 3; i++) {
				backgroundImages [i].gameObject.SetActive (false);
				backgroundImages [i].gameObject.transform.localScale = new Vector3 (PlayerPrefs.GetFloat ("backgroundScaleX"), PlayerPrefs.GetFloat ("backgroundScaleY"), 1f);
			}
			//int a = PlayerPrefs.GetInt ("backgroundImageIndex");
			backgroundImages [index].gameObject.SetActive (true);
			PlayerPrefs.SetInt("backgroundImageIndex", index);
		}

		//Called by the slider to set the x axis background scale of the game image
		public void setBackgroundScaleX(float scale)
		{
			PlayerPrefs.SetFloat("backgroundScaleX", scale);
		}

		//Called by the slider to set the y axis background scale of the game image
		public void setBackgroundScaleY(float scale)
		{
			PlayerPrefs.SetFloat("backgroundScaleY", scale);
		}


	public void ButtonClick (){
		SceneManager.LoadScene("ConfigurationScene");
	}
}

