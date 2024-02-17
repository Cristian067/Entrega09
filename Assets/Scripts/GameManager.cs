using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


    private int lives = 3;

    private UiManager uiManager;
    private Movement player;

    [SerializeField] private GameObject Player;


    // Start is called before the first frame update
    void Start()
    {
        uiManager = FindObjectOfType<UiManager>();
        player = FindObjectOfType<Movement>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Fall()
    {
        if (lives < 0) 
        {
            //Destroy(Player);
            player.Stop();
            uiManager.ShowDeathPanel();
            
            

        }
        lives--;
    }

    public int ShowLifes()
    {
        
        return lives;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



}
