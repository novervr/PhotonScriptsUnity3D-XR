using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

namespace Photon.UnityXRPlayer

public class NetworkPlayerSpawner : MonoBehaviourPunCallbacks
{

    private GameObject spawnedPlayerPrefab;

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        spawnedPlayerPrefab = PhotonNetwork.Instantiate("Network Player", transform.position, transform.rotation);
    }

    // Update is called once per frame
    public override void OnLeftRoom()
    {
        base.OnLeftRoom();
        PhotonNetwork.Destroy(spawnedPlayerPrefab);
    }
}
