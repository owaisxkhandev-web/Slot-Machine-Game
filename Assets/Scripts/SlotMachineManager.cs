using UnityEngine;

public class SlotMachineManager : MonoBehaviour
{
    [SerializeField] private SlotGenerator Slot; // Used to generate the Target Symbols for the Reels.
    [SerializeField] private CoinManager CoinManager; // Used to manage the Coins and to check if the Player has enough Coins to Spin.
    [SerializeField] private Animator HandleAnimator; // Used to animate the Slot Machine Handle when the Player presses the Spin Button.

    // Reel Controllers for the Left, Right and Centre Reels. These are used to control the Reel Animations and to stop the Reels at the Target Symbol.
    [SerializeField] private ReelController LeftReel; 
    [SerializeField] private ReelController RightReel;
    [SerializeField] private ReelController CentreReel;

    private int[] CurrentResult;


    // Number OF Spins in the Reel Animation before it stops at the Target Symbol.
    int LeftReelSpins = 2; 
    int CenterReelSpins = 4;
    int RightReelSpins = 8;

    public void OnSpinPressed(int SpinCost) // Used by the UI Button SPIN to trigger Spin
    {
        if(SpinCost < CoinManager.CurrentCoin) // Check if the Player has enough Coins to Spin
        {
            CurrentResult = Slot.Generator();
            CoinManager.CurrentCoin -= SpinCost;


            LeftReel.OnStartAnimation(CurrentResult[0], LeftReelSpins);
            CentreReel.OnStartAnimation(CurrentResult[1], CenterReelSpins);
            RightReel.OnStartAnimation(CurrentResult[2], RightReelSpins);

            HandleAnimator.SetBool("Spin",true);
            Invoke("StopHandleAnimation",0.1f); // didn't have time for this, so just using a timer to stop the handle animation after 0.2 seconds.

            Debug.Log(CoinManager.CurrentCoin);
        }
        else if (!CoinManager.CanSpin(SpinCost)) // not have enough coins
        {
            Debug.Log("Not Enough Coins");
        }      
    }
    void StopHandleAnimation()
    {
        HandleAnimator.SetBool("Spin", false);
    }
}
