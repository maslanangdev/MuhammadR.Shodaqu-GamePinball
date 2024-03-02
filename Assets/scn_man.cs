using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scn_man : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void change_to_play(){
        SceneManager.LoadScene(2);
    }

    public void change_to_kredits(){
        SceneManager.LoadScene(3);
    }

    public void change_to_menu(){
        SceneManager.LoadScene(0);
    }
    public void change_to_test(){
        SceneManager.LoadScene(1);
    }

    public void change_to_kuit(){
        Application.Quit();
    }
}

