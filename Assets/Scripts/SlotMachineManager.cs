using UnityEngine;

public class SlotMachineManager : MonoBehaviour
{
    [SerializeField] private bool Spin;
    [SerializeField] private SlotGenerator Slot;

    [SerializeField] private ReelController LeftReel;
    [SerializeField] private ReelController RightReel;
    [SerializeField] private ReelController CentreReel;

    private int[] CurrentResult;
  
    public void OnSpinPressed()
    {
        CurrentResult = Slot.Generator();

        LeftReel.OnStartAnimation(CurrentResult[0], 1);
        CentreReel.OnStartAnimation(CurrentResult[1], 3);
        RightReel.OnStartAnimation(CurrentResult[2], 7);
    }
}
