using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportObject : MonoBehaviour
{

    //public string col_name;
    public int Blue;
    // Start is called before the first frame update
    void Start()
    {
        //print(GameObject.Find("jig_HV6").name);
        //Vector3 tmpi_p = GameObject.Find("jig_HV6").transform.position;
        //Quaternion tmpi_r = GameObject.Find("jig_HV6").transform.rotation;

        //print(tmpi_p);
        //print(tmpi_r);
    }

    private void OnTriggerEnter(Collider other)
    {
        //座標と角度を取得
        //Vector3 tmp_p = GameObject.Find("jig_actual_HV6").transform.position;
        // Quaternion tmp_r = GameObject.Find("jig_actual_HV6").transform.rotation;
        //クォータニオンをオイラー角に変換
        // float x = tmp_r.eulerAngles.x;
        // float y = tmp_r.eulerAngles.y;
        // float z = tmp_r.eulerAngles.z;
        //this.gameObject.transform.parent = null;


        /*if (other.gameObject.tag == "Player"){
            //GameObject.Find("HV8").transform.parent = other.gameObject.transform;
            //GameObject.Find("HV8").transform.position = new Vector3(0.0759f, 0.018f, 0.1427f);
            // GameObject.Find("HV8").transform.rotation = Quaternion.Euler(90, 0,90);
            
            //other.transform.parent = this.gameObject.transform;
            //other.transform.localPosition = new Vector3(0.146f, -0.0854f, 0.0187f);
            //other.transform.localRotation = Quaternion.Euler(0, -90, 90);

            this.gameObject.transform.parent = GameObject.Find("jig_actual_HV6").transform;
            GameObject.Find("HV8").transform.localPosition = new Vector3(0.146f, -0.0811f, 0.0131f);
            GameObject.Find("HV8").transform.localRotation = Quaternion.Euler(0, -90, 90);

            //print(this.gameObject.name);

        }
        */

        string col_name = CollisionName.collision_name;


        if (other.gameObject.name == "Blue_Sphere")
        {
            //GameObject.Find("HV8").transform.parent = other.gameObject.transform;
            //GameObject.Find("HV8").transform.position = new Vector3(0.0759f, 0.018f, 0.1427f);
            // GameObject.Find("HV8").transform.rotation = Quaternion.Euler(90, 0,90);

            //other.transform.parent = this.gameObject.transform;
            //other.transform.localPosition = new Vector3(0.146f, -0.0854f, 0.0187f);
            //other.transform.localRotation = Quaternion.Euler(0, -90, 90);

            
            this.gameObject.transform.parent = GameObject.Find("HV_assembled").transform;
            GameObject.Find(col_name).transform.localPosition = new Vector3(0.1656f, 0.0089f, 0.034f);
            GameObject.Find(col_name).transform.localRotation = Quaternion.Euler(-90, 0, 90);

            print(col_name + "です");
            Blue = 1;
            //print(this.gameObject.name);

        }

        

        if (other.gameObject.name == "Red_Sphere")
        {
            //GameObject.Find("HV8").transform.parent = other.gameObject.transform;
            //GameObject.Find("HV8").transform.position = new Vector3(0.0759f, 0.018f, 0.1427f);
            // GameObject.Find("HV8").transform.rotation = Quaternion.Euler(90, 0,90);

            //other.transform.parent = this.gameObject.transform;
            //other.transform.localPosition = new Vector3(0.146f, -0.0854f, 0.0187f);
            //other.transform.localRotation = Quaternion.Euler(0, -90, 90);

            this.gameObject.transform.parent = GameObject.Find("HV_assembled").transform;
            GameObject.Find(col_name).transform.localPosition = new Vector3(-0.150f+0.1656f, 0.0089f, 0.034f);
            GameObject.Find(col_name).transform.localRotation = Quaternion.Euler(-90, 0, 90);
            //print(this.gameObject.name);

        }

        if (other.gameObject.name == "Yellow_Sphere")
        {
            //GameObject.Find("HV8").transform.parent = other.gameObject.transform;
            //GameObject.Find("HV8").transform.position = new Vector3(0.0759f, 0.018f, 0.1427f);
            // GameObject.Find("HV8").transform.rotation = Quaternion.Euler(90, 0,90);

            //other.transform.parent = this.gameObject.transform;
            //other.transform.localPosition = new Vector3(0.146f, -0.0854f, 0.0187f);
            //other.transform.localRotation = Quaternion.Euler(0, -90, 90);

            this.gameObject.transform.parent = GameObject.Find("HV_assembled").transform;
            GameObject.Find(col_name).transform.localPosition = new Vector3(- 0.3f + 0.1656f, 0.0089f, 0.034f);
            GameObject.Find(col_name).transform.localRotation = Quaternion.Euler(-90, 0,90);

            //print(this.gameObject.name);

        }

        if (other.gameObject.name == "Green_Sphere")
        {
            //GameObject.Find("HV8").transform.parent = other.gameObject.transform;
            //GameObject.Find("HV8").transform.position = new Vector3(0.0759f, 0.018f, 0.1427f);
            // GameObject.Find("HV8").transform.rotation = Quaternion.Euler(90, 0,90);

            //other.transform.parent = this.gameObject.transform;
            //other.transform.localPosition = new Vector3(0.146f, -0.0854f, 0.0187f);
            //other.transform.localRotation = Quaternion.Euler(0, -90, 90);

            this.gameObject.transform.parent = GameObject.Find("HV_assembled").transform;
            GameObject.Find(col_name).transform.localPosition = new Vector3(-0.3f+0.1656f, 0.0089f, -0.15f+0.034f);
            GameObject.Find(col_name).transform.localRotation = Quaternion.Euler(-90, 0, 90);

            //print(this.gameObject.name);

        }

        if (other.gameObject.name == "Purple_Sphere")
        {
            //GameObject.Find("HV8").transform.parent = other.gameObject.transform;
            //GameObject.Find("HV8").transform.position = new Vector3(0.0759f, 0.018f, 0.1427f);
            // GameObject.Find("HV8").transform.rotation = Quaternion.Euler(90, 0,90);

            //other.transform.parent = this.gameObject.transform;
            //other.transform.localPosition = new Vector3(0.146f, -0.0854f, 0.0187f);
            //other.transform.localRotation = Quaternion.Euler(0, -90, 90);

            this.gameObject.transform.parent = GameObject.Find("HV_assembled").transform;
            GameObject.Find(col_name).transform.localPosition = new Vector3(-0.15f+0.1656f, 0.0089f, -0.15f+0.034f);
            GameObject.Find(col_name).transform.localRotation = Quaternion.Euler(-90, 0, 90);

            //print(this.gameObject.name);

        }

        if (other.gameObject.name == "White_Sphere")
        {
            //GameObject.Find("HV8").transform.parent = other.gameObject.transform;
            //GameObject.Find("HV8").transform.position = new Vector3(0.0759f, 0.018f, 0.1427f);
            // GameObject.Find("HV8").transform.rotation = Quaternion.Euler(90, 0,90);

            //other.transform.parent = this.gameObject.transform;
            //other.transform.localPosition = new Vector3(0.146f, -0.0854f, 0.0187f);
            //other.transform.localRotation = Quaternion.Euler(0, -90, 90);

            this.gameObject.transform.parent = GameObject.Find("HV_assembled").transform;
            GameObject.Find(col_name).transform.localPosition = new Vector3(0.0f, 0.00f, 0.0f);
            GameObject.Find(col_name).transform.localRotation = Quaternion.Euler(-90, 0, 0);

            //print(this.gameObject.name);

        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Blue == 1)
        {
            //GameObject.Find(col_name).transform.localPosition = new Vector3(0.1656f, 0.0089f, 0.034f);
            //GameObject.Find(col_name).transform.localRotation = Quaternion.Euler(-90, 0, 90);
        }
    }
}
