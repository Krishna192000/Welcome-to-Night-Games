using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAudios : MonoBehaviour {

	public AudioSource buttonclick;

	public void ButtonClick()
	{
		buttonclick.Play ();
	}
}
