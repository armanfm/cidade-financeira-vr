using UnityEngine;
using TMPro;

public class FinanceiroManager : MonoBehaviour
{
    public static FinanceiroManager instancia;

    public float saldo = 0f;
    public TextMeshProUGUI textoSaldo;

    void Awake()
    {
        instancia = this;
    }

    void Start()
    {
        AtualizarTela();
    }

    public void Receber(float valor)
    {
        saldo += valor;
        AtualizarTela();
    }

    public void Pagar(float valor)
    {
        saldo -= valor; // agora pode ficar negativo
        AtualizarTela();
    }

    void AtualizarTela()
    {
        if (textoSaldo != null)
        {
            textoSaldo.text = "Saldo: R$ " + saldo.ToString("F2");

            if (saldo > 0)
            {
                textoSaldo.color = Color.green;
            }
            else if (saldo < 0)
            {
                textoSaldo.color = Color.red;
            }
            else
            {
                textoSaldo.color = Color.yellow;
            }
        }
    }
}