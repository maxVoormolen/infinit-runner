using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerjump : MonoBehaviour {
	public movement PlayerMovment;

	public bool isInfJumpActive = false;
	
	// Use this for initialization
	void Start () {
		//GameObject g = GameObject.FindGameObjectWithTag (Playr);
		GameObject player = GameObject.Find("player");
		PlayerMovment = player.GetComponent<movement> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (isInfJumpActive == true){
			PlayerMovment.SetGrounded(true);
		}
	}
}
