using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Andlevel : MonoBehaviour
{
    public Data data;
    public string thisLvl, nextLvl;
    public void NextLevel()
    {
        if (data.lvlNumber > SceneManager.loadedSceneCount)
        {
            data.lvlNumber = 1;
        }
        SaveAndLoad.Instance.Save();
        SceneManager.LoadScene(nextLvl);
    }
    public void Reload()
    {
        SceneManager.LoadScene(thisLvl);
    }
}
