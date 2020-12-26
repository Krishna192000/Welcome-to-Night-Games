using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundConfig : MonoBehaviour {

	public Dropdown backgroundChoices;

	public Slider backgroundScaleX;
	public Slider backgroundScaleY;

	public GameObject[] myGameObject;
	public SetLoginBackground slb;

	public Image[] image;

	void Awake()
	{
		backgroundScaleX.value = PlayerPrefs.GetFloat("bgScaleX");
		backgroundScaleY.value = PlayerPrefs.GetFloat("bgScaleY");
		backgroundChoices.value = PlayerPrefs.GetInt("bgImageIndex");
	}


	//Called by the dropdown menu to set the correct background image in the game
	public void setBackgroundIndex (int index)
	{
		slb.setBackgroundForLogin (index);

		for (int i = 0; i < 3; i++) {
			myGameObject [i].SetActive (false);
			image [i].enabled = false;
		}
		myGameObject [index].SetActive (true);
		image [index].enabled = true;

		PlayerPrefs.SetInt("bgImageIndex", index);
	}

	//Called by the slider to set the x axis background scale of the game image
	public void setBackgroundScaleX(float scale)
	{
		PlayerPrefs.SetFloat("bgScaleX", scale);
	}

	//Called by the slider to set the y axis background scale of the game image
	public void setBackgroundScaleY(float scale)
	{
		PlayerPrefs.SetFloat("bgScaleY", scale);
	}

}
