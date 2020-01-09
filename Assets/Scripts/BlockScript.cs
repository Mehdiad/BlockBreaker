using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(gameObject.name);
        Destroy(gameObject);
        //Debug.Log(collision.gameObject.name);
    }

}
