using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    [SerializeField]
    AudioClip destroySound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(gameObject.name);
        Destroy(gameObject);
        AudioSource.PlayClipAtPoint(destroySound, Camera.main.transform.position);
        //Debug.Log(collision.gameObject.name);
    }

}
