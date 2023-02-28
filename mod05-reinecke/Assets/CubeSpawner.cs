using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour

{ public GameObject CubePrefabVar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject cubeGo = Instantiate<GameObject>(CubePrefabVar);
        Material mat = cubeGo.GetComponent<Renderer>().material;
        mat.color = UnityEngine.Random.ColorHSV(0, 1, 0.5f, 1, 0.75f, 1);
        
    }
}
