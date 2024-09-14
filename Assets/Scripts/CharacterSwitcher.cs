using UnityEngine;
using UnityEngine.UI;

public class PanelSwitcher : MonoBehaviour
{
    public GameObject[] panels;  // Array to hold references to your panels
    public Button nextButton;    // Reference to the Next button
    public Button previousButton; // Reference to the Previous button

    private int currentIndex = 0; // Index to keep track of the current panel, start with 0

    void Start()
    {
        // Ensure all panels are inactive at the start
        foreach (var panel in panels)
        {
            panel.SetActive(false);
        }

        // Show the first panel initially
        ShowPanel(currentIndex);

        // Add listeners to buttons
        if (nextButton != null)
            nextButton.onClick.AddListener(OnNextButtonClick);
        if (previousButton != null)
            previousButton.onClick.AddListener(OnPreviewButtonClick);
    }

    public void OnNextButtonClick()
    {
        // Hide the current panel
        if (panels.Length > 0)
        {
            panels[currentIndex].SetActive(false);
        }

        // Move to the next panel, wrapping around using modulo
        currentIndex = (currentIndex + 1) % panels.Length;

        // Show the next panel
        ShowPanel(currentIndex);

        // Update button states (optional)
        UpdateButtonStates();
    }

    public void OnPreviewButtonClick()
    {
        // Hide the current panel
        if (panels.Length > 0)
        {
            panels[currentIndex].SetActive(false);
        }

        // Move to the previous panel, wrapping around using modulo
        currentIndex = (currentIndex - 1 + panels.Length) % panels.Length;

        // Show the previous panel
        ShowPanel(currentIndex);

        // Update button states (optional)
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
        // Optional: Update button interactivity based on the current index
        // For example, you might disable the buttons if there's no previous or next panel
    }
}
