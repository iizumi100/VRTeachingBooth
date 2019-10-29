using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeRotationXZ : MonoBehaviour
{
    Rigidbody rbo;
    // Start is called before the first frame update
    void Start()
    {
        rbo = this.gameObject.transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rbo.constraints = RigidbodyConstraints.FreezeAll;
        //rbo.constraints = RigidbodyConstraints.FreezeRotation;
    }
}
