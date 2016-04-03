using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour {

	public void OnCollisionEnter (Collision coll) {
		if (coll.gameObject.tag == "Player") {
			GameObject.FindGameObjectWithTag ("Game").GetComponent <Game>().level += 1;
			DontDestroyOnLoad (GameObject.Find ("ScoreManager"));
			Application.LoadLevel ("Score");
			PlayerPrefs.SetInt ("level", GameObject.FindGameObjectWithTag ("Game").GetComponent <Game> ().level);
	        
			GameObject.FindGameObjectWithTag ("Game").GetComponent <Game> ().coins += GameObject.Find("ScoreManager").GetComponent <ScoreManarer> ().star;
			PlayerPrefs.SetInt ("coins", GameObject.FindGameObjectWithTag ("Game").GetComponent <Game> ().coins);
		}
	}
}
