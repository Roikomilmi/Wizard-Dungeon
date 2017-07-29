using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeJ : MonoBehaviour {
	static int lifemax = 2;
	public int life = lifemax;
	bool invincible = false;
	public int TempsInv;

	void Update(){
		if (life == 0) {
			Destroy (gameObject);
		}
	}


	void OnTriggerEnter2D(Collider2D co) {
		if (!invincible) {
			if (co.name == "zou_0") {
				life -= 1;
				StartCoroutine (Invincibilite ());
			}
		}
	}
	public IEnumerator Invincibilite(){
		invincible = true;
		Debug.Log ("bla");
		yield return new WaitForSeconds (TempsInv);
		invincible = false;
	}
}
