using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    int health;
    public GameObject spawnpoint;
    public GameObject hitmarker;
    public GameObject manager;
    SwipeScript script;


    private void Start()
    {
        health = 150;
        script = manager.GetComponent<SwipeScript>();
    }
    public void damage()
    {
        GameObject text = Instantiate(hitmarker, spawnpoint.transform.position, Quaternion.identity);
        Rigidbody2D rb = text.GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(UnityEngine.Random.Range(-30, 30), UnityEngine.Random.Range(-30, 30)));
        health -= 25;
        if (health <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Ow");
            script.checkWin();
        }
    }
}
