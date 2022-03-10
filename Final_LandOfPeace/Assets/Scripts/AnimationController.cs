using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private bool _isWalking = false;
    private bool _isJumping = false;

    private Animator anim;
   

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey("w"))
        {
            if (!_isWalking)
            {
                _isWalking = true;
                anim.Play("Walking");

            }

        }
        else
        {
               if (_isWalking)
               {
                anim.Play("Idle");
               }
            _isWalking = false;
        }

        if (Input.GetKey("space"))
        {
            if (!_isJumping)
            {
                _isJumping = true;
                anim.Play("Jumping");
            }
            else
            {
                if (_isJumping)
                {
                    anim.Play("Idle");
                    _isJumping = false;
                }
            }
        }

    }
}
