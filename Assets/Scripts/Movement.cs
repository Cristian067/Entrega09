using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    [SerializeField] private GameObject camera;
    [SerializeField] private GameObject camera_rot;

    [SerializeField] private float Speed;
    [SerializeField] private float lateralSpeed;

    [SerializeField] private Vector3 offset = new Vector3(0,5,-4);


    private float horizontalInput;
    private float verticalInput;

    private bool isOnGround = false;
    public bool isOnAir = false;

    [SerializeField]private Vector3 checkpoint;
    [SerializeField]private Quaternion checkpoint_rot;

    private GameManager gameManager;








    // Start is called before the first frame update
    void Start()
    {

        gameManager = FindObjectOfType<GameManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //isOnGround = false;

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");




        if (isOnGround)
        {
            Debug.Log("Ground");
            transform.Translate(Vector3.forward * Speed * Time.deltaTime * verticalInput);
        }
        else if (!isOnGround)
        {
            Debug.Log("Null");
            transform.Translate(Vector3.forward * 15 * Time.deltaTime * verticalInput);
            transform.Rotate(new Vector3(40f, 0, 0) * Time.deltaTime);
        }

        if(isOnAir)
        {
            //transform.Rotate(new Vector3(40f, 0, 0)  * Time.deltaTime);
        }


        if(transform.position.y < -25)
        {
            gameManager.Fall();
            transform.rotation = checkpoint_rot;
            transform.position = checkpoint;

        }
        
        gameManager.ShowLifes();


        //transform.Translate(Vector3.right * lateralSpeed * Time.deltaTime * horizontalInput);
        //transform.Rotate(new Vector3(0, 1, 0) * 5);

        //transform.Rotate(new Vector3(0, 1, 0) * horizontalInput * lateralSpeed);
        //camera_rot.transform.Rotate(new Vector3(0, 1, 0) * horizontalInput * lateralSpeed);


        //camera.transform.position = transform.position + offset;
        //camera.transform.position = transform.position + offset;

        //camera.transform.rotation = transform.rotation;



    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "road")
        {
            isOnGround = true;
            isOnAir = false;
            Speed = 20;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "jump")
        {
            StartCoroutine(JumpAir());
            isOnAir = true;
            
        }
        
        
    }

    private IEnumerator JumpAir()
    {
        yield return new WaitForSeconds(0.5f);
        Speed = 20;
        
        isOnGround = false;

    }

    public void SetCheckpoint(Vector3 newCheck, Quaternion newCheck_rot)
    {
        checkpoint = newCheck;
        checkpoint_rot = newCheck_rot;
    }


    public void Stop()
    {
        Speed = 0;
        lateralSpeed = 0;
    }



}
