using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour {
    
	void Start () {
	
	}

	void Update () {

	}
	void OnCollisionEnter (Collision coll){
		if (coll.collider.tag == "Player") {
			Application.LoadLevel (Application.loadedLevel);
		}else if(coll.collider.tag != "Player"){
			Destroy (coll.collider.gameObject);
		}
	}
}
