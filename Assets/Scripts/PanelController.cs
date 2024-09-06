using UnityEngine;

public class PanelController : MonoBehaviour
{
    public GameObject archerPanel;      // Assign ArcherPanel in the Inspector
    public GameObject archerInfoPanel;  // Assign ArcherInfoPanel in the Inspector

    void Start()
    {
        // Ensure ArcherInfoPanel is initially inactive
        if (archerInfoPanel != null)
        {
            archerInfoPanel.SetActive(false);
        }
    }

    // Show ArcherInfoPanel and hide ArcherPanel
    public void ShowArcherInfoPanel()
    {
        if (archerPanel != null && archerInfoPanel != null)
        {
            archerPanel.SetActive(false);
            archerInfoPanel.SetActive(true);
        }
    }

    // Hide ArcherInfoPanel and show ArcherPanel
    public void BackToArcherPanel()
    {
        if (archerPanel != null && archerInfoPanel != null)
        {
            archerInfoPanel.SetActive(false);
            archerPanel.SetActive(true);
        }
    }
}
