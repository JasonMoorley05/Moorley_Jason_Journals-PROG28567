using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class SquareSpawner : MonoBehaviour
{
    
    Vector3 screenPos;
    Vector3 worldPos;

    float size = 1f;

    List<Vector2> positions = new List<Vector2>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            screenPos = Mouse.current.position.ReadValue();
            worldPos = Camera.main.ScreenToWorldPoint(screenPos);
            positions.Add(worldPos);
        }

        for (int i = 0; i < positions.Count; i++)
        {
            Vector2 center = positions[i];

            Vector3 topLeft = new Vector3(center.x - size, center.y + size, 0f);
            Vector3 topRight = new Vector3(center.x + size, center.y + size, 0f);
            Vector3 bottomLeft = new Vector3(center.x - size, center.y - size, 0f);
            Vector3 bottomRight = new Vector3(center.x + size, center.y - size, 0f);

            Debug.DrawLine(topLeft, topRight, Color.white);
            Debug.DrawLine(topRight, bottomRight, Color.white);
            Debug.DrawLine(bottomRight, bottomLeft, Color.white);
            Debug.DrawLine(bottomLeft, topLeft, Color.white);
        }

        Vector2 scrollamount = Mouse.current.scroll.ReadValue();
        float scrollY = scrollamount.y/10;
        size += scrollY;
    }
}
