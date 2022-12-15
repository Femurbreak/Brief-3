using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class uiScript : MonoBehaviour
{
    //Shows the text UI for each tutorial
    public TextMeshProUGUI tutorialOneText;
    
    public string tutorialOne;


    void Update()
    {
        
    } 

    void OnTriggerEnter()
    {
        tutorialOneText.text = tutorialOne;
    }
    
    void OnTriggerExit()
    {
        tutorialOneText.text = "";
    }
}
