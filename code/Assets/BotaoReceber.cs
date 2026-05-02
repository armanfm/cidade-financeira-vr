using UnityEngine;
using TMPro;

public class BotaoReceber : MonoBehaviour
{
    public TMP_InputField inputValor;
    public GameObject painelCorrida;
    public GameObject painelDespesa; // painel do posto

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            FecharPainel();
        }
    }

    public void AbrirPainel()
    {
        // fecha painel do posto
        if (painelDespesa != null)
            painelDespesa.SetActive(false);

        if (painelCorrida != null)
            painelCorrida.SetActive(true);
    }

    public void ConfirmarReceita()
    {
        float valor;

        if (float.TryParse(inputValor.text, out valor))
        {
            FinanceiroManager.instancia.Receber(valor);

            inputValor.text = "";
            painelCorrida.SetActive(false);
        }
    }

    public void FecharPainel()
    {
        if (painelCorrida != null)
            painelCorrida.SetActive(false);
    }
}