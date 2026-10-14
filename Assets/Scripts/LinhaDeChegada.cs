using UnityEngine;

public class LinhaDeChegada : MonoBehaviour
{


    void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Player>(out var player))
        {
            GameManager.Instance.GameOver();
        }
    }

}
