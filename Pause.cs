using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour {

	public GameObject pause;


	public void restartLevel(){
		Application.LoadLevel (Application.loadedLevel);
	}
	public void menu(){
		SceneManager.LoadScene ("Menu");
		Time.timeScale = 1;
	}
	public void Stop(){
		Time.timeScale = 0;
		pause.SetActive(true);
	}
	public void Start(){
		pause.SetActive(false);
		Time.timeScale = 1;
	}
}
