using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    // Start is called before the first frame update


    public Rigidbody ball_here;

    private Vector3 last_vel;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        last_vel = ball_here.velocity;
    }

    private void OnCollisionEnter(Collision coll){
        var spd = last_vel.magnitude;
        var direction = Vector3.Reflect(last_vel.normalized, coll.contacts[0].normal);

        ball_here.velocity = direction * Mathf.Max(spd, 0f);
    }
}
