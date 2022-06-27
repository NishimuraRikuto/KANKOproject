using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using getGPS;
using kankotransform;

public class myposition : MonoBehaviour
{
    public GPS GPS;
    public Transform myTransform1;
    public Vector3 worldPos;
    
    void Start(){
        Transform myTransform1 =this.transform;
    }

    void Update(){
        
        float a = 35.47476F;
        float b = 135.38605F;
        worldPos = myTransform1.position;
        worldPos.x=GPS.latitude-a;
        worldPos.y=GPS.longitude-b;
        myTransform1.position=worldPos;
    }
}