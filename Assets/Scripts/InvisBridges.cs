using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisBridges : MonoBehaviour
{
    
    void Start()
    {
        EventBus.Current.BridgeGoOn += TurnBridgeOn;
    }

    void TurnBridgeOn()
    {
        gameObject.GetComponent<BoxCollider>().enabled = true;
        gameObject.GetComponent<MeshRenderer>().enabled = true;
    }

    void OnDestroy()
    {
        EventBus.Current.BridgeGoOn -= TurnBridgeOn;
    }
}
