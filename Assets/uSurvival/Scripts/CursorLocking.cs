﻿using UnityEngine;

public class CursorLocking : MonoBehaviour
{
    public GameObject[] windowsThatUnlockCursor;

    bool AnyUnlockWindowActive()
    {
        // check manually. Linq.Any() is HEAVY(!) on GC and performance
        foreach (GameObject go in windowsThatUnlockCursor)
            if (go.activeSelf)
                return true;
        return false;
    }

    void Update()
    {
        Cursor.lockState = AnyUnlockWindowActive()
                           ? CursorLockMode.None
                           : CursorLockMode.Locked;

        // OSX auto hides cursor while locked, Windows doesn't so do it manually
        Cursor.visible = Cursor.lockState != CursorLockMode.Locked;
    }
}
