using UnityEngine;


public class PlayerSound : MonoBehaviour {

    public AudioSource JumpSound;

    public void PlayJumpSound()
    {
        JumpSound.Play();
    }

}
