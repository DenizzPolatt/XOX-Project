using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{

    [SerializeField] private bool xTurn;
    [SerializeField] private GameObject[] x;
    [SerializeField] private GameObject[] o;


    [SerializeField] private TextMeshProUGUI xWonText;
    [SerializeField] private TextMeshProUGUI oWonText;
    [SerializeField] private Button restartButton;
    
    // Start is called before the first frame update
    void Start()
    {
        xTurn = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void ManageTurns(int i)
    {
        if (xTurn)
        {
            x[i].gameObject.SetActive(true);
            o[i].gameObject.SetActive(false);
            xTurn = false;
        }
        else
        {
            x[i].SetActive(false);
            o[i].SetActive(true);
            xTurn = true;
        }
        
        WinningCheck();
    }

    private void WinningCheck()
    {
        if (x[0].gameObject.activeSelf && x[1].gameObject.activeSelf && x[2].gameObject.activeSelf)
        {
            XWon();
        }
        else if (x[0].gameObject.activeSelf && x[3].gameObject.activeSelf && x[6].gameObject.activeSelf)
        {
            XWon();
        }
        else if (x[3].gameObject.activeSelf && x[4].gameObject.activeSelf && x[5].gameObject.activeSelf)
        {
            XWon();
        }
        else if (x[6].gameObject.activeSelf && x[7].gameObject.activeSelf && x[8].gameObject.activeSelf)
        {
            XWon();
        }
        else if (x[1].gameObject.activeSelf && x[4].gameObject.activeSelf && x[7].gameObject.activeSelf)
        {
            XWon();
        }
        else if (x[2].gameObject.activeSelf && x[5].gameObject.activeSelf && x[8].gameObject.activeSelf)
        {
            XWon();
        }
        else if (x[0].gameObject.activeSelf && x[4].gameObject.activeSelf && x[8].gameObject.activeSelf)
        {
            XWon();
        }
        else if (x[2].gameObject.activeSelf && x[4].gameObject.activeSelf && x[6].gameObject.activeSelf)
        {
            XWon();
        }
        
        /////
        if (o[0].gameObject.activeSelf && o[1].gameObject.activeSelf && o[2].gameObject.activeSelf)
        {
            OWon();
        }
        else if (o[0].gameObject.activeSelf && o[3].gameObject.activeSelf && o[6].gameObject.activeSelf)
        {
            OWon();
        }
        else if (o[3].gameObject.activeSelf && o[4].gameObject.activeSelf && o[5].gameObject.activeSelf)
        {
            OWon();
        }
        else if (o[6].gameObject.activeSelf && o[7].gameObject.activeSelf && o[8].gameObject.activeSelf)
        {
            OWon();
        }
        else if (o[1].gameObject.activeSelf && o[4].gameObject.activeSelf && o[7].gameObject.activeSelf)
        {
            OWon();
        }
        else if (o[2].gameObject.activeSelf && o[5].gameObject.activeSelf && o[8].gameObject.activeSelf)
        {
            OWon();
        }
        else if (o[0].gameObject.activeSelf && o[4].gameObject.activeSelf && o[8].gameObject.activeSelf)
        {
            OWon();
        }
        else if (o[2].gameObject.activeSelf && o[4].gameObject.activeSelf && o[6].gameObject.activeSelf)
        {
            OWon();
        }
    }

    private void XWon()
    {
        xWonText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }
    
    private void OWon()
    {
        oWonText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

}
