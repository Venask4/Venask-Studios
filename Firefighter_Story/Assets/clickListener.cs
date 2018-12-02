using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickListener : MonoBehaviour {
	public GameObject fireTruckObject;
	private playerControl playerScript;
	private bool returning = false;
	private string direction = null;

	// Methods
    void OnMouseDown() {
    	if (playerScript.selected == true) {
    		returning = true;
    	}
    	print(Mathf.Abs(fireTruckObject.transform.position.x - transform.position.x));
    	if (Mathf.Abs(fireTruckObject.transform.position.x - transform.position.x) < 0.6f) {
    		print("vertical offsetting");
    		playerScript.vertOffsetting = true;
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
	}
	
	// Update is called once per frame
	void Update () {
		if (returning == true && direction == "SW") {
			playerScript.returnHomeSW();
		}
		if (returning == true && direction == "NW") {
			playerScript.returnHomeNW();
		}
		if (returning == true && direction == "SE") {
			playerScript.returnHomeSE();
		}
		if (returning == true && direction == "NE") {
			playerScript.returnHomeNE();
		}
	}
}
