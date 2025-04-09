using UnityEngine;

public class DragaoScript : MonoBehaviour
{

    [SerializeField]
    private Animator animator;

    public void Update()
    {
        float eixoH = Input.GetAxis("Horizontal");
        animator.SetFloat("EixoHor", eixoH);

        if(eixoH < 0)
        {
            animator.gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
        else if(eixoH > 0)
        {
            animator.gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }

    }



}
