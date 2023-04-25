using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using InstantGamesBridge;
public class SkillAtak : MonoBehaviour
{
    public Data data;
    public Text textUp;
    public Text textDown;

    [SerializeField] private Language languageUp;
    [SerializeField] private Language languageDown;

    public void SkillUp()
    {
        if (data.coins >= data.playerAtak * 50)
        {
            data.coins -= data.playerAtak * 50;
            data.playerAtak += 1;
        }
    }
    private void Update()
    {
        if (Bridge.platform.language == "ru")
        {
            textUp.text = languageUp.ru + data.playerAtak;
            textDown.text = languageDown.ru + data.playerAtak * 50;
        }
        else
        {
            textUp.text = languageUp.en + data.playerAtak;
            textDown.text = languageDown.en + data.playerAtak * 50;
        }
    }
}

