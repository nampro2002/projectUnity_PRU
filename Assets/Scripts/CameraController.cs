using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class CameraController : MonoBehaviour
//{

//    GameObject player;
//    [SerializeField]
//    Vector2 offset, v;
//    Vector3 cameraPosition;
//    void Start()
//    {
//        cameraPosition = new Vector3();
//        cameraPosition = transform.position;
//        player = GameObject.Find("Player");
//        v = new Vector2();
//    }

//    // Update is called once per frame
//    void Update()
//    {
//            cameraPosition.x = player.transform.position.x + offset.x;
//            cameraPosition.y = player.transform.position.y + offset.y;
//        //camera di chuyển theo object
//        transform.position = cameraPosition;


//    }
//}

public class CameraController  : MonoBehaviour
{
    private Transform target;
    void Start()
    {
        target = FindObjectOfType<PlayerController>().transform;

    }
    void LateUpdate()
    {
     transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);   
    }
}
