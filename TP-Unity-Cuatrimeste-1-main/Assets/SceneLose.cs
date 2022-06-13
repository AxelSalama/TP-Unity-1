using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLose : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene("LoseScene");
    }
}

