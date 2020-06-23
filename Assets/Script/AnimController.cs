using UnityEngine;

public class AnimController : MonoBehaviour
{
    [SerializeField]
    Animator Animator;
    [SerializeField]
    int animNum;

    [SerializeField]
    float waitTime;
    float count;

    void FixedUpdate()
    {
        count += Time.deltaTime;
        if (count > waitTime)
        {
            ChangeAnim();
        }
    }
    public void ChangeAnim()
    {
        Animator.SetInteger("KeyNumber", Random.Range(0, animNum));
        count = 0;
    }
}