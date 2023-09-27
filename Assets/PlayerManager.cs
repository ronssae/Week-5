using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance { get; private set; }
    //Player Game Object
    public GameObject player;
    public Rigidbody RigidBody;
    //PlayerScripts
    public InputManager inputManager;
    PlayerLocomotion locomotionPlayer;
    //Player Stats
    public float MovementSpeed;
    [Range(0, 100)]
    public float RotationSpeed;

    // Start is called before the first frame update
    private void Awake()
    {
        //If there is an instance, and it's not me, delete myself
        if (Instance != null && Instance != this){ Destroy(this);}
        else{Instance = this;}
        inputManager = player.GetComponent<InputManager>();
        locomotionPlayer = player.GetComponent<PlayerLocomotion>();
        RigidBody = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        inputManager.HandleAllInput();
    }

    private void FixedUpdate()
    {
        locomotionPlayer.HandleAllMovement();
    }
}
