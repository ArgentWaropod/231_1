using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    public GameObject obj;
    PlinkoManager manager;
    public bool isVictoryZone;

    private void Start()
    {
        manager = obj.GetComponent<PlinkoManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isVictoryZone)
        {
            manager.Victory();
        }
        else
        {
            manager.Defeat();
        }
    }
}
