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
				Recul();
				StartCoroutine (Invincibilite ());
			}
		}
	}

	public void Recul(){
		 float ennemiPosX = GameObject.Find("zou_0").transform.position.x;
		 float ennemiPosY = GameObject.Find("zou_0").transform.position.y;
		 float PosX=transform.position.x;
		 float PosY=transform.position.y;

		if (ennemiPosX > PosX) {
			Debug.Log ("Link en haut");
		}
		if (ennemiPosY > PosY) {
			Debug.Log ("Link à droite");
		}
		if (PosX > ennemiPosX) {
			Debug.Log ("Link en bas");
		}
		if (PosY > ennemiPosY) {
			Debug.Log ("Link à gauche");
		}
		 
	}


	public IEnumerator Invincibilite(){
		invincible = true;
		Debug.Log ("bla");
		yield return new WaitForSeconds (TempsInv);
		invincible = false;
	}
}
