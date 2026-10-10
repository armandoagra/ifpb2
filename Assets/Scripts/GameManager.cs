using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private Player _player;
    [SerializeField] private Moeda _ultimaMoeda;

    void Awake()
    {
        Instance = this;
        
        _player = FindAnyObjectByType<Player>();
    }

    void OnEnable() { Player.OnPegouMoeda += UpdateUI; }
    void OnDisable() { Player.OnPegouMoeda -= UpdateUI; }

    public void UpdateUI(int moedas)
    {
        Debug.Log("UI do jogo atualizada! Moedas = " + moedas);
    }
}
