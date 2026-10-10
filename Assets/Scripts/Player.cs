using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public int _vida = 50;
    [SerializeField] public int _vidaMaxima = 100;
    [SerializeField] private int _moedas;
    public static Action<int> OnPegouMoeda;


    void Start()
    {
        LevelUp();
    }
    public void LevelUp()
    {
        Debug.Log("Player passou de nivel!");
    }

    public void PegouMoeda(int valor)
    {
        _moedas += valor;

        OnPegouMoeda?.Invoke(_moedas);
    }
}
