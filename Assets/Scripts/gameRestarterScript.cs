using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameRestarterScript : MonoBehaviour
{
    bool press;
    void OnTriggerEnter()
    {
        press = true;
    }

    void Update()
    {
        if(Input.GetKeyDown("e") && press)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
