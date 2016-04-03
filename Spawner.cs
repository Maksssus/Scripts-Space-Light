using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	public GameObject Player;

	void Start () {
		Instantiate (Player, this.transform.position, this.transform.rotation);
		GameObject.FindWithTag ("MainCamera").GetComponent<CameraFollow> ().target = GameObject.FindWithTag ("Player").gameObject.transform;
	}

}
