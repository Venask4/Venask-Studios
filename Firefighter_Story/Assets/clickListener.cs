﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickListener : MonoBehaviour {
	public GameObject fireTruckObject;
	private playerControl playerScript;
	private bool returning = false;
	private string direction = null;
	private bool prevVertOffset = false;

	// Methods
	public void getDirection() {
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
	public void returnToFireHouse() {
		if (playerScript.selected == true) {
  		playerScript.home = transform.position;
  		playerScript.returning = true;
  		returning = true;
  	}
  	if (Mathf.Abs(fireTruckObject.transform.position.x - transform.position.x) < 0.6f) {
  		playerScript.vertOffsetting = true;
  	}
		getDirection();
	}
  void OnMouseDown() {
  	returnToFireHouse();
  }

	// Use this for initialization
	void Start () {
		playerScript = fireTruckObject.GetComponent<playerControl>();
	}
	
	// Update is called once per frame
	void Update () {
		if (prevVertOffset == true && playerScript.vertOffsetting == false) {
			getDirection();
			prevVertOffset = playerScript.vertOffsetting;
		}
		else {
			prevVertOffset = playerScript.vertOffsetting;
		}
		if (returning == true && direction == "SW") {
			playerScript.returnHomeSW();
			if (playerScript.returning == false) {
				returning = false;
			}
		}
		if (returning == true && direction == "NW") {
			playerScript.returnHomeNW();
			if (playerScript.returning == false) {
				returning = false;
			}
		}
		if (returning == true && direction == "SE") {
			playerScript.returnHomeSE();
			if (playerScript.returning == false) {
				returning = false;
			}
		}
		if (returning == true && direction == "NE") {
			playerScript.returnHomeNE();
			if (playerScript.returning == false) {
				returning = false;
			}
		}
	}
}
