using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFader2 : MonoBehaviour {

    public void FadeIn2(CanvasGroup uiElement)
    {
		if (EffectsEnabler.EnableEffects == true)
		{
			StartCoroutine(FadeCanvasGroup2(uiElement, uiElement.alpha, 1, 1f));
		}

		else
		{
			StartCoroutine(FadeCanvasGroup2(uiElement, uiElement.alpha, 1, 0.0001f));
		}
    }

	public void FadeOut2(CanvasGroup uiElement)
    {
		if (EffectsEnabler.EnableEffects == true)
		{
			StartCoroutine(FadeCanvasGroup2(uiElement, uiElement.alpha, 0, 1f));
		}

		else
		{
			StartCoroutine(FadeCanvasGroup2(uiElement, uiElement.alpha, 0, 0.0001f));
		}
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
