using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemiesMenu : MonoBehaviour {

	List<string> numbers = new List<string>(){"5", "10", "15", "20", "25"};
	List<string> colours = new List<string>(){"GREYSCALE", "YELLOW", "GREEN", "RED", "BLUE"};

	public Dropdown Dropdown1;
	public Dropdown Dropdown2;
	public Dropdown Dropdown3;
	public Dropdown Dropdown4;
	public Dropdown Dropdown5;
	public Dropdown Dropdown6;
	public Dropdown Dropdown7;
	public Dropdown Dropdown8;
	public Dropdown Dropdown9;
	public Dropdown Dropdown10;


	// Use this for initialization
	void Start () {
		PopulateList ();
	}

	void PopulateList()
	{
		Dropdown1.AddOptions (numbers);
		Dropdown2.AddOptions (numbers);
		Dropdown3.AddOptions (numbers);
		Dropdown4.AddOptions (numbers);
		Dropdown5.AddOptions (numbers);

		Dropdown6.AddOptions (colours);
		Dropdown7.AddOptions (colours);
		Dropdown8.AddOptions (colours);
		Dropdown9.AddOptions (colours);
		Dropdown10.AddOptions (colours);

	}

	public void Dropdown_IndexChangedNumber1(int index)
	{
		PlayerPrefs.SetInt("enemy0PointsIndex", index);
		//Debug.Log("Dropdown1.value " + Dropdown1.value);
	}
	public void Dropdown_IndexChangedColours1(int index)
	{
		PlayerPrefs.SetInt("enemy0Colour", index);
		//Debug.Log("Dropdown6.value " + Dropdown6.value);
	}

	public void Dropdown_IndexChangedNumber2(int index)
	{
		PlayerPrefs.SetInt("enemy1PointsIndex", index);
		//Debug.Log("Dropdown2.value " + Dropdown2.value);
	}
	public void Dropdown_IndexChangedColours2(int index)
	{
		PlayerPrefs.SetInt("enemy1Colour", index);
		//Debug.Log("Dropdown7.value " + Dropdown7.value);
	}

	public void Dropdown_IndexChangedNumber3(int index)
	{
		PlayerPrefs.SetInt("enemy2PointsIndex", index);
		//Debug.Log("Dropdown3.value " + Dropdown3.value);
	}
	public void Dropdown_IndexChangedColours3(int index)
	{
		PlayerPrefs.SetInt("enemy2Colour", index);
		//Debug.Log("Dropdown8.value " + Dropdown8.value);
	}

	public void Dropdown_IndexChangedNumber4(int index)
	{
		PlayerPrefs.SetInt("enemy3PointsIndex", index);
		//Debug.Log("Dropdown4.value " + Dropdown4.value);
	}
	public void Dropdown_IndexChangedColours4(int index)
	{
		PlayerPrefs.SetInt("enemy3Colour", index);
		//Debug.Log("Dropdown9.value " + Dropdown9.value);
	}

	public void Dropdown_IndexChangedNumber5(int index)
	{
		PlayerPrefs.SetInt("enemy4PointsIndex", index);
		//Debug.Log("Dropdown5.value " + Dropdown5.value);

	}
	public void Dropdown_IndexChangedColours5(int index)
	{
		PlayerPrefs.SetInt("enemy4Colour", index);
		//Debug.Log("Dropdown10.value " + Dropdown10.value);
	}


	// Update is called once per frame
	void Update () {
		
	}

	public void buttonClick(int i){
		if (i == 0) {
			SceneManager.LoadScene ("ConfigurationScene");
		} 
	}
}
