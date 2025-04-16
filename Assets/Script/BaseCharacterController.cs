using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class BaseCharacter : MonoBehaviour
{
    
    private Vector2 movementInput;
    [SerializeField] float movementSpeed;
    [Range(0,1)][SerializeField] float slowedFactor;
    private bool isSlowed;

    private void Start()
    {
        isSlowed = false;
    }
    public void Movement(CallbackContext ctx)
    {

        movementInput = ctx.ReadValue<Vector2>();
        //var value = ctx.ReadValue<Vector2>();
        //transform.position += new Vector3(ctx.ReadValue<Vector2>().x, ctx.ReadValue<Vector2>().y,0) * Time.deltaTime;
        // Debug.Log($"Context{ctx.ReadValue<Vector2>()}");
    }
    private void FixedUpdate()
    {
        //Var actualMovementSpeed = isSlowed ? movementSpeed * slowedFactor : movementSpeed;
        var actualMovementSpeed = movementSpeed;
        if(isSlowed) actualMovementSpeed *= slowedFactor;
        transform.position += new Vector3(movementInput.x, movementInput.y, 0) * Time.fixedDeltaTime * actualMovementSpeed;
        
    }
   /* public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision with " + collision.gameObject.name);
    }
    public void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("Collision with " + collision.gameObject.name);
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Collision with " + collision.gameObject.name);
    }*/
    public void OnTriggerEnter2D(Collider2D col)
    {
        
    }
    public void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Swamp")) 
        {
            isSlowed = true;    
        }
    }
    public void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Swamp"))
        {
            isSlowed = false;
        }
    }
}
