using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class BaseCharacter : MonoBehaviour
{
    private Vector2 movementInput;
    [SerializeField] float movementSpeed;
    public void Movement(CallbackContext ctx)
    {

        movementInput = ctx.ReadValue<Vector2>();


        //var value = ctx.ReadValue<Vector2>();
        //transform.position += new Vector3(ctx.ReadValue<Vector2>().x, ctx.ReadValue<Vector2>().y,0) * Time.deltaTime;
        // Debug.Log($"Context{ctx.ReadValue<Vector2>()}");
    }

    private void Update()
    {
        transform.position += new Vector3(movementInput.x, movementInput.y, 0) * Time.deltaTime * movementSpeed;

    }
}
