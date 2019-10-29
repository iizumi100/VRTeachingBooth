using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionName : MonoBehaviour
{

    public static string collision_name;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        collision_name = collision.gameObject.name;
    }
}
