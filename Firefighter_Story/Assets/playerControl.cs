using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour {
	public GameObject player;
	public GameObject fireHouseObject;
	private clickListener fireHouseScript;
	public Vector3 home;

	// Variables
	Vector3 origin = new Vector3(0,0,0);
	public bool selected = false;
	public bool returning = false;
	public bool vertOffsetting = false;

	// Functions
	public void verticalOffsetMove() {
		if (player.transform.position.x >= 1.8f) {
			player.transform.Translate(-0.05f,0,0);
			if (player.transform.position.x <= 1.8f) {
				vertOffsetting = false;
			}
		}
		else {
			player.transform.Translate(0.05f,0,0);
			if (Mathf.Abs(player.transform.position.x - home.x) >= 0.6f) {
				vertOffsetting = false;
			}
		}
	}
	public void returnHomeNW() {
		if (vertOffsetting) {
			verticalOffsetMove();
			return;
		}
		else if (player.transform.position.x >= home.x + 0.5f){
			player.transform.Translate(-0.05f,0,0);
		}
		else if (player.transform.position.y < home.y -0.5f){
			player.transform.Translate(0,0.05f,0);
		}
		else if (player.transform.position.x >= home.x){
			player.transform.Translate(-0.05f,0,0);
		}
		else {
			returning = false;
		}
	}
	public void returnHomeNE() {
		if (vertOffsetting) {
			verticalOffsetMove();
			return;
		}
		else if (player.transform.position.x <= home.x - 0.5f){
			player.transform.Translate(0.05f,0,0);
		}
		else if (player.transform.position.y < home.y - 0.5f){
			player.transform.Translate(0,0.05f,0);
		}
		else if (player.transform.position.x <= home.x){
			player.transform.Translate(0.05f,0,0);
		}
		else {
			returning = false;
		}
	}
	public void returnHomeSW() {
		if (vertOffsetting) {
			verticalOffsetMove();
			return;
		}
		else if (player.transform.position.x >= home.x + 0.5f){
			player.transform.Translate(-0.05f,0,0);
		}
		else if (player.transform.position.y > home.y -0.5f){
			player.transform.Translate(0,-0.05f,0);
		}
		else if (player.transform.position.x >= home.x){
			player.transform.Translate(-0.05f,0,0);
		}
		else {
			returning = false;
		}
	}
	public void returnHomeSE() {
		if (vertOffsetting) {
			verticalOffsetMove();
			return;
		}
		else if (player.transform.position.x <= home.x - 0.5f){
			player.transform.Translate(0.05f,0,0);
		}
		else if (player.transform.position.y > home.y -0.5f){
			player.transform.Translate(0,-0.05f,0);
		}
		else if (player.transform.position.x <= home.x){
			player.transform.Translate(0.05f,0,0);
		}
		else {
			returning = false;
		}
	}

    void OnMouseDown() {
    	selected = true;
    	Debug.Log(selected);
    }		

	// Use this for initialization
	void Start () {
		fireHouseScript = fireHouseObject.GetComponent<clickListener>();
		home = fireHouseObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
