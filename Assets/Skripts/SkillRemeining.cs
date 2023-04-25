using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using InstantGamesBridge;
public class SkillRemeining : MonoBehaviour
{
    public Data data;
    public Text textUp;
    public Text textDown;

    [SerializeField] private Language languageUp;
    [SerializeField] private Language languageDown;

    public void SkillUp()
    {
        if (data.coins >= data.playerHelse * 5)
        {
            data.coins -= data.playerHelse * 5;
            data.playerHelse += 5;
        }
    }
    private void Update()
    {
        if (Bridge.platform.language == "ru")
        {
            textUp.text = languageUp.ru + data.playerHelse;
            textDown.text = languageDown.ru + data.playerHelse*5;
        }
        else
        {
            textUp.text = languageUp.en + data.playerHelse;
            textDown.text = languageDown.en + data.playerHelse*5;
        }
    }
}
