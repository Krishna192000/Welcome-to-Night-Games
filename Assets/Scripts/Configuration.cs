using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class Configuration : MonoBehaviour {

	public GameObject ConfigurationPanel;
	public GameObject AudioPanel;
	public GameObject BackgroundPanel;
	public GameObject ScoreBoardPanel;
	public GameObject AppleHistoryPanel;
	public GameObject ScoreBoardPanel1;

	public void openConfigurationPanel (){
		ConfigurationPanel.SetActive (true);
	}
	public void closeConfigurationPanel(){
		ConfigurationPanel.SetActive (false);
	}

	public void openAudioPanel(){
		AudioPanel.SetActive (true);
		closeConfigurationPanel ();
	}

	public void closeAudioPanel(){
		AudioPanel.SetActive (false);
		openConfigurationPanel ();
	}

	public void openBackgroundPanel(){
		BackgroundPanel.SetActive (true);
		closeConfigurationPanel ();
	}

	public void closeBackgroundPanel(){
		BackgroundPanel.SetActive (false);
		openConfigurationPanel ();
	}

	public void openHistoryPanel(){
		ScoreBoardPanel.SetActive (true);
	}

	public void closeHistoryPanel(){
		ScoreBoardPanel.SetActive (false);
	}

	public void openAppleHistoryPanel(){
		AppleHistoryPanel.SetActive (true);
	}

	public void closeAppleHistoryPanel(){
		AppleHistoryPanel.SetActive (false);
	}

	public void openHistoryPanel1(){
		ScoreBoardPanel1.SetActive (true);
	}

	public void closeHistoryPanel1(){
		ScoreBoardPanel1.SetActive (false);
	}
}
