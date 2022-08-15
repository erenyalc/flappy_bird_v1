using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class bird_fly : MonoBehaviour
{
    public bool isdead;

    public float velocity = 1f;
    public Rigidbody2D rb2D;

    public gameManager managerGame;
    public GameObject Dead_Screen;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            rb2D.velocity = Vector2.up * velocity;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "score_area")
        {
            managerGame.UpdateScore();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "dead_area")
        {
            isdead = true;
            Time.timeScale = 0;
            Dead_Screen.SetActive(true);
        }
    }

    
}
