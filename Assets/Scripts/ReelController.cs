using UnityEngine;

public class ReelController : MonoBehaviour
{
    [SerializeField] private SlotGenerator RNG;
    [SerializeField] private Animator ReelAnimator;

    private int TargetSymbol;
    private int RequiredCycles;
    private int CurrentCycles = 0;
    private bool IsStopped = false;


    public void OnCentre(int SymbolIndex)
    {
        if (IsStopped)
        {
            return;
        }

        if (TargetSymbol == SymbolIndex && CurrentCycles >= RequiredCycles)
        {
            IsStopped = true;

            ReelAnimator.speed = 0;
        }

    }
    public void CycleCompleted()
    {
        Debug.Log("Spin Completed");
        CurrentCycles++;
    }

    public void OnStartAnimation(int TargetSymbol, int RequiredCycles)
    {
        this.TargetSymbol = TargetSymbol;
        this.RequiredCycles = RequiredCycles;

        CurrentCycles = 0;
        IsStopped = false;

        ReelAnimator.speed = 1;
        ReelAnimator.SetBool("IsSpinning", true);
    }
}
