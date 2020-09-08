using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEditor.U2D;
using UnityEngine.SceneManagement;

public enum states { PLAYING, WIN, LOSS };
public class SwipeScript : MonoBehaviour
{
    Vector2 start;
    Vector2 end;
    float distance;
    Touch touch;
    public GameObject damageDealer;
    GameObject hitpoint;
    float timer;
    public GameObject textOBJ;
    public Canvas winScreen;
    public Canvas loseScreen;
    states isPlaying;
    Scene thescene;
    public TextMeshProUGUI text;

    // Update is called once per frame

    private void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        winScreen.gameObject.SetActive(false);
        loseScreen.gameObject.SetActive(false);
        isPlaying = states.PLAYING;
        thescene = SceneManager.GetActiveScene();
        timer = 10;
    }
    void Update()
    {
        if (isPlaying == states.PLAYING)
        {
            timer -= Time.deltaTime;
            text.SetText(timer.ToString());
            if (Input.touchCount > 0)
            {
                touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Began)
                {
                    start = touch.position;
                }
                else if (touch.phase == TouchPhase.Ended)
                {
                    end = touch.position;
                    if (start != end)
                    {
                        damageDealer.GetComponent<Health>().damage();
                    }
                }
            }
            if (timer <= 0)
            {
                if (isPlaying != states.WIN)
                {
                    isPlaying = states.LOSS;
                    loseScreen.gameObject.SetActive(true);
                }
            }
        }
    }

    public void checkWin()
    {
        isPlaying = states.WIN;
        winScreen.gameObject.SetActive(true);
    }

    public void restart()
    {
        SceneManager.LoadScene(1);
    }
    public void menu()
    {
        SceneManager.LoadScene(0);
    }
}
