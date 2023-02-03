using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody player;
    void Start()
    {
        player.useGravity= true;
        player.AddForce(200,200,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
