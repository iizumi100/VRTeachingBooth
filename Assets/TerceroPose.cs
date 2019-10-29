using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerceroPose : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = GameObject.Find("LeftHandAnchor").transform.position;
        this.gameObject.transform.rotation = GameObject.Find("LeftHandAnchor").transform.rotation;
    }
}
