using UnityEngine;
using UnityEngine.SceneManagement;

public class menuchange : MonoBehaviour
{
    int virusHit;

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
        PlayerMaskHealth.Mask = 4;
        virusHit = VirusSpawner.currentAmmo = 5;
    }

    public void Change3()
    {
        SceneManager.LoadScene("tutorialiso");
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Change2();
        }
    }

}
