using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public GameObject menu;
    public GameObject inventory;

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
            if (menu.activeSelf)
                menu.SetActive(false);
            else
                menu.SetActive(true);
               
        
        if (Input.GetButtonDown("Inventory"))
            if (inventory.activeSelf)
                inventory.SetActive(false);
            else
                inventory.SetActive(true);
    }
    
    public void ToTitle()
    {
        SceneManager.LoadScene(0);
    }

    public void GameExit()
    {
        Application.Quit();
    }
}
