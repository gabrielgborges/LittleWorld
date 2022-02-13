using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
	[Header("Renderers")]
	[SerializeField]
	private List<SpriteRenderer> _renderers;
	
	[Header("Animators")]
	[SerializeField]
	private Animator _hairAnimator;
	[SerializeField]
	private Animator _headAnimator;
	[SerializeField]
	private Animator _armsAnimator;
	[SerializeField]
	private Animator _bodyAnimator;
	[SerializeField]
	private Animator _bootsAnimator;

	public void PlayIdle()
	{
		TriggerFullBodyAnimation("Idle");
	}
	
	public void WalkSideways(bool isLeft)
	{
		TriggerFullBodyAnimation("Right");
		foreach (SpriteRenderer spriteRenderer in _renderers)
		{
			spriteRenderer.flipX = isLeft;
		}
	}

	public void WalkForward()
	{
		TriggerFullBodyAnimation("Front");
	}
	
	public void WalkBackward()
	{
		TriggerFullBodyAnimation("Back");
	}

	private void TriggerFullBodyAnimation(string trigger)
	{
		_bodyAnimator.SetTrigger(trigger);

	}
}
