using UnityEngine;
using UnityEngine.SceneManagement;

public class menuchange : MonoBehaviour
{

    public void Tutorial()
    {
      Invoke("Change", 2.0f);
    }
    public void Change()
    {
        SceneManager.LoadScene("Tutorial Test");
    }

    public void Change2()
    {
        SceneManager.LoadScene("LEVEL_01");
    }

    public void Change3()
    {
        SceneManager.LoadScene("tutorialiso");
    }



}
