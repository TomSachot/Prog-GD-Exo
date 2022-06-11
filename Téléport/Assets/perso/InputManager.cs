using UnityEngine;

public class InputManager : MonoBehaviour
{
    public KeyCode up, down, left, right, jump;
    public MovementPerso movement;
    public void Update()
    {
        if (Input.GetKey(up))
        {
            movement.Move(Vector3.forward);
        }
        if (Input.GetKey(down))
        {
            movement.Move(Vector3.back);
        }
        if (Input.GetKey(left))
        {
            movement.Move(Vector3.left);
        }
        if (Input.GetKey(right))
        {
            movement.Move(Vector3.right);
        }
        if (Input.GetKeyDown(jump))
        {
            movement.Jump();
        }
    }
}