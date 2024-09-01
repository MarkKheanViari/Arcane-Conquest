using UnityEngine;
using UnityEngine.UI;

public class PanelSwitcher : MonoBehaviour
{
    public GameObject[] panels;  // Array to hold references to your panels

    private int currentIndex = -1; // Index to keep track of the current panel, start with -1

    void Start()
    {
        // Ensure all panels are inactive at the start
        foreach (var panel in panels)
        {
            panel.SetActive(false);
        }

        // Show the first panel initially
        ShowPanel(0);
    }

    public void OnNextButtonClick()
    {
        // Hide the current panel
        if (currentIndex >= 0 && currentIndex < panels.Length)
        {
            panels[currentIndex].SetActive(false);
        }

        // Move to the next panel
        currentIndex++;

        // Show the next panel if it exists
        if (currentIndex < panels.Length)
        {
            ShowPanel(currentIndex);
        }
        else
        {
            Debug.Log("No more panels to show.");
            currentIndex = panels.Length - 1; // Ensure index doesn't go out of range
        }

        // Update button states (optional)
        UpdateButtonStates();
    }

    public void OnPreviewButtonClick()
    {
        // Hide the current panel
        if (currentIndex >= 0 && currentIndex < panels.Length)
        {
            panels[currentIndex].SetActive(false);
        }

        // Move to the previous panel
        currentIndex--;

        // Show the previous panel if it exists
        if (currentIndex >= 0)
        {
            ShowPanel(currentIndex);
        }
        else
        {
            Debug.Log("No previous panels to show.");
            currentIndex = 0; // Ensure index doesn't go out of range
        }

        // Update button states (optional)
        UpdateButtonStates();
    }

    void ShowPanel(int index)
    {
        if (index >= 0 && index < panels.Length)
        {
            panels[index].SetActive(true);
            currentIndex = index;
        }
    }

    void UpdateButtonStates()
    {
        // Optional: Update button interactivity based on the current index
        // e.g., nextButton.interactable = (currentIndex < panels.Length - 1);
        // e.g., previewButton.interactable = (currentIndex > 0);
    }
}
