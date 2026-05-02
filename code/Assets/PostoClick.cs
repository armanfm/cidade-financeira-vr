using UnityEngine;
using TMPro;

public class PostoClick : MonoBehaviour
{
    public GameObject painelDespesa;
    public TMP_InputField inputGas;
    public GameObject painelReceita; // painel do carro

    void Start()
    {
        if (painelDespesa != null)
            painelDespesa.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            FecharPainel();
        }
    }

    void OnMouseDown()
    {
        // fecha painel do carro ao abrir posto
        if (painelReceita != null)
            painelReceita.SetActive(false);

        if (painelDespesa != null)
            painelDespesa.SetActive(true);
    }

    public void ConfirmarDespesa()
    {
        float valor;

        if (float.TryParse(inputGas.text, out valor))
        {
            FinanceiroManager.instancia.Pagar(valor);
            inputGas.text = "";
            painelDespesa.SetActive(false);
        }
    }

    public void FecharPainel()
    {
        if (painelDespesa != null)
            painelDespesa.SetActive(false);
    }
}