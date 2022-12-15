using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class bridgeScript : MonoBehaviour
{
    bool hasPressed;
    public GameObject bridgeOne;
    public GameObject bridgeTwo;

    void Update()
    {
        if(Input.GetKeyDown("e"))
        {
            bridgeOne.SetActive(false);
            bridgeTwo.SetActive(true);
        }
    }
}
    
