using UnityEngine;
using UnityEngine.UI; // Dùng cho UI Text (nếu cần)
using TMPro; // Dùng cho TextMeshPro (nếu dùng TextMeshPro)

public class WinTrigger : MonoBehaviour
{
    public GameObject winCanvas; // Kéo thả Canvas chứa thông báo Win vào đây

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (winCanvas != null)
            {
                winCanvas.SetActive(true); // Hiển thị toàn bộ Canvas
            }
            else
            {
                Debug.LogError("winCanvas is not assigned!");
            }
            Debug.Log("You Win!");
        }
    }
}