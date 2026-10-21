using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] public int _vida = 50;
    [SerializeField] public int _vidaMaxima = 100;
    [SerializeField] private int _moedas;
    public static Action<int> OnPegouMoeda;
    [SerializeField] private Bala balaPrefab;
    [SerializeField] private Transform _bulletSpawnTransform;


    void Update()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            var bala = Instantiate(balaPrefab, _bulletSpawnTransform.position, Quaternion.identity);
            bala.SetDirecao(transform.forward);
        }
    }
    public void PegouMoeda(int valor)
    {
         _moedas += valor;

        OnPegouMoeda?.Invoke(_moedas);
    }

        public void TomarDano(int dano)
    {
        _vida -= dano;
        if (_vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
