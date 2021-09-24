using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    [SerializeField] Transform player;
    [SerializeField] GameObject playerObject;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(Input.GetAxis("Horizontal"));
        

    }


    /*void MoveCam()
    {
        transform.LookAt(player);

        print(playerObject.transform.position);

        float newX = playerObject.transform.position.x;
        float newY = playerObject.transform.position.y;
        float newZ = transform.position.z;


        transform.position = new Vector3(newX, newY, newZ);
    }*/
}
