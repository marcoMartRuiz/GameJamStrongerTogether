using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class FlyingMotion : MonoBehaviour
{   
    Transform birdTransform;
    Rigidbody birdRigBod;
    Vector3 flightVelocity;
    float flightHeight;
    private void Start() 
    {
        birdRigBod = GetComponent<Rigidbody>();  
        birdTransform = GetComponent<Transform>();
    }
    private void Update() 
    {
        FlightPatten();
        
    }

    public void FlightPatten()
    {
        for (float i = 0; i < 100; i++)
        {
           for (float j = 0; j < 100; j++)
           {
            flightHeight = noise.cnoise(new float2(j ,i));
            flightVelocity = new Vector3(noise.cnoise(new float2(j,i)),0,noise.cnoise(new float2(j,i))); 
        birdRigBod.velocity = flightVelocity;
        birdTransform.position = new Vector3(0,flightHeight,0);
           }
        }
    }
}
