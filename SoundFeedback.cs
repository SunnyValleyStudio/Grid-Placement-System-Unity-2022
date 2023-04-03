using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFeedback : MonoBehaviour
{
    [SerializeField]
    private AudioClip clickSound, placeSound, removeSound, wrongPlacementSound;

    [SerializeField]
    private AudioSource audioSource;

    public void PlaySound(SoundType soundType)
    {
        switch (soundType)
        {
            case SoundType.Click:
                audioSource.PlayOneShot(clickSound);
                break;
            case SoundType.Place:
                audioSource.PlayOneShot(placeSound);
                break;
            case SoundType.Remove:
                audioSource.PlayOneShot(removeSound);
                break;
            case SoundType.wrongPlacement:
                audioSource.PlayOneShot(wrongPlacementSound);
                break;
            default:
                break;
        }
    }
}

public enum SoundType
{
    Click,
    Place,
    Remove,
    wrongPlacement
}
