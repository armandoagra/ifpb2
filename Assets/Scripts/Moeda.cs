using UnityEngine;

public class Moeda : MonoBehaviour
{
    public int _valor;

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>())
        {
            Player player = other.GetComponent<Player>();
            player.PegouMoeda(_valor);
            Destroy(gameObject);
        }
    }

}
