using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTukamuman : MonoBehaviour
{
    // private GameObject _parent;

    public static Vector3 TerceroLocalPos;
    public static Quaternion TerceroLocalRot;
    int freeze;
    Rigidbody rbo;
    Collider m_object,finger;
    int c;
    private Vector3 phantom;

    // Start is called before the first frame update
    void Start()
    {

        rbo = this.transform.GetComponent<Rigidbody>();
        m_object = GetComponent<Collider>();
        GameObject Finger = GameObject.Find("Finger_F1");
        //finger = Finger.transform.GetComponent<Collider>();


    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.RawButton.X) == false)
        {
           // _parent = transform.root.gameObject;
            //if (_parent.name == "hand_body1") {
           //if (this.gameObject.transform.parent.tag == "robothand")
           // {
                this.gameObject.transform.parent = null;
            //}
           // }
            var rb = GetComponent<Rigidbody>();
            rb.isKinematic = false;
            print("離したはず");
            freeze = 0;
            m_object.isTrigger = false;
            //finger.isTrigger = false;
            c = 0;
        }

        /*if(freeze == 0)
        {

            rbo.constraints = RigidbodyConstraints.FreezeRotation;
            rbo.constraints = RigidbodyConstraints.FreezePosition;
            
        }*/
    }

    /*private void OnCollisionEnter(Collision collision)
    {
        phantom = GameObject.Find("HV8SPhantom").transform.position;
    }*/

    void OnCollisionStay(Collision col)
    {

        if (col.gameObject.tag == "Finger" && OVRInput.Get(OVRInput.RawButton.X) && this.gameObject.name != "HV_assembled" )
        {

            /*float rot1 = GameObject.Find("LeftHandAnchor").transform.rotation.eulerAngles.x - this.gameObject.transform.rotation.eulerAngles.x;
            float rot2 = GameObject.Find("LeftHandAnchor").transform.rotation.eulerAngles.z - this.gameObject.transform.rotation.eulerAngles.z;
            Vector3 centerpoint = (CollisionPoint.hitPos + CollisionPoint2.hitPos2) / 2;
            transform.RotateAround(centerpoint, Vector3.right, rot1-90f);
            transform.RotateAround(centerpoint, Vector3.forward, rot2+90f);*/
            m_object.isTrigger = true;
            print(col.gameObject.name + "これ");
            //this.gameObject.transform.parent = col.gameObject.transform;

            // 回転の中心を衝突点の中心に持っていく
            Vector3 hitpos3 = (CollisionPoint.hitPos + CollisionPoint2.hitPos2) / 2;
            rbo = GetComponent<Rigidbody>();
            rbo.centerOfMass = hitpos3;


            this.gameObject.transform.parent = GameObject.Find("LeftHandAnchor").transform;
            float rotY = this.gameObject.transform.rotation.eulerAngles.y;
            float rotS = GameObject.Find("LeftHandAnchor").transform.rotation.eulerAngles.y;
            //float posY = this.gameObject.transform.position.y;
            //this.gameObject.transform.position = new Vector3(hitpos3.x, hitpos3.y, hitpos3.z);
            this.gameObject.transform.localRotation = Quaternion.Euler(-90, rotY, 0);
            //this.gameObject.transform.localPosition = new Vector3(0, 0, 0);


            if (c == 0)
            {
               
                c = 1;

            }


            //Rigidbodyを取得
            var rb = GetComponent<Rigidbody>();

            //isKinematicをオンにする
            rb.isKinematic = true;
            print("掴んだ");


            //GameObject.Find("TerceroPhantom").transform.position = GameObject.Find("LeftHandAnchor").transform.position;
            //GameObject.Find("TerceroPhantom").transform.rotation = GameObject.Find("LeftHandAnchor").transform.rotation;
            GameObject.Find("TerceroPhantom").transform.parent = this.gameObject.transform;
            TerceroLocalPos = GameObject.Find("TerceroPhantom").transform.localPosition;
            TerceroLocalRot = GameObject.Find("TerceroPhantom").transform.localRotation;
            print(TerceroLocalPos);
            print(TerceroLocalRot);
            freeze = 1;
            //finger.isTrigger = true;

        }

       

    }

    //void OnCollisionExit(Collision co)
   // {
      //  if (OVRInput.Get(OVRInput.RawButton.Y) == false)
      //  {

         //   this.transform.parent = null;
         //   var rb = GetComponent<Rigidbody>();
      //      rb.isKinematic = false;
      //      print("離した");
    //    }
   // }

}
