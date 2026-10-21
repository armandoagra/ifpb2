using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] private float _velocidade = 3f;
    private Vector3 _direcao;
    [SerializeField] private int _dano = 10;

    void Start()
    {
        Destroy(gameObject, 1.5f);

    }
    void Update()
    {
        transform.Translate(_direcao * _velocidade * Time.deltaTime);
    }

    public void SetDirecao(Vector3 direcao)
    {
        _direcao = direcao;
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Bala colidiu com algo...");
        if (other.TryGetComponent<Inimigo>(out var inimigo)){
            inimigo.TomarDano(_dano);
            Destroy(gameObject);
        }
    }
}
