using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class point_lewater : MonoBehaviour
{
    // Start is called before the first frame update


    private static int score = 0;

    private SphereCollider sphereCollider;
    private AudioSource audioSource;


    public TextMeshProUGUI test_score;

    // public Material material;
    Renderer rn;

    void Start()
    {
        sphereCollider = GetComponent<SphereCollider>();
        audioSource = GetComponent<AudioSource>();
        Debug.Log(score);
        test_score.SetText("Score : " + score.ToString());
        // material = GetComponent<Material>();
        rn = GetComponent<Renderer>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }



    private void OnTriggerEnter(Collider other) {

        Debug.Log(other.name);
        if (other.name == "ballz"){
            score = score + 38;
            Debug.Log(score);
            rn.material.color = Color.red;
            audioSource.Play();
            test_score.SetText("Score : " + score.ToString());
        }
        


    }

    private void OnCollisionEnter(Collision other) {
        if (other.body.name == "ballz"){
            score = score + 29;
            Debug.Log(score);
            rn.material.color = Color.red;
            audioSource.Play();
            test_score.SetText("Score : " + score.ToString());
        }
        

    }

    private void OnCollisionExit(Collision other) {
        rn.material.color = Color.yellow;
    }

    private void OnTriggerExit(Collider other) {
        rn.material.color = Color.yellow;
    }


// nb : iya emang spageti tapi penting jalan dulu (fix dijitak atasan kalo ketahuan)

}
