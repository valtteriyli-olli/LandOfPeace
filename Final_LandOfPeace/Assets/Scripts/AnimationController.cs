using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private bool _isWalking = false;
    private bool _isJumping = false;
    private bool _isPicking = false;

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
                anim.Play("JumpingCool");
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

        if (Input.GetKey("f"))
        {
            if (!_isPicking)
            {
                _isPicking = true;
                anim.Play("Picking up");
               
            }
            else
            {
                if (_isPicking)
                {
                    anim.Play("Idle");
                    _isPicking = false;
                }
            }


        }

    }
    
}
