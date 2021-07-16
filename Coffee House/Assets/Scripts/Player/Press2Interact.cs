using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Press2Interact : MonoBehaviour
{
    //public CharacterController controller;
    public Camera mainCamera;
    public Material LeftPage;
    public Material RightPage;
    public TextMesh adviseText;
    

    //lista de libros
    public Texture[] Alicia;
    public Texture[] Bodas;
    public Texture[] MioCid;
    public Texture[] Kafka;
    public Texture[] CalleM;
    public Texture[] Zas;

    private int button_pressed = 0;
    private int book_index = 0;
    private int pdf_index = 0;


    private string[] pdf_list = {"Alice in wonderland", "Bodas de sangre", "Cantar del Mio Cid", "Carta al padre", "Crímenes de la calle Morgue", "!Zas!"};
    private const float InteractDistance = 2f;

    void Start()
    {
        LeftPage.SetTexture("_MainTex",Alicia[book_index]);
        RightPage.SetTexture("_MainTex",Alicia[book_index+1]);
        adviseText.text = pdf_list[pdf_index];
    }

    private void Update()
    {
        
        if (Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.Q))   //Button A (next)
        {
            button_pressed = 1;
            Interact();
        }
        else if (Input.GetButtonDown("Fire2") || Input.GetKeyDown(KeyCode.E))  //Button B (prev)
        {
            button_pressed = 2;
            Interact();
        }
        else if (Input.GetButtonDown("Fire3") || Input.GetKeyDown(KeyCode.F))  //Button C (Pick)
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
            if (hit.transform.CompareTag("BookMenu"))  //Cambia el índice y setea qué libro leo
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
                    book_index = 0;
                    SetBookTexture(pdf_index, 0);
                }
            }
             if (hit.transform.CompareTag("Book"))  //Setea material para las páginas siguientes o anterior
            {
                if (button_pressed == 1)
                {
                    book_index += 2;
                    SetBookTexture(pdf_index, book_index);
                }
                if (button_pressed == 2)
                {
                    book_index -= 2;
                    SetBookTexture(pdf_index, book_index);
                }
               
            }
           
        }
    }
    private void ShowNextBook()
    {
        pdf_index++;
        if (pdf_index > 5)
            pdf_index = 0;
        adviseText.text = pdf_list[pdf_index];
    }
    private void ShowPrevBook()
    {
        pdf_index--;
        if (pdf_index < 5)
            pdf_index = 0;
        adviseText.text = pdf_list[pdf_index];
    }
    private void SetBookTexture(int pdf_index, int book_index)  //Setea los materiales de las páginas del libro
    {
        
        if(pdf_index == 0)
        {
            if (book_index == Alicia.Length)
                book_index = 0;
            LeftPage.SetTexture("_MainTex",Alicia[book_index]);
            RightPage.SetTexture("_MainTex",Alicia[book_index+1]);
        }
        else if(pdf_index == 1)
        {
            if (book_index == Bodas.Length)
                book_index = 0;
            LeftPage.SetTexture("_MainTex",Bodas[book_index]);
            RightPage.SetTexture("_MainTex",Bodas[book_index+1]);
        }
        else if(pdf_index == 2)
        {
            if (book_index == MioCid.Length)
                book_index = 0;
            LeftPage.SetTexture("_MainTex",MioCid[book_index]);
            RightPage.SetTexture("_MainTex",MioCid[book_index+1]);
        }
        else if(pdf_index == 3)
        {
            if (book_index == Kafka.Length)
                book_index = 0;
            LeftPage.SetTexture("_MainTex",Kafka[book_index]);
            RightPage.SetTexture("_MainTex",Kafka[book_index+1]);
        }
        else if(pdf_index == 4)
        {
            if (book_index == CalleM.Length)
                book_index = 0;
            LeftPage.SetTexture("_MainTex",CalleM[book_index]);
            RightPage.SetTexture("_MainTex",CalleM[book_index+1]);
        }
        else if(pdf_index == 5)
        {
            if (book_index == Zas.Length)
                book_index = 0;
            LeftPage.SetTexture("_MainTex",Zas[book_index]);
            RightPage.SetTexture("_MainTex",Zas[book_index+1]);
        }

    }
}

