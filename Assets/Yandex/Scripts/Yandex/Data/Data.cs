using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Data", order = 1)]
public class Data : ScriptableObject
{
    public int record;
    public int coins;
    public int food;
    public int waser;
    public int playerAtak;
    public int playerHelse;
    public int mobAtak;
    public int mobHelse;
    public string currentScene;
    public bool soundOn;
}
