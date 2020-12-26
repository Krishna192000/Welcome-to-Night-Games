using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	//Defining the  constants 
	enum elements {Rock = 1, Paper = 2, Scissor = 3}

	private int playerChoice = -1;
	private int computerChoice  = -1;

	private bool playersTurn = true;

	//setting other variables values
	int Computercount=0, playercount=0, counter=1, gameCounter=0;

	//declaring gameobject winnertext, ScoreText1, ScoreText2 to display output
	public GameObject WinnerText;
	public GameObject ScoreText1;
	public GameObject ScoreText2;
	public GameObject GamesPlayed;


	public Sprite paperImage, rockImage, scissorImage; // introducing images as sprite

	public GameObject computerChoiceImage;
	public AudioSource buttonClick;//Added button clicks to make it reliastic
	public AudioSource winMusic;//Added some music for fun
	public AudioSource LostMusic;

	public void moouseClick()
	{
		buttonClick.Play (); //play the button click music
	}

	// Update is called once per frame
	void Update () {
		for (int i =1;i<=10;i++) {
			if (playersTurn && playerChoice == -1)
				continue;
			else {
				ComputerChoose ();//calling function computerchoose to choose the value for computer
				checkWinner ();// checking the winner
				playerChoice = -1;//setting the value back to default
				playersTurn = true;
			}
			counter++;
		}

	}

	void checkWinner (){

		Text myText1 = WinnerText.GetComponent<Text> ();
		myText1.color = Color.white;

		if (playerChoice == computerChoice) {
			//draw
			myText1.text = " Draw";//writing the result after each move
			playercount++;//increamenting both counters
			Computercount++;
		}
		else if (playerChoice == 2 && computerChoice == 3) {
			//player wins
			myText1.text = " Player wins";
			playercount++;
		}
		else if (playerChoice == 3 && computerChoice == 2) {
			//Computer wins
			myText1.text = " Computer wins";
			Computercount++;
		}
		else if (playerChoice == 1 && computerChoice == 3) {
			//Computer wins
			myText1.text = " Computer wins";
			Computercount++;
		}
		else if (playerChoice == 3 && computerChoice == 1) {
			//Computer wins
			myText1.text = " Player wins";
			playercount++;
		}
		else if (playerChoice == 2 && computerChoice == 1) {
			//Computer wins
			myText1.text = " Computer wins";
			Computercount++;
		}
		else if (playerChoice == 1 && computerChoice == 2) {
			//player wins
			myText1.text = " Player wins";
			playercount++;
		}   

		score(playercount, Computercount);

		if (counter % 10 == 0) {
			WinnerDeclaration ();
			playercount = 0;
			Computercount = 0;
			GameScore ();

		}

	}
	public void ComputerChoose(){
		computerChoice = Random.Range (1, 4); //computer chooses the random value [1, 2, 3]

		if (computerChoice == 1) {
			computerChoiceImage.GetComponent<Image>().sprite = scissorImage; // if computer chhoses 1 then assign it the image of scissor
		}
		else if (computerChoice == 2) {
			computerChoiceImage.GetComponent<Image>().sprite = paperImage; // if computer chhoses 2 then assign it the image of paper
		}
		else {
			computerChoiceImage.GetComponent<Image>().sprite = rockImage; // if computer chhoses 3 then assign it the image of rock
		}
	}

	public void playerchoice (int choose ){

		playerChoice = choose; // taking the choice from the button clicked
		playersTurn = false;

	}

	// To declare the winner and displaying it on the screen
	public void WinnerDeclaration(){
		Text myText2 = WinnerText.GetComponent<Text> ();

		if (Computercount < playercount) 
		{
			myText2.color = Color.cyan; // setting the color to cyan
			myText2.text = " CONGRATULATIONS, YOU WON THE GAME";
			winMusic.Play ();
		} 
		else if (Computercount > playercount)
		{
			myText2.color = Color.red; // setting the color to red
			myText2.text = " SORRY, YOU LOST THE GAME";
			LostMusic.Play ();
		}
		else 
		{
			myText2.color = Color.magenta; // setting the color to magenta
			myText2.text = "  TIE ";
		}
		Application.Quit(); // to quit after 10 moves
	}

	public void score(int playerCount, int computerCount)
	{
		Text myText1 = ScoreText1.GetComponent<Text> ();
		Text myText2 = ScoreText2.GetComponent<Text> ();

		myText1.text = "Player: " + playerCount;
		myText2.text = "Computer: " + computerCount;

	}
	public void GameScore()
	{
		Text mytext3 = GamesPlayed.GetComponent<Text> ();
		gameCounter = gameCounter + 1;
		mytext3.text = "Games Played: " + gameCounter;
	}

	public void Quit()
	{
		Debug.Log ("quitting");
		Application.Quit();
	}
	public void quitRockPaperScissorScene()
	{
		SceneManager.LoadScene ("RockPaperScissorScene");//RockPaperScissorScene
	}
}