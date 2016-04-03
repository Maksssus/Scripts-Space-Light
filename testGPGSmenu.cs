using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class testGPGSmenu : MonoBehaviour
{
	
	public GUISkin skin;
	public int incrementalCount = 5;
	
	//leaderboard strings
	private string leaderboard = "CgkI-4u3r8YBEAIQBg";
	//achievement strings
	private string achievement = "CgkI-4u3r8YBEAIQAQ";
	private string incremental = "CgkI-4u3r8YBEAIQAg";
	
	// Use this for initialization
	void Start()
	{
		PlayGamesPlatform.Activate();
	}
	
	// Update is called once per frame
	public void OnGUI()
	{
		GUI.skin = skin;
		skin.button.fixedWidth = Screen.width - 25;
		skin.textField.fixedWidth = Screen.width - 25;
		GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
		
		GUILayout.BeginVertical("box");
		
		GUILayout.Label("Официальный плагин Google Play Game Service");
		
		GUILayout.Space(20);
		
		//Share Status
		if (GUILayout.Button("Войти"))
		{
			Social.localUser.Authenticate((bool success) =>
			                              {
				if (success)
				{
					Debug.Log("You've successfully logged in");
				}
				else
				{
					Debug.Log("Login failed for some reason");
				}
			});
		}
		
		GUILayout.Space(20);
		
		//Achievement
		if (GUILayout.Button("Разблокировать ачивку"))
		{
			if (Social.localUser.authenticated)
			{
				Social.ReportProgress(achievement, 100.0f, (bool success) =>
				                      {
					if (success)
					{
						Debug.Log("You've successfully logged in");
					}
					else
					{
						Debug.Log("Login failed for some reason");
					}
				});
			}
		}
		
		GUILayout.Space(20);
		
		//Incremental Achievement
		if (GUILayout.Button("Нажать " + incrementalCount + "раз для разблокировки ачивки"))
		{
			if (Social.localUser.authenticated)
			{
				((PlayGamesPlatform)Social.Active).IncrementAchievement(incremental, 5, (bool success) =>
				                                                        {
					//The achievement unlocked successfully
				});
			}
		}
		
		GUILayout.Space(20);
		
		//Leaderboard
		if (GUILayout.Button("Заработать 5000 очков в рейтинг"))
		{
			if (Social.localUser.authenticated)
			{
				Social.ReportScore(5000, leaderboard, (bool success) =>
				                   {
					if (success)
					{
						((PlayGamesPlatform)Social.Active).ShowLeaderboardUI(leaderboard);
					}
					else
					{
						//Debug.Log("Login failed for some reason");
					}
				});
			}
		}
		
		GUILayout.Space(20);
		
		// Show Leaderboard
		if (GUILayout.Button("Показать лидеров"))
		{
			Social.ShowLeaderboardUI();
		}
		
		GUILayout.Space(20);
		
		//Show Specific Leaderboard
		if (GUILayout.Button("Показать спец. доску лидеров"))
		{
			((PlayGamesPlatform)Social.Active).ShowLeaderboardUI(leaderboard);
		}
		
		GUILayout.Space(20);
		
		//Show Achievments
		if (GUILayout.Button("Показать ачивки"))
		{
			Social.ShowAchievementsUI();
		}
		
		GUILayout.Space(20);
		
		//Sign Out
		if (GUILayout.Button("Выход"))
		{
			((PlayGamesPlatform)Social.Active).SignOut();
		}
		
		GUILayout.EndVertical();
		GUILayout.EndArea();
	}
}
