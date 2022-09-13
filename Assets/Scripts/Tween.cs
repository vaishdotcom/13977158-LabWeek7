using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tween 
{
   public Transform Target { get; private set; }
   public Vector3 StartPos { get; private  set; }
   public Vector3 EndPos { get; private set; }
   public float StartTime { get; private set; }
   public float Duration { get; private set; }

   public Tween ( Transform T, Vector3 SP, Vector3 EP, float ST, float D)
   {
        this.Target = T;
        this.StartPos = SP;
        this.EndPos = EP;
        this.StartTime = ST;
        this.Duration = D;
   }
}
