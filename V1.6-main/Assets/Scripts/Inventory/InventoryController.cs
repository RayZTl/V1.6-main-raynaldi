/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    [SerializeField]
    private UIInventoryPage inventoryUI;

    public int inventorySize = 10;

    private void Start()
    {
        inventoryUI.InitializeInventoryUI(inventorySize);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("Tombol 'I' ditekan");
            if (inventoryUI.isActiveAndEnabled == false)
            {
                inventoryUI.Show();
                Debug.Log("Tampilkan Inventory");
            }
            else
            {
                inventoryUI.Hide();
                Debug.Log("Sembunyikan Inventory");
            }

        }
    }
}
*/