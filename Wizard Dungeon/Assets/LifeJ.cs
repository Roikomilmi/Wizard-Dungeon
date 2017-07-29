using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeJ : MonoBehaviour {
	static int lifemax = 2;
	public int life = lifemax;

	void Update(){
		if (life == 0) {
			Destroy (gameObject);
		}
	}


	void OnTriggerEnter2D(Collider2D co) {
		if (co.name == "zou_0")
			life -= 1;
	}
		
}
