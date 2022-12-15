using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExlamationScript : MonoBehaviour
{
    bool canClick;
    void OnTriggerEnter()
    {
        canClick = true;
    }
    
    void OnTriggerExit()
    {
        canClick = false;
    }

    void Update()
    {
        if(canClick && Input.GetKeyDown("e"))
        {
            EventBus.Current.BridgeGoOnTrigger();
        }
    }
}
