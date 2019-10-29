using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPoint : MonoBehaviour
{
    public static Vector3 hitPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // void OnCollisionEnter(Collision col)
    // {
    //    foreach (ContactPoint point in collision.contacts)
    //    {
    //        //衝突位置
    //        Debug.Log(point);
    //    }


    //    Collider myCollider = col.contacts[0].thisCollider;
    //     Debug.Log(myCollider.gameObject.name);


    // }

    void OnCollisionStay(Collision collision)
    {
        foreach (ContactPoint point in collision.contacts)
        {
            hitPos = point.point;
            // hitPosの座標を使ってエフェクトなどを生成  

            Debug.Log(hitPos);
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
