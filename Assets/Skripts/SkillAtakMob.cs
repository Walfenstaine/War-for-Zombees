using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using InstantGamesBridge;
public class SkillAtakMob : MonoBehaviour
{
    public Data data;
    public Text textUp;
    public Text textDown;

    [SerializeField] private Language languageUp;
    [SerializeField] private Language languageDown;

    public void SkillUp()
    {
        if (data.coins >= data.mobAtak * 50)
        {
            data.coins -= data.mobAtak * 50;
            data.mobAtak += 1;
        }
    }
    private void Update()
    {
        if (Bridge.platform.language == "ru")
        {
            textUp.text = languageUp.ru + data.mobAtak;
            textDown.text = languageDown.ru + data.mobAtak * 50;
        }
        else
        {
            textUp.text = languageUp.en + data.mobAtak;
            textDown.text = languageDown.en + data.mobAtak * 50;
        }
    }
}


