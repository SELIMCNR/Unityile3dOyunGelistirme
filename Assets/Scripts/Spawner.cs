using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject spherePrefab;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(spherePrefab);
    }
}
