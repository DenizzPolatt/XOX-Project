using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public Material material1;
    public Material material2;
    public SpriteRenderer _renderer;
    

    private Vector3[] positions =
        {new Vector3(0, 0),
        new Vector3(1, 0),
        new Vector3(2, 0),
        new Vector3(0, 1),
        new Vector3(1, 1),
        new Vector3(2, 1),
        new Vector3(0, 2),
        new Vector3(1, 2),
        new Vector3(2, 2)};

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    private void OnMouseDown()
    {
        var tile = _renderer.GetComponent<Tile>();
        var controller = GameObject.Find("GameController").GetComponent<Controller>();

        for (int i = 0; i < 9; ++i)
        {
            if (tile.transform.position.x == positions[i].x && 
                tile.transform.position.y == positions[i].y)
            {
                controller.ManageTurns(i);
            }
        }
    }
    
    public void SetColor(bool changeColor)
    {
        if (changeColor) _renderer.material = material1;
        else
        {
            _renderer.material = material2;
        }
    }
}
