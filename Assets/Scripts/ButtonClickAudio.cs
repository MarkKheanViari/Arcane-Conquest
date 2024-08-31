using UnityEngine;

public class ButtonClickAudio : MonoBehaviour
{
    public AudioSource soundPlayer; // Reference to the AudioSource component

    // Method to play the sound effect
    public void PlayThisSoundEffect()
    {
        if (soundPlayer != null)
        {
            soundPlayer.Play();
        }
        else
        {
            Debug.LogWarning("AudioSource is not assigned.");
        }
    }
}
