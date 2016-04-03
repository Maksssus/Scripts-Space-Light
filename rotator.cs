using UnityEngine;
using System.Collections;

public class rotator : MonoBehaviour {

	private float tiltAroundX;
	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		tiltAroundX += speed ;

		Quaternion target = Quaternion.Euler(0, tiltAroundX, 0);
		transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 2);
	}
}
