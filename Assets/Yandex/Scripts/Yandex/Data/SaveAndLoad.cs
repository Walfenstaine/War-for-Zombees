using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InstantGamesBridge;
using InstantGamesBridge.Modules.Leaderboard;
using InstantGamesBridge.Modules.Player;
using pEventBus;


public struct OnLoadIsComplete : IEvent
{

}


public class SaveAndLoad : MonoBehaviour
{
    public Data brash;
    public static SaveAndLoad Instance { get; private set; }

    [SerializeField] private Data myData;
    [SerializeField] private string id;

    private float time, record;

    private void Start()
    {
        brash.record = 0;
    }

    public void Load()
    {
        Bridge.storage.Get(id, OnGetCompleted);
    }

    public void Save()
    {
        if (Time.unscaledTime >= time + 5f)
        {
            time = Time.unscaledTime;
            string data = JsonUtility.ToJson(myData);
            Bridge.storage.Set(id, data, success =>
            {
                /*if(record < myData.record)
                {
                    record = myData.record;
                    SetBoard();
                }*/
            });
        }
    }


    /*private void SetBoard()
    {
        var _yandexLeaderboardNameInput = "LEADER1";
        Bridge.leaderboard.SetScore(
            success =>
            {

            },
            new SetScoreYandexOptions(myData.record, _yandexLeaderboardNameInput));
    }*/


    public void Reset()
    {
        SetInitValue();
        Bridge.storage.Delete(id, success =>
        {
        });
    }

    void SetInitValue()
    {
        myData.record = 1;
        myData.currentScene = "Scene1";
        myData.soundOn = true;
    }


    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
        time = Time.unscaledTime - 30f;
        record = 0;
    }

    private void OnGetCompleted(bool success, string data)
    {
        if (success && data != null)
        {
            JsonUtility.FromJsonOverwrite(data, myData);
        }
        else
        {
            SetInitValue();
        }

        EventBus<OnLoadIsComplete>.Raise(new OnLoadIsComplete()
        {

        });
    }


}
