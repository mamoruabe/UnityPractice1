﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){

if (Input.GetKey(KeyCode.LeftArrow)) {

            //if(transform.position<-4.2f){
            	//transform.position = transform.forward * 4.2f;
            //}
            //else{
            	transform.position += transform.forward * 0.02f;
            //}

}

else if (Input.GetKey(KeyCode.RightArrow)) {
            //if(transform.position>4.2f){
            	//transform.position = transform.forward * 4.2f;
            //}
            //else{
            	transform.position -= transform.forward * 0.02f;
            //}

        }
        
    
//else {
//	GameObject.Find("master").GetComponent<GameMaster>().GameOver("");
//}
}
}
