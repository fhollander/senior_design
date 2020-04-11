using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotControl : MonoBehaviour

{


	
	public GameObject LowerPlatformBase;
	public GameObject LowerArm1;
	public GameObject LowerArm2;
	public GameObject LowerArm3;

	
	public GameObject LowerArm4;
	public GameObject LowerArm5;
	public GameObject LowerArm6;
	
	
	public GameObject LowerGear1;
	public GameObject LowerGear2;
	public GameObject LowerGear3;
	
	public GameObject UpperArm1;
	public GameObject UpperArm2;
	public GameObject UpperArm3;
	
	public GameObject UpperArm4;
	public GameObject UpperArm5;
	public GameObject UpperArm6;
	
	public GameObject Final1;
	public GameObject Final2;
	public GameObject Final3;
	public GameObject Final4;
	public GameObject Final5;
	public GameObject Final6;

	
    // Start is called before the first frame update
    void Start()
    {
        LowerPlatformBase.transform.Rotate(0.0f, 0.0f, 0.0f, Space.Self);
    }
    
    
    // Update is called once per frame
    void Update()
    {
       	if (Input.GetKey(KeyCode.A)){
        	LowerPlatformBase.transform.Rotate(0.0f, 1.0f, 0.0f, Space.Self);
         }
         if (Input.GetKey(KeyCode.D)){
        	LowerPlatformBase.transform.Rotate(0.0f, -1.0f, 0.0f, Space.Self);
         }
         if (Input.GetKey(KeyCode.W)){
          if (LowerArm1.transform.localRotation.x < .453){
         	LowerArm1.transform.Rotate(1.0f, 0.0f, 0.0f, Space.Self);
         	LowerArm2.transform.Rotate(1.0f, 0.0f, 0.0f, Space.Self);
         	LowerArm3.transform.Rotate(1.0f, 0.0f, 0.0f, Space.Self);
         	LowerGear1.transform.Rotate(-.5f, 0.0f, 0.0f, Space.Self);
         	LowerGear2.transform.Rotate(-.5f, 0.0f, 0.0f, Space.Self);
         	LowerGear3.transform.Rotate(-.5f, 0.0f, 0.0f, Space.Self);
         	
         	LowerArm4.transform.Rotate(1.0f, 0.0f, 0.0f, Space.Self);
         	LowerArm5.transform.Rotate(1.0f, 0.0f, 0.0f, Space.Self);
         	LowerArm6.transform.Rotate(1.0f, 0.0f, 0.0f, Space.Self);
         	
         	}
         }
         if (Input.GetKey(KeyCode.S)){
         	if (LowerArm1.transform.localRotation.x > -.422){
         	LowerArm1.transform.Rotate(-1.0f, 0.0f, 0.0f, Space.Self);
         	LowerArm2.transform.Rotate(-1.0f, 0.0f, 0.0f, Space.Self);
         	LowerArm3.transform.Rotate(-1.0f, 0.0f, 0.0f, Space.Self);
         	LowerGear1.transform.Rotate(.5f, 0.0f, 0.0f, Space.Self);
         	LowerGear2.transform.Rotate(.5f, 0.0f, 0.0f, Space.Self);
         	LowerGear3.transform.Rotate(.5f, 0.0f, 0.0f, Space.Self);
         	
         	LowerArm4.transform.Rotate(-1.0f, 0.0f, 0.0f, Space.Self);
         	LowerArm5.transform.Rotate(-1.0f, 0.0f, 0.0f, Space.Self);
         	LowerArm6.transform.Rotate(-1.0f, 0.0f, 0.0f, Space.Self);
         	}
         }
         
         if (Input.GetKey(KeyCode.UpArrow)){
       		  if (UpperArm1.transform.localRotation.x < .4){
        		UpperArm1.transform.Rotate(1.0f, 0.0f, 0.0f, Space.Self);
        		UpperArm2.transform.Rotate(1.0f, 0.0f, 0.0f, Space.Self);
        		UpperArm3.transform.Rotate(1.0f, 0.0f, 0.0f, Space.Self);
        		Final1.transform.Rotate(.50f, 0.0f, 0.0f, Space.Self);
        		Final2.transform.Rotate(.50f, 0.0f, 0.0f, Space.Self);
        		Final3.transform.Rotate(.50f, 0.0f, 0.0f, Space.Self);
        		
        		UpperArm4.transform.Rotate(1.0f, 0.0f, 0.0f, Space.Self);
        		UpperArm5.transform.Rotate(1.0f, 0.0f, 0.0f, Space.Self);
        		UpperArm6.transform.Rotate(1.0f, 0.0f, 0.0f, Space.Self);
        		Final4.transform.Rotate(.50f, 0.0f, 0.0f, Space.Self);
        		Final5.transform.Rotate(.50f, 0.0f, 0.0f, Space.Self);
        		Final6.transform.Rotate(.50f, 0.0f, 0.0f, Space.Self);
        	}
    	  }
    	 if (Input.GetKey(KeyCode.DownArrow)){
    	 	 if (UpperArm1.transform.localRotation.x > -.66){
        	 UpperArm1.transform.Rotate(-1.0f, 0.0f, 0.0f, Space.Self);
        	 UpperArm2.transform.Rotate(-1.0f, 0.0f, 0.0f, Space.Self);
        	 UpperArm3.transform.Rotate(-1.0f, 0.0f, 0.0f, Space.Self);
        	 Final1.transform.Rotate(-.5f, 0.0f, 0.0f, Space.Self);
        	 Final2.transform.Rotate(-.5f, 0.0f, 0.0f, Space.Self);
        	 Final3.transform.Rotate(-.5f, 0.0f, 0.0f, Space.Self);
        	 
        	 UpperArm4.transform.Rotate(-1.0f, 0.0f, 0.0f, Space.Self);
        	 UpperArm5.transform.Rotate(-1.0f, 0.0f, 0.0f, Space.Self);
        	 UpperArm6.transform.Rotate(-1.0f, 0.0f, 0.0f, Space.Self);
        	 Final4.transform.Rotate(-.5f, 0.0f, 0.0f, Space.Self);
        	 Final5.transform.Rotate(-.5f, 0.0f, 0.0f, Space.Self);
        	 Final6.transform.Rotate(-.5f, 0.0f, 0.0f, Space.Self);
        	 }
        	 
        	 
         }
        	 

    	  
    	  if (Input.GetKey(KeyCode.X)){
    	 	
        	 Debug.Log(LowerArm1.transform.localRotation.x);
        	 
    	  }
    	  
    	  
    }
}
