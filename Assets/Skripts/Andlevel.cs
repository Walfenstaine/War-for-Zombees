using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Andlevel : MonoBehaviour
{
    public string thisLvl, nextLvl;
    public void NextLevel()
    {
        SaveAndLoad.Instance.Save();
        SceneManager.LoadScene(nextLvl);
    }
    public void Reload()
    {
        SceneManager.LoadScene(thisLvl);
    }
}
