using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemScript : MonoBehaviour
{
   // public GameObject Cloud;

    // Use this for initialization
    void Start()
    {
        //  audio = GameObject.Find("gem").GetComponent<AudioSource>();

        if (Door.instance != null)
        {
            Door.instance.collectiblesCount++;
        }
    }

    private void OnTriggerEnter2D(Collider2D target)
    {


       

        if (target.tag == "Player")
        {
           // Instantiate(Cloud, transform.position, Cloud.transform.rotation);

            Destroy(gameObject);

            if (Door.instance != null)
            {
                Door.instance.DecrementCollectables();
            }
        }
    }

}
