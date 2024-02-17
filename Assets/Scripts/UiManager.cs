using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiManager : MonoBehaviour
{
    [SerializeField] private GameObject deathPanel;
    [SerializeField] private GameObject winPanel;








    // Start is called before the first frame update
    void Start()
    {

        deathPanel.SetActive(false);
        winPanel.SetActive(false);


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowWinPanel()
    {
        winPanel.SetActive(true);
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
