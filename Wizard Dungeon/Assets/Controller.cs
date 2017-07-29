using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
	bool check= false;

	public float speed = 2f;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		CheckKeys();

	}

	void CheckKeys(){
		Vector2 Truc = (Vector2)transform.position;
		if(Input.GetKey(KeyCode.Q)){
			Truc += Vector2.left * speed * Time.deltaTime;
			transform.localPosition = Truc;
		}
		if(Input.GetKey(KeyCode.D)){
			Truc += Vector2.right * speed * Time.deltaTime;
			transform.localPosition = Truc;
		}
		if(Input.GetKey(KeyCode.Z)){
			Truc += Vector2.up * speed * Time.deltaTime;
			transform.localPosition = Truc;
		}
		if(Input.GetKey(KeyCode.S)){
			Truc += Vector2.down * speed * Time.deltaTime;
			transform.localPosition = Truc;
		}


}

void OnCollisionEnter(Collision col){
	if(col.collider.gameObject.layer==LayerMask.NameToLayer("Coffre")){
		//CheckKeys();
		if(/*check == true*/ Input.GetKey(KeyCode.Mouse0)){
			Debug.Log ("Coffre");
		}
		//afficher dialogue de liste coffre
	}
}
}