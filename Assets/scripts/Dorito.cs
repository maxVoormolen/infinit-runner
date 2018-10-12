using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dorito : MonoBehaviour
{

    public AudioSource nom;
    public SpriteRenderer ren;
    public BoxCollider2D col;

    bool triggered = false;

    private UpdateScoreText score;

    private void Start()
    {
        score = FindObjectOfType<UpdateScoreText>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {


        if (col.gameObject.tag == "Player")
        {
            if (!triggered)
            {
                triggered = true;
                nom.Play();
                score.AddScore(10);
                ren.enabled = false;
                Destroy(gameObject, 1000f);
            }
        }
    }

}
