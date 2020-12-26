using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AppleTree : MonoBehaviour
{
	[Header("Set in Inspector")]

	//Prefab for instantiating apples 
	public GameObject applePrefab;

	// Speed at which the AppleTree moves
	public float speed = 1f;

	//Distance where AppleTree turns around
	public float leftAndRightEdge = 10f;

	//Chance that the AppleTree will change the directons
	public float chanceToChangeDirections = 0.1f;

	// Rate at which Apples will be instantiated 
	public float secondsBetweenApplesDrops = 1f;

    // Start is called before the first frame update
    void Start()
    {
     	// Dropping apples every second  
		Invoke("DropApple" , 2f);

    }

    // Update is called once per frame
    void Update()
    {
		Vector3 pos = transform.position;
		pos.x += speed * Time.deltaTime;
		transform.position = pos;

		if (pos.x < -leftAndRightEdge) 
		{
			speed = Mathf.Abs (speed);
		}	
		else if(pos.x >leftAndRightEdge)
		{
			speed = -Mathf.Abs (speed);
		}



        //Basic MOvement 
		//Changing Directions
    }

	void OnDestroy()
	{
		SceneManager.LoadScene ("AdminMainMenu"); 
	}

	void FixedUpdate()
	{
		if(Random.value < chanceToChangeDirections)
		{
			speed *= -1;   // change the direction 
		}
	}

	void DropApple()
	{
		GameObject apple = Instantiate<GameObject> (applePrefab);
		apple.transform.position = transform.position;
		Invoke ("DropApple", secondsBetweenApplesDrops);
	}


	public void GoToAdminMainMenu()
	{
		SceneManager.LoadScene ("AdminMainMenu"); 
	}


}
