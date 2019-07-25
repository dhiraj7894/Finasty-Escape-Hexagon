using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdManager : MonoBehaviour
{
    public static AdManager instance;

    public BannerView bannerView;
    public InterstitialAd video;
     private string appID = "ca-app-pub-7362258985735994~2376665647";
    //originalID
     private string bannerID = "ca-app-pub-7362258985735994/2572417825";
     private string videoID = "ca-app-pub-7362258985735994/1499009304";

    //Test Purpose
     //private string bannerID = "ca-app-pub-3940256099942544/6300978111";
     //private string videoID = "ca-app-pub-3940256099942544/1033173712";

   private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    private void Start()
    {
        MobileAds.Initialize(appID);
        RequestVideo();
    }
    public void RequestBanner()
    {
        bannerView = new BannerView(bannerID, AdSize.Banner, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().Build();
        bannerView.LoadAd(request);
        bannerView.Show();
    }
    public void HideBanner()
    {
        Debug.Log("Banner Hided");
        bannerView.Hide();
    }
    public void RequestVideo()
    {
        video = new InterstitialAd(videoID);
        AdRequest request = new AdRequest.Builder().Build();
        video.LoadAd(request);
    }
    public void ShowVideo()
    {
        if (video.IsLoaded())
        {
            video.Show();
            RequestVideo();
        }
        else
        {
            Debug.Log("Not loded Video");
            RequestVideo();
        }
    }

    
}

