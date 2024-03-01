using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    // Start is called before the first frame update

    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        JointSpring jointSpring = GetComponent<HingeJoint>().spring;
        if (Input.GetKeyDown(KeyCode.Z)){
            
            jointSpring.spring = 1000;
        }
        else {
            jointSpring.spring = 0;
        }
        GetComponent<HingeJoint>().spring = jointSpring;
    }
}
