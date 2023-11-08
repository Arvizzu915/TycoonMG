using UnityEngine;

public class fadeinout : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        

    }

    public void FadeToLevel()
    {
        animator.SetTrigger("fadeout");
    }
}
