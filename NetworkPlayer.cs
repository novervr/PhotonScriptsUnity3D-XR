using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using Photon.Pun;
using UnityEngine.XR;

public class NetworkPlayer : MonoBehaviour

{

    public Transform head;

    public Transform lefthand;

    public Transform righthand;

    private PhotonView photonView;



    private Transform headRig;

    private Transform leftHandRig;

    private Transform rightHandRig;

    public Transform centereye;



    ///Start is called before the first frame update

    void Start()

    {

        photonView = GetComponent<PhotonView>();

        XRRig rig = FindObjectOfType<XRRig>();

        headRig = rig.transform.Find("GorillaPlayer/Main Camera");

        leftHandRig = rig.transform.Find("GorillaPlayer/LeftHand Controller");

        rightHandRig = rig.transform.Find("GorillaPlayer/RightHand Controller");

    }



    // Update is called once per frame

    void Update()

    {

        if (photonView.IsMine)

        {

            righthand.gameObject.SetActive(false);

            lefthand.gameObject.SetActive(false);

            head.gameObject.SetActive(false);



            MapPosition(head, headRig);

            MapPosition(lefthand, leftHandRig);

            MapPosition(righthand, rightHandRig);

        }

    }



    void MapPosition(Transform target, Transform rigTransform)

    {

        target.position = rigTransform.position;

        target.rotation = rigTransform.rotation;

    }

}
