using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController controller;
    private const float PlayerSpeed = 4.0f;

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
    }
}
