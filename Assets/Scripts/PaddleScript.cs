using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{


    [SerializeField]
    float screenWidth = 16f;

    [SerializeField]
    float minX = 1f;

    [SerializeField]
    float maxX = 15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePosX = (Input.mousePosition.x / Screen.width * screenWidth);
        Vector2 paddlePos = new Vector2(mousePosX, transform.position.y);

        //lock the paddles min and max X-value
        paddlePos.x = Mathf.Clamp(mousePosX, minX, maxX);

        transform.position = paddlePos;
    }
}
