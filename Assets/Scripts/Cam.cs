 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Camera/Simple Smooth Mouse Look ")]
public class Cam : MonoBehaviour
{


    [SerializeField] private float scrollSpead;
    [SerializeField] private float topBarrier;
    [SerializeField] private float botBarrier;
    [SerializeField] private float leftBarrier;
    [SerializeField] private float rightBarrier;

    void Update()
    {
        if (Input.mousePosition.y >= Screen.height*topBarrier)
            transform.Translate(Vector3.forward*Time.deltaTime*scrollSpead, Space.World );
        

        if (Input.mousePosition.y <= Screen.height * botBarrier)
            transform.Translate(Vector3.back * Time.deltaTime * scrollSpead, Space.World);
        

        if (Input.mousePosition.x >= Screen.width * rightBarrier)
            transform.Translate(Vector3.right * Time.deltaTime * scrollSpead, Space.World);
        

        if (Input.mousePosition.x <= Screen.width * leftBarrier ) 
            transform.Translate(Vector3.left * Time.deltaTime * scrollSpead, Space.World);
        

    }

}
