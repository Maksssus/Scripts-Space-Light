using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using UnityEngine.Audio;

public class Game : MonoBehaviour {

	public Text gm;
	public Text level_S; 
	public Text coin; 
	public bool new_game;
	public int level;
	public int coins;
	public float time_Ads;
	public bool ads;
	GameObject ADS;

	void Start () {
		level = PlayerPrefs.GetInt ("level");
		coins = PlayerPrefs.GetInt ("coins");
		Advertisement.Initialize("1047987");
		if (GameObject.Find ("Game") != null && GameObject.Find ("Game")!= this.gameObject ) {
			Destroy (this.gameObject);
		}
		ADS = new GameObject ("ADS");
		Destroy(ADS,time_Ads);
		DontDestroyOnLoad (ADS);
	}

	void Update () {
		if (ADS == null) {
			ads = true;
		}
		DontDestroyOnLoad (this.gameObject);
	
		if (level == 0) {
			new_game = true;
		} else {
			new_game = false;
		}
		if (Application.loadedLevelName == "Menu") {
			if (GameObject.Find ("Game") != null && GameObject.Find ("Game")!=this.gameObject ) {
				Destroy (GameObject.Find ("Game"));
			}
			gm = GameObject.Find ("Play").GetComponent<Text> ();
			level_S = GameObject.Find ("Level").GetComponent<Text> ();
			coin = GameObject.Find ("Coins").GetComponent<Text> ();
			if (!new_game) {
				gm.text = "Продолжить";
			} else {
				gm.text = "Новая игра";
			}
			level_S.text = "Уровень: " + level;
			coin.text = "Звёзд собрано: " + coins;
			if (ads) {
				if (Advertisement.IsReady())
				{
					Advertisement.Show();
				}
				ADS = new GameObject ("ADS");
				Destroy(ADS,time_Ads);
				DontDestroyOnLoad(ADS);
				ads = false;
			}
		
		}
		if (Application.loadedLevelName == "Score") {
			if (ads) {
				if (Advertisement.IsReady())
				{
					Advertisement.Show();
				}
				ADS = new GameObject ("ADS");
				Destroy(ADS,time_Ads);
				DontDestroyOnLoad(ADS);
				ads = false;
			}
		}
	}
	public void ShowAds(){
		if (Advertisement.IsReady())
		{
			Advertisement.Show();
		}
	}
	public void ShowRewardedAd()
	{
		if (Advertisement.IsReady("rewardedVideoZone"))
		{
			var options = new ShowOptions { resultCallback = HandleShowResult };
			Advertisement.Show("rewardedVideoZone", options);
		}
	}

	private void HandleShowResult(ShowResult result)
	{
		switch (result)
		{
		case ShowResult.Finished:
			Debug.Log ("The ad was successfully shown.");
			coins += 250;
			break;
		case ShowResult.Skipped:
			Debug.Log("The ad was skipped before reaching the end.");
			break;
		case ShowResult.Failed:
			Debug.LogError("The ad failed to be shown.");
			break;
		}
	}
	public void OpenDev(){
		Application.OpenURL ("https://vk.com/magic_adventure_games");
	}
	public void Loadlevel(){
		level = PlayerPrefs.GetInt ("level");
		Destroy (GameObject.Find ("AdMobPlugin"));
		Application.LoadLevel (level+1);
	}
}
