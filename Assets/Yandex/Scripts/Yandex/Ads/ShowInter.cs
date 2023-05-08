using UnityEngine;
using InstantGamesBridge;
using InstantGamesBridge.Modules.Advertisement;
using pEventBus;




public class ShowInter : MonoBehaviour, IEventReceiver<ShowInterAds>
{
    public AudioSource sorse;
    public Data data;

    void OnEnable()
    {
        Bridge.advertisement.interstitialStateChanged += Interstitial;
        EventBus.Register(this);

        EventBus<ShowInterAds>.Raise(new ShowInterAds()
        {

        });
    }

    void OnDisable()
    {
        Bridge.advertisement.interstitialStateChanged -= Interstitial;
        EventBus.UnRegister(this);
    }

    void Start()
    {
        var ignoreDelay = false;
        Bridge.advertisement.ShowInterstitial(ignoreDelay, success =>
        {

        });
    }

    public void OnEvent(ShowInterAds e)
    {
        var ignoreDelay = false;
        Bridge.advertisement.ShowInterstitial(ignoreDelay, success =>
        {

        });
    }

    private void Interstitial(InterstitialState state)
    {
        if (state == InterstitialState.Closed)
        {
            sorse.mute = !data.soundOn;
        }


        if (state == InterstitialState.Opened)
        {
            Time.timeScale = 0;
            sorse.mute = true;
        }
    }
}