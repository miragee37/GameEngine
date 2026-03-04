using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float walkSpeed = 5f;
    public float runSpeed = 10f;
    private float currentSpeed;

    private bool isRunning = false; // Toggle durumunu tutan deðiþken

    void Start()
    {
        currentSpeed = walkSpeed;
    }

    void Update()
    {
        // 1. Shift ile Koþu Toggle Mekaniði
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isRunning = !isRunning; // Durumu tersine çevir (True ise False, False ise True yap)
            currentSpeed = isRunning ? runSpeed : walkSpeed;
        }

        // 2. WASD Hareket Girdilerini Al
        float moveX = Input.GetAxis("Horizontal"); // A ve D tuþlarý
        float moveZ = Input.GetAxis("Vertical");   // W ve S tuþlarý

        // 3. Hareket Vektörünü Hesapla ve Uygula
        Vector3 move = transform.right * moveX + transform.forward * moveZ;
        transform.position += move * currentSpeed * Time.deltaTime;
    }
}