using UnityEngine;

public class DiceAnimatorScript : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void RollDice()
    {
        animator.SetBool("isRolling", true);
    }

    public void StopDice()
    {
        animator.SetBool("isRolling", false);
    }
}
