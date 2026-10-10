using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public int _cura = 25;

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>()._vida < other.GetComponent<Player>()._vidaMaxima)
        {
            other.GetComponent<Player>()._vida += _cura;
            other.GetComponent<Player>()._vida = Mathf.Min(other.GetComponent<Player>()._vida, other.GetComponent<Player>()._vidaMaxima);
            Destroy(gameObject);
        }
    }
}
