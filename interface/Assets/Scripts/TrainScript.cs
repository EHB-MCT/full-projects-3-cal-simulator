using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = Camera.main.transform.position - new Vector3(0, 0.01f, 0) + Camera.main.transform.forward *0.5f;
        
    }
}