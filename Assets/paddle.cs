using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    // Start is called before the first frame update

    public KeyCode key_trigger;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        JointSpring jointSpring = GetComponent<HingeJoint>().spring;
        if (Input.GetKeyDown(key_trigger)){
            
            jointSpring.spring = 1000;
            Debug.Log("trigger!");
        }
        else {
            jointSpring.spring = 0;
        }
        GetComponent<HingeJoint>().spring = jointSpring;
    }
}
