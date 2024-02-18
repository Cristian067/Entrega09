using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiManager : MonoBehaviour
{
    [SerializeField] private GameObject deathPanel;
    [SerializeField] private GameObject winPanel;

    [SerializeField] private TextMeshProUGUI livesText;
    [SerializeField] private TextMeshProUGUI deathCountText;

    private GameManager gameManager;








    // Start is called before the first frame update
    void Start()
    {

        deathPanel.SetActive(false);
        winPanel.SetActive(false);
        gameManager = FindObjectOfType<GameManager>();


        
    }

    // Update is called once per frame
    void Update()
    {

        //livesText.text = $"{gameManager.ShowLifes()}";
        livesText.text = $"{gameManager.ShowLifes()}";

        
    }

    public void ShowWinPanel()
    {
        winPanel.SetActive(true);
        deathCountText.text = $"Deaths: {gameManager.ShowDeathCount()}";
    }
    public void HideWinPanel()
    {
        winPanel.SetActive(false);
    }
    public void ShowDeathPanel()
    {
        deathPanel.SetActive(true) ;
    }
    public void HideDeathPanel()
    {
        deathPanel.SetActive(false) ;
    }





}
