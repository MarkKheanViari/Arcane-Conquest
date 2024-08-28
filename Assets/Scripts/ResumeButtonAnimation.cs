using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonAnimationController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject animatedImage;  // Assign the image in the Inspector

    private bool isAnimating = false;

    void Start()
    {
        // Ensure the image is disabled at the start
        if (animatedImage != null)
        {
            animatedImage.SetActive(false);
        }
    }

    // Called when the user presses down on the button
    public void OnPointerDown(PointerEventData eventData)
    {
        if (!isAnimating)
        {
            isAnimating = true;
            // Show the image
            if (animatedImage != null)
            {
                animatedImage.SetActive(true);
            }
        }
    }

    // Called when the user releases the button
    public void OnPointerUp(PointerEventData eventData)
    {
        if (isAnimating)
        {
            isAnimating = false;
            // Hide the image
            if (animatedImage != null)
            {
                animatedImage.SetActive(false);
            }
        }
    }
}
