using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocidade = 5f;
    public float sensibilidadeMouse = 180f;

    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.None;
    }

    void Update()
    {
        Movimento();
        GirarComBotaoDireito();
    }

    void Movimento()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 mover = transform.forward * v + transform.right * h;

        controller.Move(mover * velocidade * Time.deltaTime);
    }

    void GirarComBotaoDireito()
    {
        if (Input.GetMouseButton(1)) // botão direito segurado
        {
            float mouseX = Input.GetAxis("Mouse X");

            transform.Rotate(0f, mouseX * sensibilidadeMouse * Time.deltaTime, 0f);
        }
    }
}