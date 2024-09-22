using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TamilStoriesTrigger : MonoBehaviour
{


    public string nextSceneName;

    void OnTriggerEnter(Collider other)
    {
        // Check if the entering collider is the player
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(nextSceneName);

        }
    }
}