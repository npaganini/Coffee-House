using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController controller;
    public ExitMenu exitUi;
    private const float PlayerSpeed = 4f;
    private const float InteractDistance = 4f;
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
            Interact();
        }
    }

    private void Interact()
    {
        RaycastHit hit;
        if (Physics.Raycast(mainCamera.transform.position, mainCamera.transform.forward, out hit, InteractDistance))
        {
            Debug.Log("Me choqué primero con: " + hit.transform.name);
            if (hit.transform.CompareTag("DoorKnob"))
            {
                exitUi.gameObject.SetActive(true);
            }
        }
    }
}
