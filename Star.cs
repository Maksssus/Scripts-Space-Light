using UnityEngine;
using System.Collections;

public class Star : MonoBehaviour {


	void OnTriggerEnter(Collider col){
		if (col.CompareTag ("Player")) {
			GetComponent<AudioSource> ().Play ();
			GameObject.Find("ScoreManager").GetComponent<ScoreManarer> ().star += 1;
			Destroy (this.gameObject,0.5f);
		}
	}
}
