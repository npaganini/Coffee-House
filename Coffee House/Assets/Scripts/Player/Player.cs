using System;
using System.Linq;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController controller;
    public ExitMenu exitUi;
    private const float PlayerSpeed = 4f;
    public float interactDistance = 4f;
    public Camera mainCamera;

    // Start is called before the first frame update
    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }

    // Update is called once per frame
    private void Update()
    {
        var move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * PlayerSpeed);

        if (Input.GetKey(KeyCode.E) || Input.GetButtonDown("Fire1"))
        {
            // GameObject.Find("Main Camera");
            Interact();
        }
    }

    private void Interact()
    {
        RaycastHit[] allHits;
        // Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        Ray ray = mainCamera.ScreenPointToRay(mainCamera.transform.position);   // fixme: se esta disparando hacia abajo a la izquierda
        allHits = Physics.RaycastAll(ray, 100).OrderBy(h => h.distance).ToArray();
        foreach (RaycastHit hit in allHits)
        {
            Debug.Log(hit.transform.name);
            // if (!hit.transform.CompareTag("Player"))
            // {
            if (hit.transform.CompareTag("DoorKnob"))
            {
                if (Vector3.Distance(transform.position, hit.transform.position) <= interactDistance)
                {
                    Debug.Log("-----------------------------------------YESSSSS");
                    exitUi.gameObject.SetActive(true);
                }
            }
            // }
        }
    }
}
