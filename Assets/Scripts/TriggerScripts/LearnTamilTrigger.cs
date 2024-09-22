using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LearnTamilTrigger : MonoBehaviour
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