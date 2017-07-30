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
		float ennemiPosX = GameObject.Find ("zou_0").transform.position.x;
		float ennemiPosY = GameObject.Find ("zou_0").transform.position.y;
		float PosX = transform.position.x;
		float PosY = transform.position.y;

		/*if (ennemiPosX > PosX) {
			Debug.Log ("Link à gauche");
		}
		if (ennemiPosY > PosY) {
			Debug.Log ("Link en bas");
		}
		if (PosX > ennemiPosX) {
			Debug.Log ("Link à droite");
		}
		if (PosY > ennemiPosY) {
			Debug.Log ("Link en haut");
		}*/
		 
		/*if (ennemiPosX-PosX > 0) {
			if (ennemiPosY - PosY > ennemiPosX - PosX) {
				Debug.Log ("Link en bas");
			} else {
				Debug.Log ("Link à gauche");	
			}
		}
		if (PosX-ennemiPosX > 0) {
			if (ennemiPosY - PosY > ennemiPosX - PosX) {
				Debug.Log ("Link à droite");
			} else {
				Debug.Log ("Link en haut");	
			}
		}*/

		Vector2 MonstrePerso = GameObject.Find ("zou_0").transform.position - transform.position;
		Vector2 Horizontal = new Vector2 (1, 0);

		if ((AngleBetweenVector2 (MonstrePerso, Horizontal) > -45) && (AngleBetweenVector2 (MonstrePerso, Horizontal) < 45)) {
			Debug.Log ("Link à gauche");
		} else if ((AngleBetweenVector2 (MonstrePerso, Horizontal) > 45) && (AngleBetweenVector2 (MonstrePerso, Horizontal) < 135)) {
			Debug.Log ("Link en haut");
		} else if ((AngleBetweenVector2 (MonstrePerso, Horizontal) > -135) && (AngleBetweenVector2 (MonstrePerso, Horizontal) < -45)) {
			Debug.Log ("Link en bas");
		} else {
			Debug.Log ("Link à droite");
		}
	}

	float AngleBetweenVector2(Vector2 vec1, Vector2 vec2){
		Vector2 vec1Rotated90 = new Vector2(-vec1.y, vec1.x);
		float sign = (Vector2.Dot(vec1Rotated90, vec2) < 0) ? -1.0f : 1.0f;
		return Vector2.Angle(vec1, vec2) * sign;
	}


	public IEnumerator Invincibilite(){
		invincible = true;
		Debug.Log ("bla");
		yield return new WaitForSeconds (TempsInv);
		invincible = false;
	}
}
