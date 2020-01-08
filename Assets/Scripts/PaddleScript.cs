using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{

    [SerializeField]
    float screenWidth = 16f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePosX = (Input.mousePosition.x / Screen.width * screenWidth);
        Vector2 paddlePos = new Vector2(mousePosX, transform.position.y);
        transform.position = paddlePos;
    }
}
