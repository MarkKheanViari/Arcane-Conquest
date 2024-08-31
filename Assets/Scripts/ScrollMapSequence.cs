using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ImageSequenceController : MonoBehaviour
{
    public Image primaryImage;     // Assign your primary image in the Inspector
    public Image secondaryImage;   // Assign your secondary image in the Inspector
    public float delayBeforeSecondImage = 0.01f;  // Delay in seconds before showing the second image

    void Start()
    {
        // Ensure only the primary image is visible at the start
        primaryImage.gameObject.SetActive(true);
        secondaryImage.gameObject.SetActive(false);

        // Start the sequence to show the second image after a delay
        StartCoroutine(ShowSecondImageAfterDelay());
    }

    private IEnumerator ShowSecondImageAfterDelay()
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delayBeforeSecondImage);

        // Show the second image
        secondaryImage.gameObject.SetActive(true);
    }
}
