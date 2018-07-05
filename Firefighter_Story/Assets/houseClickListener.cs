﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class houseClickListener : MonoBehaviour {
	public GameObject fireTruckObject;
	private playerControl playerScript;
	private bool returning = false;
	private string direction = null;
	private houseBurner burnerScript;

	// Methods
    void OnMouseDown() {
    	if (playerScript.selected == true) {
    		playerScript.home = transform.position;
    		playerScript.returning = true;
    		returning = true;
    	}
		if(fireTruckObject.transform.position.x > transform.position.x){
			if (fireTruckObject.transform.position.y > transform.position.y){
				direction = "SW";
			}
			else {
				direction = "NW";
			}
		}
		else if (fireTruckObject.transform.position.y > transform.position.y) {
			direction = "SE";
		}
		else {
			direction = "NE";
		}
    }

	// Use this for initialization
	void Start () {
		playerScript = fireTruckObject.GetComponent<playerControl>();
		burnerScript = GetComponent<houseBurner>();
	}
	
	// Update is called once per frame
	void Update () {
		if (returning == true && direction == "SW") {
			playerScript.returnHomeSW();
			if (playerScript.returning == false) {
				returning = false;
				burnerScript.extinguishing = true;
			}
		}
		if (returning == true && direction == "NW") {
			playerScript.returnHomeNW();
			if (playerScript.returning == false) {
				returning = false;
				burnerScript.extinguishing = true;
			}
		}
		if (returning == true && direction == "SE") {
			playerScript.returnHomeSE();
			if (playerScript.returning == false) {
				returning = false;
				burnerScript.extinguishing = true;
			}
		}
		if (returning == true && direction == "NE") {
			playerScript.returnHomeNE();
			if (playerScript.returning == false) {
				returning = false;
				burnerScript.extinguishing = true;
			}
		}
	}
}
