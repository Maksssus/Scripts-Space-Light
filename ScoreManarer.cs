using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManarer : MonoBehaviour {

	public int star;


	void Update(){
		if (Application.loadedLevelName == "Score") {
			if(star == 0){
				GameObject.Find ("Text").GetComponent<Text> ().text = "Ну хоть прошёл..";
			}
			
			if (star == 1) {
				GameObject.Find ("1").GetComponent<Image> ().color = Color.yellow;
				GameObject.Find ("Text").GetComponent<Text> ().text = "Хорошо!";
			}

			if (star == 2) {
				GameObject.Find ("1").GetComponent<Image> ().color = Color.yellow;
				GameObject.Find ("2").GetComponent<Image> ().color = Color.yellow;
				GameObject.Find ("Text").GetComponent<Text> ().text = "Отлично!";
			}
			if (star == 3) {
				GameObject.Find ("1").GetComponent<Image> ().color = Color.yellow;
				GameObject.Find ("2").GetComponent<Image> ().color = Color.yellow;
				GameObject.Find ("3").GetComponent<Image> ().color = Color.yellow;
				GameObject.Find ("Text").GetComponent<Text> ().text = "Превосходно!";
			}
			star = 0;
			Destroy (this.gameObject);
		}
	}
}
