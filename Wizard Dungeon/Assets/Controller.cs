using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
	public float speed = 2f;
	Vector2 dest = Vector2.zero;

	// Use this for initialization
	void Start () {
		dest = transform.position;
	}

	// Update is called once per frame
	void FixedUpdate () {
		dest = transform.position;
		if ((Vector2)transform.position == dest) {
			CheckKeys ();
		}
		Vector2 dir = dest - (Vector2)transform.position;
		GetComponent<Animator>().SetFloat("DirX", dir.x);
		GetComponent<Animator>().SetFloat("DirY", dir.y);
		Debug.Log("x "+dir.x+" y "+dir.y);
	}

	void CheckKeys(){
		Vector2 posJ = (Vector2)transform.position;
		if(Input.GetKey(KeyCode.Q)){
			Debug.Log("CUL !");
			posJ += Vector2.left * speed * Time.deltaTime;
			transform.localPosition = posJ;
		}
		if(Input.GetKey(KeyCode.D)){
			posJ += Vector2.right * speed * Time.deltaTime;
			transform.localPosition = posJ;
		}
		if(Input.GetKey(KeyCode.Z)){
			posJ += Vector2.up * speed * Time.deltaTime;
			transform.localPosition = posJ;
		}
		if (Input.GetKey (KeyCode.S)) {
			posJ += Vector2.down * speed * Time.deltaTime;
			transform.localPosition = posJ;
		} else {
		}

	}
		
}