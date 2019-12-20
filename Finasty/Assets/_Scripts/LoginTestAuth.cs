using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;
using UnityEngine;
using UnityEngine.UI;
public class LoginTestAuth : MonoBehaviour
{
    public Text loginText;
    void Start()
    {
        Authentcate();
    }
    void Authentcate()
    {
        FindObjectOfType<AdManager>().RequestVideo();
        PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
        PlayGamesPlatform.InitializeInstance(config);
        // recommended for debugging:
        PlayGamesPlatform.DebugLogEnabled = true;
        // Activate the Google Play Games platform
        PlayGamesPlatform.Activate();
        Social.localUser.Authenticate((bool success) =>
        {
            if (success)
            {
                loginText.text = "Press Start !!";
            }
            else
            {
                loginText.text = "FAILED TO LOGIN !!";
            }
        });
    }
          
}
