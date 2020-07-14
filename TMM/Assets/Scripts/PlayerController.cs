using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D theRB;
    public float moveSpeed;
    public Animator myAnim;
    public Slider slider;

    public GameObject SliderObject;
    private InteractableController interactingObject;

    public bool interacting = false;

    public static PlayerController instance;

    void Start()
    {
        instance = this;
    }

   
    void Update()
    {
        if (!interacting)
        {
            Movement();
        }
        else
        {
            if (slider.value < 10)
            {
                slider.value += 0.1f;
            }
            else
            {
                slider.value = 0;
                interacting = false;
                SliderObject.SetActive(false);
                interactingObject.GetComponent<InteractableController>().Complete();
            }
        }   
    }

    void Movement()
    {
        theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * moveSpeed;

        myAnim.SetFloat("MoveX", theRB.velocity.x);
        myAnim.SetFloat("MoveY", theRB.velocity.y);

        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == -1 || Input.GetAxisRaw("Vertical") == 1)
        {
            myAnim.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
            myAnim.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
        }
    }

    public void Interact(InteractableController interactingObject)
    {
        interacting = true;
        this.interactingObject = interactingObject;
        SliderObject.SetActive(true);
    }
}
