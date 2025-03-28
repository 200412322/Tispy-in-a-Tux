using UnityEngine;
using UnityEngine.UI;
    
public class BookSound : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(PlaySound);
    }

    private void PlaySound()
    {   
        // Run the PlaySFX function from the Audio Manager
        AudioManager.instance.PlaySFX(AudioManager.instance.BookOpenSound);
    }
}
