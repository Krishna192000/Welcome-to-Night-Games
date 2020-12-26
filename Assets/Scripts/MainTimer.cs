using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainTimer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	 float time = 0f;
	void FixedUpdate()
	{
		time = time + Time.deltaTime;
		PlayerPrefs.SetFloat("TimeTaken",Mathf.Round(time*10f)/10f);
	}
}
