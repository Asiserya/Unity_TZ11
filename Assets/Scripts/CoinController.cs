using System.Diagnostics;
using UnityEngine;
using UnityEngine.Rendering;
using Debug = UnityEngine.Debug;

public class CoinController : MonoBehaviour
{

    [SerializeField]private Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            anim.SetTrigger("Collect");
        }
    }
}
