using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LifeJ : MonoBehaviour {
	static int lifemax = 2;	//Max points de vie, peut être changé en amont
	public int life = lifemax;
	bool invincible = false;
	public int TempsInv;	//Temps invincibilité, peut être changé en amont




	void Update(){			//Permet de savoir si le personnage est mort
		if (life == 0) {
			Destroy (gameObject);
		}
	}


	void OnTriggerEnter2D(Collider2D co) {	//Permet de trigger le fait qu'un ennemi nous touche
		if (!invincible) {
			if (co.name == "zou_0") {
				life -= 1;					//Pert 1 points de vie
				Recul();
				StartCoroutine (Invincibilite ());	//Rends invincible
			}
		}
	}

	public void Recul(){ //Permet de reculer quand des dégats sont pris

		Vector2 MonstrePerso = GameObject.Find ("zou_0").transform.position - transform.position;	//Vecteur entre le monstre, et le perso
		Vector2 Horizontal = new Vector2 (1, 0);													//Vecteur horizontal pour l'angle
		Vector2 Temp = (Vector2)transform.position;													//Vecteur temporaire pour le deplacement

		if ((AngleBetweenVector2 (MonstrePerso, Horizontal) > -45) && (AngleBetweenVector2 (MonstrePerso, Horizontal) < 45)) {
			Debug.Log ("Link à gauche");
			Temp += Vector2.left;
			transform.localPosition = Temp;
		} else if ((AngleBetweenVector2 (MonstrePerso, Horizontal) > 45) && (AngleBetweenVector2 (MonstrePerso, Horizontal) < 135)) {
			Debug.Log ("Link en haut");
		Temp += Vector2.up;
		transform.localPosition = Temp;
		} else if ((AngleBetweenVector2 (MonstrePerso, Horizontal) > -135) && (AngleBetweenVector2 (MonstrePerso, Horizontal) < -45)) {
			Debug.Log ("Link en bas");
		Temp += Vector2.down;
		transform.localPosition = Temp;
		} else {
			Debug.Log ("Link à droite");
		Temp += Vector2.right;
		transform.localPosition = Temp;
		}
	}

	float AngleBetweenVector2(Vector2 vec1, Vector2 vec2){			//Permet de calculer un angle entre deux vectors
		Vector2 vec1Rotated90 = new Vector2(-vec1.y, vec1.x);
		float sign = (Vector2.Dot(vec1Rotated90, vec2) < 0) ? -1.0f : 1.0f;
		return Vector2.Angle(vec1, vec2) * sign;
	}


	public IEnumerator Invincibilite(){								//Permet de rendre le personnage invincible pendant un temps donné
		invincible = true;
		Debug.Log ("bla");
		yield return new WaitForSeconds (TempsInv);
		invincible = false;
	}
}
