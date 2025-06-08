using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public AudioSource Sound;

    public Sprite pauseIcon;
    public Sprite playIcon;
    public Image buttonImage;

    public GameObject pausePanel;

    private bool paused;

    public void PauseGame()
    {

        if (paused)
        {
            Time.timeScale = 1;
            Sound.Play();
            UpdateIcon();
            pausePanel.SetActive(false);
        }
        else
        {
            Time.timeScale = 0;
            Sound.Pause();
            UpdateIcon();
            pausePanel.SetActive(true);
        }

        paused = !paused;
    }

    void UpdateIcon()
    {
        buttonImage.sprite = paused ? pauseIcon : playIcon;
    }
}
