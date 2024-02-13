using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{

    private Movement player;

    // Start is called before the first frame update
    void Start()
    {

        player = FindObjectOfType<Movement>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        player.SetCheckpoint(gameObject.transform.position, gameObject.transform.rotation);
        
    }


}
