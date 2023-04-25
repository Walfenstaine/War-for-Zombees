using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using InstantGamesBridge;
public class SkillHelseMob : MonoBehaviour
{
    public Data data;
    public Text textUp;
    public Text textDown;

    [SerializeField] private Language languageUp;
    [SerializeField] private Language languageDown;

    public void SkillUp()
    {
        if (data.coins >= data.mobHelse * 5)
        {
            data.coins -= data.mobHelse* 5;
            data.mobHelse += 5;
        }
    }
    private void Update()
    {
        if (Bridge.platform.language == "ru")
        {
            textUp.text = languageUp.ru + data.mobHelse;
            textDown.text = languageDown.ru + data.mobHelse * 5;
        }
        else
        {
            textUp.text = languageUp.en + data.mobHelse;
            textDown.text = languageDown.en + data.mobHelse * 5;
        }
    }
}
