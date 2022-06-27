using UnityEngine;
using System.Collections;
using System.Collections.Generic;


namespace transforming
{
   public class cameracontrol : MonoBehaviour {
 
    
    void Update() {
        Transform myTransform = this.transform;
        Vector3 pos = myTransform.position;
        var rcameralim=-822.1;
        var lcameralim=1800;

        if(Input.GetMouseButton(0)){
           float mouse_x_delta =Input.GetAxis("Mouse X");
           float mouse_y_delta =Input.GetAxis("Mouse Y");

           pos.x-=mouse_x_delta*100;
    
        }
        if(pos.x>rcameralim){
            if (pos.x<lcameralim){
                myTransform.position = pos; 
            }

        }
       
    }
}
}