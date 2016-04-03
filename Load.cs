using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Load : MonoBehaviour {
	public Slider slider;
	public int a_priority;

	AsyncOperation async;	
	IEnumerator LoadNewLevel()
	{
	 async = Application.LoadLevelAsync("Menu");
		async.priority = a_priority;
		Debug.Log ("dsfsdf");
		while(!async.isDone)
		{
			slider.value = async.progress;
			Debug.Log (async.progress);
			yield return null;
		}
		if (async.isDone) {
			Debug.Log ("Whileend");
			yield return async;
		}
	}
	void Start(){
			StartCoroutine (LoadNewLevel ());
	}
}
