using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class HideImage : MonoBehaviour
{
    public Canvas buttonsCanvas;
    public Canvas imageCanvas;
    public Canvas thirdCanvas;
    public Canvas fourthCanvas; // New canvas

    private void Start()
    {
        // Ensure all canvases are initially disabled
        buttonsCanvas.enabled = true;
        imageCanvas.enabled = false;
        thirdCanvas.enabled = false;
        fourthCanvas.enabled = false; // New canvas
    }

    public void ShowImageCanvas()
    {
        // Disable the buttonsCanvas, thirdCanvas, and fourthCanvas, and enable the imageCanvas
        buttonsCanvas.enabled = false;
        imageCanvas.enabled = true;
        thirdCanvas.enabled = false;
        fourthCanvas.enabled = false; // New canvas
    }

    public void ShowThirdCanvas()
    {
        // Disable the buttonsCanvas, imageCanvas, and fourthCanvas, and enable the thirdCanvas
        buttonsCanvas.enabled = false;
        imageCanvas.enabled = false;
        thirdCanvas.enabled = true;
        fourthCanvas.enabled = false; // New canvas
    }

    public void ShowFourthCanvas()
    {
        // Disable the buttonsCanvas, imageCanvas, and thirdCanvas, and enable the fourthCanvas
        buttonsCanvas.enabled = false;
        imageCanvas.enabled = false;
        thirdCanvas.enabled = false;
        fourthCanvas.enabled = true; // New canvas
    }

    public void ShowButtonsCanvas()
    {
        // Enable the buttonsCanvas and disable the imageCanvas, thirdCanvas, and fourthCanvas
        buttonsCanvas.enabled = true;
        imageCanvas.enabled = false;
        thirdCanvas.enabled = false;
        fourthCanvas.enabled = false; // New canvas
    }

    // Called when the "ShowImageButton" is clicked
    public void OnShowImageButtonClick()
    {
        ShowImageCanvas();
    }

    // Called when the "ShowThirdButton" is clicked
    public void OnShowThirdButtonClick()
    {
        ShowThirdCanvas();
    }

    // Called when the "ShowFourthButton" is clicked
    public void OnShowFourthButtonClick()
    {
        ShowFourthCanvas();
    }

    private void Update()
    {
        // Check for the Escape key press to go back to the buttonsCanvas
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            ShowButtonsCanvas();
        }
    }

    public void Back()
    {
        SceneManager.LoadScene("PlayGround");
    }
}
