using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 offset = new Vector3(0, 5, -4);
    [SerializeField] private Vector3 rotat = new Vector3(26.85f, 0.208f, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
        //transform.rotation = player.transform.rotation;
        
    }

    private void LateUpdate()
    {
        
    }
}
