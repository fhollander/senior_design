using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotControl : MonoBehaviour

{

	
	public GameObject LowerPlatformBase;
	public GameObject temp;
	
	public GameObject LowerArm1;
	public GameObject LowerArm2;
	public GameObject LowerArm3;
	
	
	public GameObject LowerGear1;
	public GameObject LowerGear2;
	public GameObject LowerGear3;
	
	public GameObject UpperArm1;
	public GameObject UpperArm2;
	public GameObject UpperArm3;
	
	public GameObject Final1;
	public GameObject Final2;
	public GameObject Final3;
	
	public GameObject Thumb_lower;
	public GameObject Thumb_upper;
	
	public GameObject item;
	
	bool switch1 = false;


	
    // Start is called before the first frame update
    void Start()
    {
       
    }
    
    
    // Update is called once per frame
    void Update()
    {
       	if (Input.GetKey(KeyCode.A)){
        	LowerPlatformBase.transform.Rotate(0.0f, 1.0f, 0.0f, Space.Self);
            if (switch1 == true)
            {
               //// item.transform.parent = LowerPlatformBase.transform;
               // item.transform.position = LowerPlatformBase.transform.position;
               // item.transform.rotation = UpperArm2.transform.rotation;
            }

        }
         if (Input.GetKey(KeyCode.D)){
        	LowerPlatformBase.transform.Rotate(0.0f, -1.0f, 0.0f, Space.Self);
            if (switch1 == true)
            {
              ///  item.transform.parent = LowerPlatformBase.transform;
               // item.transform.position = LowerPlatformBase.transform.position;
              //  item.transform.rotation = UpperArm2.transform.rotation;
            }

        }
         if (Input.GetKey(KeyCode.W)){
          if (LowerArm1.transform.localRotation.x < .453){
         	LowerArm1.transform.Rotate(1.0f, 0.0f, 0.0f, Space.Self);
         	LowerArm2.transform.Rotate(1.0f, 0.0f, 0.0f, Space.Self);
         	LowerArm3.transform.Rotate(1.0f, 0.0f, 0.0f, Space.Self);
         	LowerGear1.transform.Rotate(-.5f, 0.0f, 0.0f, Space.Self);
         	LowerGear2.transform.Rotate(-.5f, 0.0f, 0.0f, Space.Self);
         	LowerGear3.transform.Rotate(-.5f, 0.0f, 0.0f, Space.Self);
         	}
         }
         if (Input.GetKey(KeyCode.S)){
         	if (LowerArm1.transform.localRotation.x > -.176){
         	LowerArm1.transform.Rotate(-1.0f, 0.0f, 0.0f, Space.Self);
         	LowerArm2.transform.Rotate(-1.0f, 0.0f, 0.0f, Space.Self);
         	LowerArm3.transform.Rotate(-1.0f, 0.0f, 0.0f, Space.Self);
         	LowerGear1.transform.Rotate(.5f, 0.0f, 0.0f, Space.Self);
         	LowerGear2.transform.Rotate(.5f, 0.0f, 0.0f, Space.Self);
         	LowerGear3.transform.Rotate(.5f, 0.0f, 0.0f, Space.Self);
         	
         	
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
        		
        		
        		
        		
        		//item.GetComponent<Rigidbody>().useGravity = false;
      			//item.GetComponent<Rigidbody>().isKinematic = true;
     		   // item.transform.position = Final2.transform.position;
   	 		  //  item.transform.rotation = Final2.transform.rotation;
   	 		  
   	 			if(switch1 == true){
   	 		   		item.transform.parent=Final1.transform;
   	 			}
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
        	
        	        		
        		
        		//item.GetComponent<Rigidbody>().useGravity = false;
      			//item.GetComponent<Rigidbody>().isKinematic = true;
     		    //item.transform.position = Final2.transform.position;
   	 		  //  item.transform.rotation = Final2.transform.rotation;
   	 		  
   	 		if(switch1 == true){
   	 		   	item.transform.parent=Final1.transform;
   	 		} 
         }	 
      }
        	 
        if (Input.GetKey(KeyCode.LeftArrow)){
    	 	 if (Thumb_lower.transform.localRotation.y < .96){
        	 Thumb_lower.transform.Rotate(1.0f, 0.0f, 0.0f, Space.Self);
        	 Thumb_upper.transform.Rotate(.50f, 0.0f, 0.0f, Space.Self);
        	}	 
        	 
    	  }
    	if (Input.GetKey(KeyCode.RightArrow)){
    	 	if (Thumb_lower.transform.localRotation.y > .76){
        	Thumb_lower.transform.Rotate(-1.0f, 0.0f, 0.0f, Space.Self);
        	Thumb_upper.transform.Rotate(-.50f, 0.0f, 0.0f, Space.Self);
        	 }	 
        	 
    	  }
    	  
    	  if (Input.GetKey(KeyCode.X)){
        	 Debug.Log(LowerArm1.transform.localRotation.x);
            if (switch1 == false)
            {
                switch1 = true;
                item.transform.parent = LowerPlatformBase.transform;
            }
            else
            {
                switch1 = false;
                item.transform.parent = null;
            }
        	 
    	  }
    	  
    	  
    	
    	  
    }
    
    void OnButton () {
    
    	item.GetComponent<Rigidbody>().useGravity = false;
        item.GetComponent<Rigidbody>().isKinematic = true;
        item.transform.position = LowerPlatformBase.transform.position;
   	    item.transform.rotation = LowerPlatformBase.transform.rotation;
    
    
    }
}
