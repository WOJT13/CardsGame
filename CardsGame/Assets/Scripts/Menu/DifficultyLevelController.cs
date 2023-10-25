﻿using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Diagnostics.Tracing;
public class DifficultyLevelController : MonoBehaviour
{
   public GameObject buttonPrefab; // Prefab przycisku
    public Transform buttonContainer; // Kontener na przyciski
    
    void Start()
    {
        CreateDifficultyButtons();
    }
    void CreateDifficultyButtons()
    {
        
        Debug.Log(DataManager.Instance.difficultyLevelsList.GetAll().Count);
        foreach (var level in DataManager.Instance.difficultyLevelsList.GetAll())
        {
            // Tworzenie przycisku
            GameObject button = Instantiate(buttonPrefab, buttonContainer);
            button.GetComponentInChildren<TMP_Text>().text = level.name; // Ustaw nazwę na przycisku
            button.GetComponentInChildren<Image>().sprite = level.icon; // Ustaw ikonę na przycisku
            //button.GetComponent<Button>().onClick.AddListener(() => ChooseLevel(level)); // Dodaj akcję przy kliknięciu
            //button.transform.SetParent(buttonContainer);
        }
    }

}
