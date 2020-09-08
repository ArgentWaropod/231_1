using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlinkoManager : MonoBehaviour
{
    public Canvas winScreen;
    public Canvas loseScreen;
    public GameObject ball;
    Scene scene;
    private void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        winScreen.gameObject.SetActive(false);
        loseScreen.gameObject.SetActive(false);
        ball.transform.Translate(Random.Range(-2.5f, 2.5f), 0, 0);
        scene  = SceneManager.GetActiveScene();
    }

    public void Victory()
    {
        winScreen.gameObject.SetActive(true);
    }
    public void Defeat()
    {
        loseScreen.gameObject.SetActive(true);
    }

    public void restart()
    {
        SceneManager.LoadScene(2);
    }
    public void menu()
    {
        SceneManager.LoadScene(0);
    }
}
