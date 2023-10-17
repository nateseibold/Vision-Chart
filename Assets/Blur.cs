using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blur : MonoBehaviour
{
    private Boolean blurred = false;
    public GameObject blur;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            blurred = !blurred;
            blur.SetActive(blurred);
        }
        
    }
}
