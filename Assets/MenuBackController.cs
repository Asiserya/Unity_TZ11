using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuBackController : MonoBehaviour
{
    public Button menuBackButton;

    public void LoadMenuScene(int sceneindex)
    {
        SceneManager.LoadScene(sceneindex);
    }
}
