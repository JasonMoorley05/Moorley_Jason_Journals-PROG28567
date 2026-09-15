using UnityEngine;

public class RowGeneration : MonoBehaviour
{
    string fieldText;
    bool buttonpress = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int num = int.Parse(fieldText);

        if (buttonpress)
        {
            Debug.Log("Draw squares.");
        }
    }

    public void updateString(string text)
    {
        fieldText = text;
    }

    public void buttonPress()
    {
        buttonpress = true;
    }
}
