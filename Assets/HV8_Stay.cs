using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HV8_Stay : MonoBehaviour
{
    private GameObject _parent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (this.gameObject.transform.parent.name == "jig_actual_HV6")
        //  {
        //    var aaa = GetComponent<Rigidbody>();
        //   aaa.isKinematic = true;
        // }

        _parent = transform.root.gameObject;
        if (_parent.name == "hand_body1")
        {
            var aaa = GetComponent<Rigidbody>();
            aaa.isKinematic = true;

        }
    }

}
