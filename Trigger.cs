using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {

	public string tag12;
	public GameObject most;
	public GameObject lamp;
	void Start (){
		most.SetActive (false);
	}

	void OnCollisionEnter (Collision coll){
		if (coll.collider.tag == tag12) {
			most.SetActive (true);
			lamp.GetComponent<Renderer>().material.color = Color.red;
		}
	}
	}

