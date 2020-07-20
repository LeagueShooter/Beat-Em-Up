using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    public float speed = 1.0f;
    public Transform target;
    public bool isHit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isHit)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

            if (Vector3.Distance(transform.position, target.position) < 2f)
            {
                //target.position *= -1.0f;
                Invoke("PositionReset", 1.5f);
                isHit = true;
            }
        }
       
    }
    void PositionReset()
    {
        transform.position = new Vector3(0, 0, 0);
    }
}
