using UnityEngine;
using UnityEngine.SceneManagement; // Needed for scene management
using UnityEngine.UI;
using System.Collections;

public class PauseController : MonoBehaviour
{
    public GameObject pausePanel;  // Assign your pause panel in the Inspector
    public GameObject animatedImage;  // Assign your animated image in the Inspector
    public float displayDuration = 0.5f; // Duration the image should stay visible

    private bool isPaused = false;

    void Start()
    {
        // Ensure the pause panel is initially disabled
        if (pausePanel != null)
        {
            pausePanel.SetActive(false);
        }

        // Ensure the animated image is initially disabled
        if (animatedImage != null)
        {
            animatedImage.SetActive(false);
        }
    }

    // Call this function when the Pause button is clicked
    public void TogglePause()
    {
        isPaused = !isPaused;

        // Toggle the pause panel's visibility
        if (pausePanel != null)
        {
            pausePanel.SetActive(isPaused);
        }

        // Pause or resume the game
        if (isPaused)
        {
            Time.timeScale = 0f; // Pause the game
        }
        else
        {
            Time.timeScale = 1f; // Resume the game
        }
    }

    // Call this function when the Resume button is clicked
    public void ResumeGame()
    {
        if (pausePanel != null)
        {
            pausePanel.SetActive(false); // Hide the pause panel
        }

        Time.timeScale = 1f; // Resume the game

        // Optionally, if you have an animated image effect
        if (animatedImage != null)
        {
            StartCoroutine(ShowAndHideImage());
        }
    }

    private IEnumerator ShowAndHideImage()
    {
        animatedImage.SetActive(true);
        yield return new WaitForSeconds(displayDuration);
        animatedImage.SetActive(false);
    }

    // Call this function when the Exit button is clicked
    public void ExitToHome()
    {
        // Load the Home scene
        SceneManager.LoadScene(SceneData.home);
    }
}
