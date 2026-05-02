using UnityEngine;

public class CarroClick : MonoBehaviour
{
    public GameObject painelReceita;

    void Start()
    {
        if (painelReceita != null)
            painelReceita.SetActive(false);
    }

    void OnMouseDown()
    {
        if (painelReceita != null)
            painelReceita.SetActive(true);
    }

    public void FecharPainel()
    {
        if (painelReceita != null)
            painelReceita.SetActive(false);
    }
}