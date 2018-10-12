using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour {

    public float playerSpeed;  //allows us to be able to change speed in Unity

    public Vector2 jumpHeight;

    public BoxCollider2D col;

    public Text dedText;

    private CameraControl CamControl;

    public AudioSource deathSound;

    private PlayerSound sound;

    public bool isGrounded = false;
    public bool isDead = false;

    private void Start()
    {
        CamControl = FindObjectOfType<CameraControl>();
        sound = FindObjectOfType<PlayerSound>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(1);
        }

        if (!isDead && transform.position.y < 25) {
            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
            {
                if (isGrounded)
                {
                    GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);
                    sound.PlayJumpSound();
                    isGrounded = false;
                }


            }

            if (transform.position.y <= -20)
            {
                Die();
            }

        }
    }

    public bool GetGrounded(){
        return isGrounded;
    }

    public void SetGrounded(bool toggle){
        isGrounded = toggle;
    }
   

    void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.collider.tag == "Ground")
        {

            isGrounded = true;

        }

        if (collision.collider.tag == "Spike")
        {
            Die();
        }
    }

    public void Die()
    {
        col.enabled = false;
        isDead = true;
        CamControl.setDeath();
        dedText.enabled = true;
        deathSound.Play();
    }

}