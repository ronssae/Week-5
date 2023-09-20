using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week4 : MonoBehaviour
{
    private Animator Player_Anim;
    [Range(0, 15)]
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        Player_Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButtonDown(KeyCode.Space))
        //{
        //    MoveForward();
        //}
    }

    void MoveForward()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        Player_Anim.SetBool("isrunning", true);
    }

    void StopMovement ()
    {
        Speed = 0;
        Player_Anim.SetBool("isrunning", false);
    }

}
