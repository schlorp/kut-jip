using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerprefab;

    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;

    private void Start()
    {
        Vector3 randomPos = new Vector3(Random.Range(minX, maxX), 1.8f, Random.Range(minZ, maxZ));
        PhotonNetwork.Instantiate(playerprefab.name, randomPos, Quaternion.identity);
    }


}
