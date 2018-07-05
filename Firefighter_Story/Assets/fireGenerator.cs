using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireGenerator : MonoBehaviour {

	public float maxTime = 100;
	public float minTime = 60;
	//array for houses
	public GameObject[] houses;
	//current time
	private float time;
	//time to generate new fire
	private float fireTime;
	//index for house to burn
	private int i;
	//script of house to burn
	private houseBurner houseScript;

	// Use this for initialization
	void Start () {
		setRandomTime();
		time = 0;

		houses = GameObject.FindGameObjectsWithTag("House");
		
	}
	
	// Update is called once per frame
	void Update () {
		

		//count up
		time += Time.deltaTime;

		//check if time for new fire
		if (time >= fireTime) {
			setRandomHouseOnFire();
			setRandomTime();
		}
	}

	void setRandomHouseOnFire() {
		time = 0;
		i = Mathf.RoundToInt(Random.Range(0, houses.Length));
		houseScript = houses[i].GetComponent<houseBurner>();
		houseScript.burning = true;

	}

	void setRandomTime() {
		fireTime = Random.Range(minTime, maxTime);
	}
}
