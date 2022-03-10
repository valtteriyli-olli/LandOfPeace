using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

 {
        // Float on avainsana mik‰ auttaa konetta tiet‰m‰‰n, ett‰ me teemme numeron mink‰ sis‰ll‰ on desimaaleja. Ns. fyysiset luvut
        // esim. 20 ovat scriptiss‰ vaikeita koska niit‰ pit‰‰ j‰lkeenp‰in muuttaa sit‰ mukaan, kun tekee muita muutoksia.
        // = merkill‰ annetaan muuttujalle esim. speed oma value.
        // Aina floatin kautta annetun arvon j‰lkeen per‰‰n f
        // horizontalInput ottaa haltuun Input Managerin horizontal-kohdan
        private float speed = 15.0f;
    private float turnSpeed = 50.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update. / Mit‰ tapahtuu heti alussa ensimm‰isen framen ajan. Ei toista itse‰‰n.
    // When you press play on your game it will use start method

    void Start()
    {

    }

    // Update is called once per frame
    // Update looks for doable actions/calculations during the game / Mit‰ tapahtuu pelin aikana. Toistaa komentoa.
    // Update is called 50-60 times per second.

    void Update()
    {
        // Input.GetAxis("") Avulla saadaan haltuun haluamamme project manager > Input Manager - kohta
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // We'll move the vehicle forward
        // transformilla saadaan haltuun transform-kohta (x,y,z) nykyisest‰ objectista 
        // Jokainen Method (Menetelm‰) alkaa isolla kirjaimella
        // Translatea k‰ytet‰‰n jotta voidaan liikuttaa meid‰n objectia transform-kohdan kautta.
        // () sulkuja k‰ytet‰‰n jotta voidaan ilmoittaa koneelle tekem‰‰n teht‰v‰
        // Sulkujen sis‰ll‰ on parameter (muuttuja). Sen avulla kerrotaan koneelle tieto mit‰ k‰ytt‰‰ jotta se tekee asian mink‰ haluan.
        // ; ilmoittaa scriptille ett‰ method p‰‰ttyy. Ik‰‰n kuin lauseen lopettaa arkikeskustelussa.
        // Update is called 50-60 times per second. So in a second our object will move 60 meters in certain direction (value is 1)
        // transform.Translate(0, 0, 1) = transform.Translate(Vector3.forward);
        // Vector 3 ohjataan 3 pistett‰ (3D)
        // Update is called every single frame joten koneen tehosta riippuen peli saattaa n‰ytt‰‰ muille erilaiselta (20fps, 60fps jne)
        // T‰m‰n takia Time.deltaTime k‰ytet‰‰n. Sen avulla kone tiet‰‰ milloin yksi sekunti on kulunut. 
        // * on kerroin. T‰ss‰ liness‰ * 20 kerrotaan forward komennon (0, 0, 1) x 20. Eli muiden arvo 0 ja Z kulkee 20 metri‰ sekunnissa.

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
       
        // Hyppykomento
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 5, ForceMode.VelocityChange);
        }

    }
}