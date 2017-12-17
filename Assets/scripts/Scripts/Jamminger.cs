using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Jamminger : MonoBehaviour
{
   public Text ScoreText;
    static int score = 0;
    [SerializeField]
    GameObject mExplosionPrefab;

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.layer == LayerMask.NameToLayer("BusterBullet"))
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            Instantiate(mExplosionPrefab, transform.position, Quaternion.identity);

           score++;
           ScoreText.text = "SCORE: "+score;
        }


    }
    
    void OnTriggerStay2D(Collider2D col)
    {
        if(col.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            col.GetComponent<player>().TakeDamage (1);
        }
    }
     

}
