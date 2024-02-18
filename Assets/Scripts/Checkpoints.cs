using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{

    private Movement player;
    private GameManager gameManager;

    

    [SerializeField] private bool goal;

    // Start is called before the first frame update
    void Start()
    {

        player = FindObjectOfType<Movement>();
        gameManager = FindObjectOfType<GameManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("a");

        if(other.gameObject.tag == "Player")
        {
            gameManager.SetCheckpoint(gameObject.transform.position, gameObject.transform.rotation);
        }
        


        

        if (goal)
        {
            gameManager.Win();
        }

    }


}
