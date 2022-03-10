using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 10, -3);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    // Huomaa ett‰ void Update vaihdettu void Lateupdateen. T‰m‰n avulla tasapainotetaan kamera. 
    // LateUpdaten avulla kamera liikkuu vasta sen j‰lkeen kun tankki liikkuu.
    void LateUpdate()
    {
        // Asetetaan kamera seuraamaan pelaajan liikkumista eli transform.position = player (tankki asetetaan unityss‰ kameraan).transform.position
        // plussalla lis‰t‰‰n ja uudella vectorilla muutetaan kameran sijaintia suhteessa pelaajaan.

        transform.position = player.transform.position + offset;
    }
}
