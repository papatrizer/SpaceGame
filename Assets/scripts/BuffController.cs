using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffController : MonoBehaviour
{
    private List<IBuff> buffs = new List<IBuff>();

    private void Awake()
    {
        GlobalEventManager.BuffTouched.AddListener(GetBuff);
    }

    private IEnumerator WaitForBuffDuration(IBuff buff)
    {

        Debug.Log("бафф корутина началась");
        yield return new WaitForSeconds(buff.Duration);
        FinishBuff(buff);
    }

   private void GetBuff(IBuff buff)
    {
        buffs.Add(buff);
        GlobalEventManager.BuffStarted.Invoke(buff);
        StartCoroutine(WaitForBuffDuration(buff));
    }

    private void FinishBuff(IBuff buff)
    {
        buffs.Remove(buff);
        GlobalEventManager.BuffFinished.Invoke(buff);
    }
}
