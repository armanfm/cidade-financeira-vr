using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instancia;

    public GameObject painelCarro;
    public GameObject painelPosto;

    void Awake()
    {
        instancia = this;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            FecharTodos();
        }
    }

    public void AbrirCarro()
    {
        painelPosto.SetActive(false);
        painelCarro.SetActive(true);
    }

    public void AbrirPosto()
    {
        painelCarro.SetActive(false);
        painelPosto.SetActive(true);
    }

    public void FecharTodos()
    {
        painelCarro.SetActive(false);
        painelPosto.SetActive(false);
    }
}