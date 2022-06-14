using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject cubePrefab, clone;

    void Update()
    {
         if (Input.GetKey(KeyCode.Space))
        {
            clone = Instantiate(cubePrefab, transform.position, Quaternion.identity);
            Destroy(clone, 3);
        }    
    }
}
