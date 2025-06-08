using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitToScene2 : MonoBehaviour
{
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (other.CompareTag("Ball"))
                SceneManager.LoadScene(2);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            if (other.CompareTag("Ball"))
            SceneManager.LoadScene(3);
        }
        else if(SceneManager.GetActiveScene().buildIndex == 3)
        {
            if (other.CompareTag("Ball"))
                SceneManager.LoadScene(0);
        }
    }
}
