using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Inimigo : MonoBehaviour
{
    [SerializeField] private int vida = 50;
    private NavMeshAgent _agent;
    private Player _player;

    void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        _player = FindAnyObjectByType<Player>();
    }

    void Update()
    {
        _agent.SetDestination(_player.transform.position);
    }

    public void TomarDano(int dano)
    {
        vida -= dano;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.collider.TryGetComponent<Player>(out var player))
        {
            player.TomarDano(10);
        }
    }

}
