using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeMobs : MonoBehaviour {
	public int life = 1;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (life == 0){
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter(Collision col){
		if(col.collider.gameObject.layer==LayerMask.NameToLayer("Sword")){
			life-=1;
		}
	}
}
	// Use this for initialization



		/*void OnTriggerEnter2D(Collider2D co) {
		if (co.name == "sword")
				Destroy(gameObject);
		}

}*/
