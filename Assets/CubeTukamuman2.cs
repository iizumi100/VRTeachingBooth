using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTukamuman2 : MonoBehaviour
{

    public static Vector3 TerceroLocalPos;
    public static Quaternion TerceroLocalRot;
    //Rigidbody rbo;
    //Collider m_object, finger;
    int c = 0;
    private Vector3 phantom;
    public static int grabpreparation;
    public int aa;
    float rotY,rotY2;
    //public static Transform invisibletr;
    

    void Start()
    {

        GameObject Finger = GameObject.Find("Finger_F1");

    }

 
    void Update()
    {
        if (OVRInput.Get(OVRInput.RawButton.X) == false)
        {
     
            this.gameObject.transform.parent = null;
            grabpreparation = 0;
            c = 0;
            aa = 0;

            //InvisibleObjectとの親子関係を解除
            int ObjCount = this.transform.childCount;
            if (ObjCount == 1)
            {
                GameObject ChildGameObject1 = transform.GetChild(0).gameObject;
                ChildGameObject1.transform.parent = null;
            }
            print("X解除");

        }

        if (OVRInput.Get(OVRInput.RawButton.X))
        {

            if(c == 0)
            {
                // 回転の中心を衝突点の中心に持っていく
                Vector3 hitpos3 = (CollisionPoint.hitPos + CollisionPoint2.hitPos2) / 2;
                this.gameObject.transform.position = hitpos3;
                //if (CubeTukamuman3.start == 1)
                //{
                    this.gameObject.transform.parent = GameObject.Find("LeftHandAnchor").transform;
               // }
                c = 1;
            }
            
            
            //float posY = this.gameObject.transform.position.y;
            //this.gameObject.transform.position = new Vector3(hitpos3.x, hitpos3.y, hitpos3.z);

            grabpreparation = 1;

            

            if (CubeTukamuman3.grabpreparation2 == 2)
            {
                if (aa == 0)
                {
                    float rotY = this.gameObject.transform.rotation.eulerAngles.y;
                    
                    aa = 1;
                }
                float rotY2 = LeftHandPose.lefthandq.eulerAngles.y;
                //float rotS = GameObject.Find("LeftHandAnchor").transform.rotation.eulerAngles.y;
                //float rotY2 = LeftHandPose.lefthandq.eulerAngles.y;
                this.gameObject.transform.localRotation = Quaternion.Euler(-90, rotY - rotY2, 0);
                //this.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 0);
                grabpreparation = 3;
                print("ワシじゃよ2改23");
                c = 4;
                

            }

           
        }

    }

    private void OnCollisionStay(Collision collision)
    {
        
    }


}
