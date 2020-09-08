using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }
    public void Slasher()
    {
        SceneManager.LoadScene(1);
    }
    public void Plinko()
    {
        SceneManager.LoadScene(2);
    }
    
}
