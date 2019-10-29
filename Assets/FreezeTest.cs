using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Freeze = this.gameObject.transform.position;
        this.gameObject.transform.position = Freeze;
    }
}
