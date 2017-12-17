using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinscript : MonoBehaviour
{

    [SerializeField]
    public Text ScoreText;
    static int score = 0;

    AudioSource coin;
    public void Start()
    {
        coin = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
       
        if (col.gameObject.tag == "Player")
        {
            coin.Play();
            Destroy(gameObject,0.2f);
            Destroy(GetComponent<CircleCollider2D>());  //Remove collider while we wait for object to destroy
            score++;
            ScoreText.text = "COINS : " + score;
        }

    }
}
