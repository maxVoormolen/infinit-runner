using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupManager : MonoBehaviour {
	public Movement PlayerMovment;
	public PowerJump powerjump;

	public bool isInfJumpActive = false;
	public float PU1Timer = 10;

    private void Start()
    {
        //powerjump = FindObjectOfType<PowerJump>();
        //PlayerMovment = FindObjectOfType<Movement>();
    }

    public bool getInfJumpActive(){
		return isInfJumpActive;
	}
	public void setInfJumpActive(bool infJump){
        isInfJumpActive = infJump;
    }
	
	void Update () {
	if (PU1Timer <= 0f){
		isInfJumpActive = false;
		PU1Timer = 10f;
		
	}
	if (isInfJumpActive == true && PU1Timer != 0f){
		PU1Timer -= Time.deltaTime;
		PlayerMovment.SetGrounded(true);
	}
	// ==================================================================================	
	}
	
	public void PU1Power ()
	{
		if (isInfJumpActive == true){
			PlayerMovment.SetGrounded(true);
			
			 
			if (PU1Timer <= 0f)	
			{
				PlayerMovment.SetGrounded(true);
				isInfJumpActive = false;
				
				
			}

		}
	}
	// ==================================================================================


}
