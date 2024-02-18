using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    

    [SerializeField] private float Speed;
    [SerializeField] private float lateralSpeed;

    [SerializeField] private Vector3 offset = new Vector3(0,5,-4);


    private float horizontalInput;
    private float verticalInput;

    private bool isOnGround = false;
    public bool isOnAir = false;
    [SerializeField] private bool isGameOver;

    

    private GameManager gameManager;
    [SerializeField] private Vector3 checkPoint;
    [SerializeField] private Quaternion checkPoint_rot;







    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;

        gameManager = FindObjectOfType<GameManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //isOnGround = false;

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");


        if (!isGameOver)
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime * verticalInput);
            transform.Rotate(new Vector3(0, 1, 0) * horizontalInput * lateralSpeed);


        }


        /*if (isOnGround)
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
        }*/


        if (transform.position.y < -25)
        {
            gameManager.Fall();
            
           //transform.position = checkPoint;
           // transform.rotation = checkPoint_rot;

        }
        
        


        //transform.Translate(Vector3.right * lateralSpeed * Time.deltaTime * horizontalInput);
        //transform.Rotate(new Vector3(0, 1, 0) * 5);

        
        



    }
    /*
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
    */
    /*
    public void GetCheckpoint(Vector3 newCheck, Quaternion newCheck_rot)
    {
        //ebug.Log($"{newCheck},{newCheck_rot}");

        checkPoint = newCheck;
        checkPoint_rot = newCheck_rot;
    }
    */

    public void Stop()
    {
        //Speed = 0;
        isGameOver = true;
        //lateralSpeed = 0;
    }



}
