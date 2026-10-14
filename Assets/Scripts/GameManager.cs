using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private GameObject _telaFinal;
    [SerializeField] private TextMeshProUGUI _finalScoreText;
    [SerializeField] private Color _finalScoreColor;
    private int _moedas;


    void Awake()
    {
        Instance = this;
    }

    void OnEnable() { Player.OnPegouMoeda += UpdateUI; }
    void OnDisable() { Player.OnPegouMoeda -= UpdateUI; }

    public void UpdateUI(int moedas)
    {
        _moedas = moedas;
        _scoreText.text = moedas.ToString();
    }

    public void GameOver()
    {
        _finalScoreText.text = _moedas.ToString();
        _finalScoreText.color = _finalScoreColor;
        _telaFinal.SetActive(true);
        
    }

    private void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
