using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.XR.Interaction.Toolkit;

using Photon.Pun;

using UnityEngine.XR;



public class Networkplayer2 : MonoBehaviour

{

    public Transform head;

    public Transform lefthand;

    public Transform righthand;

    private PhotonView photonView;



    private Transform headRig;

    private Transform leftHandRig;

    private Transform rightHandRig;

    //public Transform centereye;



    ///Start is called before the first frame update

    void Start()

    {

        photonView = GetComponent<PhotonView>();

        XRRig rig = FindObjectOfType<XRRig>();

        headRig = rig.transform.Find("Camera Offset/Main Camera");

        leftHandRig = rig.transform.Find("Camera Offset/LeftHand Controller");

        rightHandRig = rig.transform.Find("Camera Offset/RightHand Controller");

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