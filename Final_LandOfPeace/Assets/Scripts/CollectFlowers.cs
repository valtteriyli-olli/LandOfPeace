using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class CollectFlowers : MonoBehaviour
{

    

    public AudioSource flower_pickup_sfx;
    public GameObject FlowerParticle;

    public void OnTriggerEnter(Collider other)
    {
        flower_pickup_sfx.Play();

        this.gameObject.SetActive(false);

        Instantiate(FlowerParticle, transform.position, Quaternion.identity);

        ScoreManager.score += 1;



    }

}





