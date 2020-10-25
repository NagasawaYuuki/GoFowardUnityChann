using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private float speed = -12;
    private float deadLine = -10;
    AudioSource audio;
    
    // Start is called before the first frame update
    void Start()
    {
        this.audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }
     
    void OnCollisionEnter2D(Collision2D other)
    {
            if (other.gameObject.tag == "ground")
            {
                this.audio.Play();
            }
            else if (other.gameObject.tag == "block")
            {
                this.audio.Play();

            }
    }


    
}
