using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class houseBurner : MonoBehaviour {

	public float health = 100;
	public float fireLife;
	public bool burning = false;
	public bool extinguishing = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (burning == true) {
			health--;
		}
		if (extinguishing == true) {
			burning = false;
			fireLife--;
		}
		
	}

	public void burn() {
		print(this.gameObject.name + " is burning!");
	}
}
