using UnityEngine;
using UnityEngine.SceneManagement;

public class menuchange : MonoBehaviour
{
    public void Change()
    {
        SceneManager.LoadScene("Tutorial_Scene");
    }

    public void Change2()
    {
        SceneManager.LoadScene("LEVEL_01");
    }



}
