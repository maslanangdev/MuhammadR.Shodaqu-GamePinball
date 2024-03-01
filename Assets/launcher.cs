using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class launcher : MonoBehaviour
{
    // Start is called before the first frame update 
    public Rigidbody ball_here;

    public int launch_spd = -500;

    private Vector3 last_vel;


    private bool ready_to_launch = false;
    private Vector3 launcher_normal;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        last_vel = ball_here.velocity;

        if (Input.GetKeyDown(KeyCode.Space)){

            if (ready_to_launch && last_vel == Vector3.zero){
                // var spd = last_vel.magnitude + 380;
                // var direction = Vector3.Reflect(last_vel.normalized, launcher_normal);
                // ball_here.velocity = direction * Mathf.Max(spd, 0f);
                ball_here.AddForce(0, 0, launch_spd);
                Debug.Log("launch??");
                Debug.Log(last_vel);
                // Debug.Log(direction);
                ready_to_launch = false;
            }
        }

    }

    private void OnCollisionEnter(Collision coll){
       
        ready_to_launch = true;
        launcher_normal =  coll.contacts[0].normal;

        }
}
