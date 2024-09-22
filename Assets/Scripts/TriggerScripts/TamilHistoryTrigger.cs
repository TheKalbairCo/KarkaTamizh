
using UnityEngine;
using UnityEngine.SceneManagement;


public class TamilHistoryTrigger : MonoBehaviour
{
    // Specify the name of the scene you want to load
    public string sceneToLoad;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the entering object is the player
        if (other.CompareTag("Player"))
        {
            // Load the specified scene
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}