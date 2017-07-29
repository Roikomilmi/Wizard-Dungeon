using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evil : MonoBehaviour {

	// Use this for initialization



		void OnTriggerEnter2D(Collider2D co) {
		if (co.name == "sword")
				Destroy(gameObject);
		}

}
