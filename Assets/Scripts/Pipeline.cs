using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Pipeline : MonoBehaviour
{
    float time = 0f;
    bool mouse = false;
    Vector3 screenPos;
    Vector3 worldPos;
    float magnitude = 0f;
    List<Vector2> positions = new List<Vector2>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.isPressed)
        {
            mouse = true;
            time += Time.deltaTime;
            if (time >= 0.1)
            {
                time = 0f;
                screenPos = Mouse.current.position.ReadValue();
                worldPos = Camera.main.ScreenToWorldPoint(screenPos);
                positions.Add(worldPos);
            }
        }

        if(!Mouse.current.rightButton.isPressed && mouse == true)
        {
            for(int i = 0; i < positions.Count - 1; i++)
            {
                Vector2 start = positions[i];
                Vector2 end = positions[i + 1];
                Vector2 result = start - end;

                magnitude += result.magnitude;
            }
        }
        
    }
}
