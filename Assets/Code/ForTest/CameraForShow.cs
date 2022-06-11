using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraForShow : MonoBehaviour
{

    [SerializeField] private GameObject center;

    [SerializeField] private float radius = 2f;
    [SerializeField]  float angularSpeed = 2f;

    [SerializeField] private float positionY=4;
    private float positionX;
    private float positionZ;
    [SerializeField] private float angle = 0f;



    void Update()
    {
        transform.LookAt(center.transform);
        positionX = center.transform.position.x+ Mathf.Cos(angle)*radius;
        positionZ = center.transform.position.z+ Mathf.Sin(angle)*radius;
        transform.position = new Vector3(positionX, positionY, positionZ);
      
        angle = angle + Time.fixedDeltaTime * angularSpeed;
        if (angle*45 >= 360) 
            Destroy(this);
        
    }

 

    
}
