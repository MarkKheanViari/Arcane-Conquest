using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CharacterSelection : MonoBehaviour, IPointerClickHandler
{
    public RectTransform hitBox; // Assign your custom hitbox RectTransform in the Inspector
    public Button button; // Assign the Button component that you want to trigger

    // Start is called before the first frame update
    void Start()
    {
        if (hitBox == null)
        {
            Debug.LogError("HitBox RectTransform is not assigned.");
        }
        else
        {
            Debug.Log("HitBox RectTransform is assigned.");
        }

        if (button == null)
        {
            Debug.LogError("Button component is not assigned.");
        }
        else
        {
            Debug.Log("Button component is assigned.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // You can add any additional logic here if needed
    }

    // This method is triggered when the user clicks on the UI element
    public void OnPointerClick(PointerEventData eventData)
    {
        // Check if the click was within the custom HitBox area
        if (RectTransformUtility.RectangleContainsScreenPoint(hitBox, eventData.position, eventData.pressEventCamera))
        {
            button.onClick.Invoke(); // Trigger the button's onClick event
        }
    }

    // Public method to trigger button click event (for OnClick() in Inspector)
    public void TriggerButtonClick()
    {
        // Simulate the button click
        if (button != null)
        {
            button.onClick.Invoke();
        }
    }
}
