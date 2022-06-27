using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject cubePrefab, clone;
    public float a = 6;
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            while (a > 0)
            {
                a--;
                clone = Instantiate(cubePrefab, transform.position, Quaternion.identity);
                Destroy(clone, 3);
            }
        }
    }
}
