using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{

    public Animator PlayerAnim;


    // Start is called before the first frame update
    void Start()
    {
        PlayerAnim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
