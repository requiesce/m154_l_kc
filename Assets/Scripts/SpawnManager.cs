using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SpawnManager : NetworkBehaviour
{
    public GameObject[] lilyPadObjs = null;

    // Start is called before the first frame update
    public override void OnStartServer()
    {
        InvokeRepeating("SpawnLilyPad", 2f, 5f);
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }


    void SpawnLilyPad()
    {
        foreach (GameObject lilyPad in lilyPadObjs)
        {
            GameObject tempLilypad = Instantiate(lilyPad);
            NetworkServer.Spawn(tempLilypad);
        }
    }
}
