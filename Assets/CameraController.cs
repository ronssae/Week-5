using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Player;
    public float SmoothSpeed;
    public Vector3 Offset;

    // Start is called before the first frame update
    void Start()
    {
        Player = PlayerManager.Instance.player.transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 DesiredPosition = Player.position + Offset;
        Vector3 SmoothPosition = Vector3.Lerp(transform.position, DesiredPosition, SmoothSpeed * Time.deltaTime);
        transform.position = SmoothPosition;
    }
}
