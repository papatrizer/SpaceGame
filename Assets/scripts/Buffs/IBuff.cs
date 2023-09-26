using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBuff 
{
    int Duration { get; set; }
    EBuff BuffType { get; }
}
