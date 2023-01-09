using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public Material material1;
    public Material material2;
    public SpriteRenderer _renderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
