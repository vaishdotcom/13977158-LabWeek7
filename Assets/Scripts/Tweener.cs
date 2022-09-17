using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweener : MonoBehaviour
{
    // private Tween activeTween;
    private List<Tween> activeTweeners;
    // Start is called before the first frame update
    void Start()
    {
        activeTweeners = new List<Tween>();
    }

    // Update is called once per frame
    void Update()
    {
      // if (!(activeTween==null) && (double)Vector3.Distance(activeTween.Target.position, activeTween.EndPos) > 0.1)
      //  {
      //      float time = Mathf.Pow((Time.time - activeTween.StartTime) / activeTween.Duration, 3.0f);
      //      activeTween.Target.position = Vector3.Lerp(activeTween.StartPos, activeTween.EndPos, time);
      //  }
      //  else
      //  {
      //      if(!(activeTween == null))
      //      {
      //          activeTween.Target.position = activeTween.EndPos;
      //          activeTween = null;
      //      }
      //  }

        for(int i =0; i< activeTweeners.Count; i++)
        {
            Tween activeTween = this.activeTweeners[i];
            if ((double)Vector3.Distance(activeTween.Target.position, activeTween.EndPos) > 0.1)
            {
                float time = Mathf.Pow((Time.time - activeTween.StartTime) / activeTween.Duration, 3f);
                activeTween.Target.position = Vector3.Lerp(activeTween.StartPos, activeTween.EndPos, time);
            }
            else
            {
                activeTween.Target.position = activeTween.EndPos;
                this.activeTweeners.RemoveAt(i);
            }
        }
    }

    //public void AddTween(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration)
    //{
    //    if(activeTween == null)
    //    {
    //        activeTween = new Tween(targetObject, startPos, endPos, Time.time, duration);
    //    }
    //}

    public bool AddTween(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration)
    {
        if (this.TweenExists(targetObject))
        { 
            return false; 
        }

        this.activeTweeners.Add(new Tween(targetObject, startPos, endPos, Time.time, duration));
        return true;
    }

    public bool TweenExists(Transform target)
    {
        for (int i = 0; i < activeTweeners.Count; i++)
        {
            if ((Object)activeTweeners[i].Target.transform == (Object)target)
                return true;
        }
        return false;
    }
}
