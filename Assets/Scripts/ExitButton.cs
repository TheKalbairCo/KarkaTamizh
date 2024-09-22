using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButton : MonoBehaviour
{
    public string exitSceneName; // Change this to the scene you want to exit to

    public void ExitToScene()
    {
        SceneManager.LoadScene(exitSceneName);
    }
}
