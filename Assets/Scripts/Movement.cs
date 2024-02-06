using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private GameObject camera;

    [SerializeField] private float Speed;
    [SerializeField] private float lateralSpeed;

    [SerializeField] private Vector3 offset = new Vector3(0,5,-4);


    private float horizontalInput;
    private float verticalInput;








    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");





        transform.Translate(Vector3.forward * Speed * Time.deltaTime * verticalInput);
        //transform.Translate(Vector3.right * lateralSpeed * Time.deltaTime * horizontalInput);
        //transform.Rotate(new Vector3(0, 1, 0) * 5);

        transform.Rotate(new Vector3(0, 1, 0) * horizontalInput * lateralSpeed);


        camera.transform.position = transform.position + offset;

        //camera.transform.rotation = transform.rotation;



    }
}
