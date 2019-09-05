using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour {


    
    private bool paused = true;

    //Used to check when the game is unpausable
    private bool inTimed = false;

    public void Unpause()
    {
        if (paused)
            paused = false;
    }

    public void Pause()
    {
        //if unpaused and no
        if (!paused && !inTimed)
            paused = true;
    }

    public bool IsPaused()
    {
        if (paused)
            return true;
        else
            return false;
    }

    public IEnumerator TimedUnpause(float time)
    {
        inTimed = true;
        paused = false;
        yield return new WaitForSeconds(time);
        paused = true;
        inTimed = false;
    } 

    


}
