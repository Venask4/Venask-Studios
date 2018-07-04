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

	// Functions
	public void returnHomeNW() {
		if (player.transform.position.x >= home.x + 0.5f){
			player.transform.Translate(-0.05f,0,0);
		}
		else if (player.transform.position.y < home.y -0.5f){
			player.transform.Translate(0,0.05f,0);
		}
		else if (player.transform.position.x >= home.x){
			player.transform.Translate(-0.05f,0,0);
		}
	}
	public void returnHomeNE() {
		if (player.transform.position.x < home.x - 0.5f){
			player.transform.Translate(0.05f,0,0);
			print("1");
		}
		else if (player.transform.position.y < home.y -0.5f){
			player.transform.Translate(0,0.05f,0);
			print("2");
		}
		else if (player.transform.position.x < home.x){
			player.transform.Translate(0.05f,0,0);
			print("3");
		}
	}
	public void returnHomeSW() {
		if (player.transform.position.x >= home.x + 0.5f){
			player.transform.Translate(-0.05f,0,0);
		}
		else if (player.transform.position.y > home.y -0.5f){
			player.transform.Translate(0,-0.05f,0);
		}
		else if (player.transform.position.x >= home.x){
			player.transform.Translate(-0.05f,0,0);
		}
	}
	public void returnHomeSE() {
		if (player.transform.position.x <= home.x - 0.5f){
			player.transform.Translate(0.05f,0,0);
		}
		else if (player.transform.position.y > home.y -0.5f){
			player.transform.Translate(0,-0.05f,0);
		}
		else if (player.transform.position.x <= home.x){
			player.transform.Translate(0.05f,0,0);
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
