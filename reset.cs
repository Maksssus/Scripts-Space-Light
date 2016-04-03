using UnityEngine;
using System.Collections;

public class reset : MonoBehaviour {

	public void Reset (){
		PlayerPrefs.DeleteAll ();
		GameObject.Find ("Game").GetComponent<Game> ().coins = 0;
		GameObject.Find ("Game").GetComponent<Game> ().level = 0;
		PlayerPrefs.SetInt ("level", 0);
		PlayerPrefs.SetInt ("coins",0);

	}
}
