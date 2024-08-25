using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowCard : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject popUp;
    [SerializeField] private bool canInteract;
    [SerializeField] private bool isActive;

    private void Start()
    {
        panel.SetActive(false);
        popUp.SetActive(false);
    }

    private void OnMouseEnter()
    {
        Debug.Log("Entrou");

        popUp.SetActive(true);
        canInteract = true;
    }

    private void OnMouseExit()
    {
        Debug.Log("Saiu");

        popUp.SetActive(false);
        canInteract = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canInteract)
            Interact();
    }

    public void Interact()
    {
        if (!isActive)
        {
            panel.SetActive(true);
            isActive = true;

            popUp.GetComponentInChildren<TextMeshProUGUI>().text = "Aperte E para fechar";
        }
        else
        {
            panel.SetActive(false);
            isActive = false;

            popUp.GetComponentInChildren<TextMeshProUGUI>().text = "E - INTERAGIR";
        }
    }
}