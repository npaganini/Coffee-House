using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Press2Interact : MonoBehaviour
{
    //public CharacterController controller;
    public Camera mainCamera;

    int button_pressed = 0;
    int index;
    private string [] pdf_list = {"Alicia en el país de las maravillas", "Ana Karenina", "Bodas de sangre", "Cantar del Mio Cid", "Carta al padre", "Crímenes de la calle Morgue", "Cuentos completos"};
    private const float InteractDistance = 2f;

    private void Update()
    {
        
        if (Input.GetButton("Fire1"))   //Button A
        {
            button_pressed = 1;
            Interact();
        }
        else if (Input.GetButton("Fire2"))  //Button B
        {
            button_pressed = 2;
            Interact();
        }
        else if (Input.GetButton("Fire3"))  //Button C
        {
            button_pressed = 3;
            Interact();
        }
        
    }

    private void Interact()
    {
        RaycastHit hit;
        if (Physics.Raycast(mainCamera.transform.position, mainCamera.transform.forward, out hit, InteractDistance))
        {
            // Debug.Log("Me choqué primero con: " + hit.transform.name);
            if (hit.transform.CompareTag("Bookshelf"))
            {
                if (button_pressed == 1)
                {
                    ShowNextBook();
                }
                if (button_pressed == 2)
                {
                    ShowPrevBook();
                }
                if (button_pressed == 3)
                {
                    GiveBook();
                }
            }
            /*else if (hit.transform.CompareTag("Bookshelf"))
            {
                
            }*/
            button_pressed = 12;
        }
    }
    private void ShowNextBook()
    {
        index++;
    }
    private void ShowPrevBook()
    {
        index--;
    }
    private void GiveBook()
    {

    }
}

