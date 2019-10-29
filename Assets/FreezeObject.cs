using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeObject : MonoBehaviour
{
    private Vector3 HV8pos;
    private Quaternion HV8rot;
    int e;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (e == 0)
        {
            HV8pos = this.gameObject.transform.position;
            HV8rot = this.gameObject.transform.rotation;
            this.gameObject.transform.position = HV8pos;
            this.gameObject.transform.rotation = HV8rot;
        }
    }
}
