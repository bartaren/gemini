using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFader3 : MonoBehaviour {

    public void FadeIn2(CanvasGroup uiElement)
    {
        StartCoroutine(FadeCanvasGroup2(uiElement, uiElement.alpha, 1, 0.5f));
    }

	public void FadeOut2(CanvasGroup uiElement)
    {
        StartCoroutine(FadeCanvasGroup2(uiElement, uiElement.alpha, 0, 0.5f));
    }

    public IEnumerator FadeCanvasGroup2(CanvasGroup cg, float start, float end, float lerpTime = 0)
	{
		float _timeStartedLerping = Time.time;
		float timeSinceStarted = Time.time - _timeStartedLerping;
		float percentageComplete = timeSinceStarted / lerpTime;

		while (true)
		{
			timeSinceStarted = Time.time - _timeStartedLerping;
			percentageComplete = timeSinceStarted / lerpTime;

			float currentValue = Mathf.Lerp(start, end, percentageComplete);

            cg.alpha = currentValue;

            if (percentageComplete >= 1) break;

			yield return new WaitForFixedUpdate();
		}

        Debug.Log("done");
	}
}
