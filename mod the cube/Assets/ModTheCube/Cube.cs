using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
   
    }
    
    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);

        Material material = Renderer.material;
        for (int b = 0; b <= 255; b++)
        {
            for (int g = 0; g <= 255; g++)
            {
                for (int r = 0; r <= 255; r++)
                {
                    material.color = new Color(r / 255, g / 255, b / 255);
                }
            }
        }
    }
}
