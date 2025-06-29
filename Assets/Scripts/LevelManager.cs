using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject levelPrefab; // Gán Prefab level vào đây trong Inspector
    public Transform spawnPoint;   // Vị trí spawn level
    public GameObject canvas;      // Gán Canvas vào đây trong Inspector

    public void ShowLevel()
    {
        if (levelPrefab != null && spawnPoint != null && canvas != null)
        {
            Instantiate(levelPrefab, spawnPoint.position, Quaternion.identity);
            canvas.SetActive(false); // Tắt Canvas
        }
    }
}