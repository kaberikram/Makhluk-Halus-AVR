using UnityEngine;
using UnityEngine.SceneManagement;

public class menuchange : MonoBehaviour
{

    public void Tutorial()
    {
      Invoke("Change", 2.0f);
    }
    public void TutorialISo()
    {
        Invoke("Change3", 2.0f);
    }
    public void Game()
    {
        Invoke("Change2", 2.0f);
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
