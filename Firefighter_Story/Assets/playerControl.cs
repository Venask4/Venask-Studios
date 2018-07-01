using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour {
	public GameObject player;

	// Variables
	Vector3 origin = new Vector3(0,0,0);
	private bool returnCmd = false;
	public bool selected = false;

	// Functions
	void returnHome() {
		if (Input.anyKey == true) {
			returnCmd = true;
		}
		if (returnCmd == true) {
			if (player.transform.position.x >= -1.178f + 0.5f){
				player.transform.Translate(-0.025f,0,0);
			}
			else if (player.transform.position.y <= 0.486f){
				player.transform.Translate(0,0.025f,0);
			}
			else if (player.transform.position.x >= -1.178f){
				player.transform.Translate(-0.025f,0,0);
			}
			else {
				returnCmd = false;
			}
		}
	}

    void OnMouseDown() {
    	selected = true;
    	Debug.Log(selected);
    }		

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
