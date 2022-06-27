using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class kikakankerkaas : MonoBehaviour
{
    public float speed;
    PhotonView view;

    void Start()
    {
       view = GetComponent<PhotonView>(); 
    }

    void Update()
    {
        if (view.IsMine)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0, 0, speed * Time.deltaTime);
            }
        }
    }
}
