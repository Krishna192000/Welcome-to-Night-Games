﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CardManager : MonoBehaviour {
	
	public AudioSource gameObject2;
	public void clickVoice()
	{
		gameObject2.Play ();
	}
	public void goToMenuScene()
	{
		SceneManager.LoadScene ("MemoryGameScene");
		_matches = 0;
	}

	public Sprite[] cardFace;
	public Sprite cardBack;
	public GameObject[] cards;
	public Text matchText;

	private bool _init = false;
	public int _matches = 13;

	void Update () {
		if (!_init) {
			initializeCards ();
		}

		if (Input.GetMouseButtonUp (0)) {
			checkCards ();
		}
	}

	void initializeCards()
	{
		int runForThis = 0;
		string sceneName = SceneManager.GetActiveScene ().name;

		if (sceneName == "Level12") 
		{
			runForThis = 7;
			_matches = 6;
		}
		else if (sceneName == "Level18")
		{
			runForThis = 10;
			_matches = 9;
		}

		for (int id = 0; id < 2; id++) {
			for (int i = 1; i < runForThis; i++) {
				bool test = false;
				int choice = 0;
				while (!test) {
					choice = Random.Range (0, cards.Length);
					test = !(cards [choice].GetComponent<Card> ().initialized);
				}
				cards [choice].GetComponent<Card> ().cardValue = i;
				cards [choice].GetComponent<Card> ().initialized = true;
			}
		}
		foreach (GameObject c in cards) {
			c.GetComponent<Card> ().setupGraphics ();
		}

		if (!_init) {
			_init = true;
		}
	}
	public Sprite getCardBack(){
		return cardBack;
	}

	public Sprite getCardFace(int i)
	{
		return cardFace [i - 1];
	}

	void checkCards(){
		List<int> c = new List<int> ();

		for (int i = 0; i < cards.Length; i++) {
			if (cards [i].GetComponent<Card> ().state == 1) {
				c.Add (i);
			}
		}
		if (c.Count == 2) {
			cardComparison (c);
		}
	}

	void cardComparison(List<int> c)
	{
		Card.DO_NOT = true;

		int x = 0;

		if (cards [c [0]].GetComponent<Card> ().cardValue == cards [c [1]].GetComponent<Card> ().cardValue) {
			x = 2;
			_matches--;
			matchText.text = "Number of matches left: " + _matches;
			if (_matches == 0) {
				SceneManager.LoadScene ("Menu");
			}
		}

		for (int i = 0; i < c.Count; i++) {
			cards [c [i]].GetComponent<Card> ().state = x;
			cards [c [i]].GetComponent<Card> ().falseCheck ();
		}
	}
}
