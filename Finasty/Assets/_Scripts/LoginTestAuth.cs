﻿using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;
using UnityEngine;
using UnityEngine.UI;
public class LoginTestAuth : MonoBehaviour
{
    public Text loginText;
    void Start()
    {

        PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
        PlayGamesPlatform.InitializeInstance(config);
        // recommended for debugging:
        PlayGamesPlatform.DebugLogEnabled = true;
        // Activate the Google Play Games platform
        PlayGamesPlatform.Activate();
        Social.localUser.Authenticate(success =>
        {
            if (success)
            {
                Debug.Log("Logged in Successfully");

            }
            else
            {
                Debug.Log("FAILED TO LOGIN");
                loginText.text = "FAILED TO LOGIN";
            }
        });
    }
          
}