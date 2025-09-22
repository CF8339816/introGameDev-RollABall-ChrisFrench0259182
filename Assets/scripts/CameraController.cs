using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;   // Reference to MrBall GameObject

    private Vector3 offset;  // Distance offset camera to player

    void Start() // called before first frame
    {

        offset = transform.position - player.transform.position; // Calculate initial offset between cameraand player


        void LateUpdate()   // LateUpdate called once/frame after Update functions completed
        {

            transform.position = player.transform.position + offset; //maintains offset
        }
    }
}