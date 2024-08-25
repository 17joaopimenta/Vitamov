using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Button : MonoBehaviour
{
    [SerializeField] GameObject organModel;
    [SerializeField] TextMeshProUGUI textMeshProUGUI;

    private void Update()
    {
        if (organModel != null && organModel.activeSelf) 
        {
            textMeshProUGUI.text = "Clique";
        }
        else if (organModel != null && !organModel.activeSelf)
        {
            textMeshProUGUI.text = "Fudeu";
        }
        else
        {
            textMeshProUGUI.text = "Invisivel";
        }
    }
}
