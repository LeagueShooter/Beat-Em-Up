using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaloManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Component halo = GetComponent("Halo");
        halo.GetType().GetProperty("enabled").SetValue(halo, true, null);
        print("On");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TurnOnHalo()
    {

    }
    void TurnOffHalo()
    {

    }
}
