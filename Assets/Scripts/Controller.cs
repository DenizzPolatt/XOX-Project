using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    [SerializeField] private bool xTurn;
    
    [SerializeField] private GameObject[] x;
    [SerializeField] private GameObject[] o;


    private Tile tile;
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
    }

    private void Winning()
    {
        if (x[0].gameObject.activeSelf && x[1].gameObject.activeSelf && x[2].gameObject.activeSelf)
        {
            Debug.Log("X wins");
        }
    }
    
    
}
