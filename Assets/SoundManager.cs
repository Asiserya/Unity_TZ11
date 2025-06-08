using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Sprite soundOnIcon;
    public Sprite soundOffIcon;
    public Image buttonImage;

    private bool isMuted;

    void Start()
    {
        isMuted = PlayerPrefs.GetInt("Muted", 0) == 1;
        UpdateSound();
    }

    public void ToggleSound()
    {
        isMuted = !isMuted;
        PlayerPrefs.SetInt("Muted", isMuted ? 1 : 0);
        PlayerPrefs.Save();
        UpdateSound();
    }

    void UpdateSound()
    {
        AudioListener.volume = isMuted ? 0f : 1f;
        buttonImage.sprite = isMuted ? soundOffIcon : soundOnIcon;
    }
}
