using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpTest : MonoBehaviour
{
    public GameObject posA, posB;
    public float speed;
    public bool isMoving;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving == true)
        {
            this.transform.position = Vector3.Lerp(posA.transform.position, posB.transform.position, speed * Time.deltaTime);
        }
       
    }
}
