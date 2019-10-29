using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class finger_move : MonoBehaviour
{
    private void Start()
    {
        
    }

    void Update()
    {

        float lTrigger1 = OVRInput.Get(OVRInput.RawAxis1D.LIndexTrigger);


        // Vector2 stickL = OVRInput.Get(OVRInput.RawAxis2D.LThumbstick);

        // if (Input.GetKey(KeyCode.Space))

        // transformを取得
        // Transform myTransform = this.transform;
        // 現在の座標からのxyz を1ずつ加算して移動
        //  myTransform.Translate(0.0f, 0.02f, 0.0f);
        if (OVRInput.Get(OVRInput.RawButton.Y))
            {
            // Transform myTransform = this.transform;
            //  myTransform.Translate(0.0f, 0.02f, 0.0f);

            //transform.localPosition = new Vector3(0.0f, 0.0f, (-0.06f*lTrigger1));
            transform.localPosition = new Vector3(0.0f, 0.0f, (-0.06f * lTrigger1)+0.06f);
            Debug.Log("Yボタンを押した");
            } else
            {
            transform.localPosition = new Vector3(0.0f, 0.0f, 0.06f);
            }
        
    }

    
}