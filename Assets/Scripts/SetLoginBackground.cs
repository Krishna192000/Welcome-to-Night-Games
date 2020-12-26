using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetLoginBackground : MonoBehaviour {

	public GameObject[] myGameObject;

	public void setBackgroundForLogin(int index)
	{
		for (int i = 0; i < 3; i++) {
			myGameObject [i].SetActive (false);
		}
		myGameObject [index].SetActive (true);
	}
}
