using Unity.VisualScripting;
using UnityEngine;

public class DepthZone : MonoBehaviour
{
    public Canvas winCanvas;
    public Canvas losingCanvas;
    public bool isMatched; //Defines 
    public bool isItInside;

    void Start()
    {
        isMatched = false;
        Time.timeScale = 1;
        winCanvas.enabled = false;
        losingCanvas.enabled = false;
        isItInside = false;
    }

    void Update()
    {
        if (isItInside && !isMatched && Input.GetKeyDown(KeyCode.Space))
        {
            winCanvas.enabled = true;
            isMatched = true;
            Time.timeScale = 0;
        }
        else if (!isItInside && !isMatched && Input.GetKeyDown(KeyCode.Space))
        {
            losingCanvas.enabled = true;
            isMatched = false;
            Time.timeScale = 0;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Object"))
            {
                isItInside = true;
            }
        }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Object"))
        {
            isItInside = false;
        }
    }
}

