using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnnemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public Transform ennemi;
	Vector2 Position= new Vector2();
	bool Timer = false;

	// Update is called once per frame
	void Update () {
		if (!Timer){
			StartCoroutine( Delai());
			Position = new Vector2(Random.Range(-8.30f , 8.30f) , Random.Range(-4.50f, 4.50f));
			Instantiate(ennemi, Position, transform.rotation);
		}
	}

	public IEnumerator Delai(){	
		
		Timer = true;
		yield return new WaitForSeconds (5);
		Timer = false;
	}

}
