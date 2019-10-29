using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetLocalPosition : MonoBehaviour
{
    public static Vector3 localpos;
    public static Quaternion localrot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        localpos = this.gameObject.transform.localPosition;
        localrot = this.gameObject.transform.localRotation;
       
        
    }
}
