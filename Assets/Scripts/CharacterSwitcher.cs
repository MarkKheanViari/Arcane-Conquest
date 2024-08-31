using UnityEngine;
using UnityEngine.UI;

public class PanelSwitcher : MonoBehaviour
{
    public GameObject[] panels;  // Array to hold references to your panels
    public Button nextButton;    // Reference to the "Next" button
    public Button previewButton; // Reference to the "Preview" button

    private int currentIndex = -1; // Index to keep track of the current panel, start with -1

    void Start()
    {
        // Ensure all panels are inactive at the start
        foreach (var panel in panels)
        {
            panel.SetActive(false);
        }

        // Add the Click event listeners to the buttons
        nextButton.onClick.AddListener(OnNextButtonClick);
        previewButton.onClick.AddListener(OnPreviewButtonClick);

        // Show the first panel initially
        ShowPanel(0);
    }

    void OnNextButtonClick()
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
            // Optionally handle what happens when there are no more panels
            Debug.Log("No more panels to show.");
        }

        // Update button states
        UpdateButtonStates();
    }

    void OnPreviewButtonClick()
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
            // Optionally handle what happens when there are no previous panels
            Debug.Log("No previous panels to show.");
            currentIndex = 0; // Optionally reset to the first panel
        }

        // Update button states
        UpdateButtonStates();
    }

    void ShowPanel(int index)
    {
        if (index >= 0 && index < panels.Length)
        {
            panels[index].SetActive(true);
        }
    }

    void UpdateButtonStates()
    {
        // Update button interactivity based on the current index
        nextButton.interactable = (currentIndex < panels.Length - 1);
        previewButton.interactable = (currentIndex > 0);
    }
}
