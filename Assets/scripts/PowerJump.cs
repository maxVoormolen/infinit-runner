using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerJump : MonoBehaviour {
	public Movement PlayerMovment;
	public PowerupManager PUM;
	
	
	// Use this for initialization
	void Start () {
		//GameObject g = GameObject.FindGameObjectWithTag (Playr);
		GameObject player = GameObject.Find("player");
		GameObject PUObject = GameObject.Find("PUManeger");

		//PlayerMovment = FindObjectOfType<Movement>();
  //      PUM = FindObjectOfType<PowerupManager>();


    }

	void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "PowerUp1")
        {
            PUM.PU1Power();
            PUM.setInfJumpActive(true);
            Destroy(col.gameObject);
        }
    }

}
