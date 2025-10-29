using UnityEngine;
using UnityEngine.SceneManagement;

public class Script : MonoBehaviour
{
    public string level1;
    public string level2;
    public string level3;

    public void Loadlevel1()
    {
        SceneManager.LoadScene(Level1);
    }

    public void Loadlevel2()
    {
        SceneManager.LoadScene(Level2);
    }

    public void Loadlevel3()
    {
        SceneManager.LoadScene(Level3);
    }
}
