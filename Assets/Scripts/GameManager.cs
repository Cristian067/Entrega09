using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    private int lives = 3;

    private int deathCount = 0;

    private UiManager uiManager;
    private Movement playerS;

    [SerializeField] private GameObject player;

    [SerializeField] private Vector3 checkPoint;
    [SerializeField] private Quaternion checkPoint_rot;


    // Start is called before the first frame update
    void Start()
    {
        uiManager = FindObjectOfType<UiManager>();
        playerS = FindObjectOfType<Movement>();

        checkPoint = new Vector3(0,0,0);
        checkPoint_rot = Quaternion.Euler(0,0,0);


    }

    // Update is called once per frame
    void Update()
    {

    }


    public void Fall()
    {
        Debug.Log(lives);
        if (lives <= 0)
        {
            //Destroy(Player);
            uiManager.ShowDeathPanel();
            //playerS.Stop();
            playerS.Stop();
            



        }
        lives--;
        deathCount++;
        player.transform.position = checkPoint;
        player.transform.rotation = checkPoint_rot;
    }

    public void Win()
    {
        playerS.Stop();
        uiManager.ShowWinPanel();
    }

    public int ShowLifes()
    {

        return lives;
    }
    public int ShowDeathCount()
    {

        return deathCount;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void SetCheckpoint(Vector3 newCheck, Quaternion newCheck_rot)
    {
        //Debug.Log($"{newCheck},{newCheck_rot}");

        checkPoint = newCheck;
        checkPoint_rot = newCheck_rot;

        //player.GetCheckpoint(checkPoint, checkPoint_rot);

    }



}
