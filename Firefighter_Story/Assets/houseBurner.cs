using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class houseBurner : MonoBehaviour {

	public int health = 100;
	public int fireLife = 100;
	public bool burning = false;
	public bool extinguishing = false;

	//sprites
	public Sprite house;
	public Sprite houseOnFire;
	public SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (burning == true) {
			health--;
			if (spriteRenderer.sprite != houseOnFire) {
				spriteRenderer.sprite = houseOnFire;
			}
		}
		if (extinguishing == true) {
			burning = false;
			fireLife--;
			if (fireLife < 0) {
				spriteRenderer.sprite = house;
				extinguishing = false;
			}
		}
		
	}

	public void burn() {
		print(this.gameObject.name + " is burning!");
		spriteRenderer.sprite = houseOnFire;
	}
}
