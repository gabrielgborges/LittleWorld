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

	public void SetUpCosmetic(CosmeticData cosmeticData)
	{
		switch (cosmeticData.CosmeticType)
		{
			case CosmeticType.HAIR:
				_hairAnimator.runtimeAnimatorController = cosmeticData.Animations;
				break;
			case CosmeticType.HEAD:
				_hairAnimator.runtimeAnimatorController = cosmeticData.Animations;
				break;
			case CosmeticType.ARMS:
				_hairAnimator.runtimeAnimatorController = cosmeticData.Animations;
				break;
			case CosmeticType.BODY:
				_hairAnimator.runtimeAnimatorController = cosmeticData.Animations;
				break;
			case CosmeticType.BOOTS:
				_hairAnimator.runtimeAnimatorController = cosmeticData.Animations;
				break;
		}
	}
	
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
		TriggerFullBodyAnimation("Back");
	}
	
	public void WalkBackward()
	{
		TriggerFullBodyAnimation("Front");
	}

	private void TriggerFullBodyAnimation(string trigger)
	{
		_armsAnimator.SetTrigger(trigger);
		_bootsAnimator.SetTrigger(trigger);
		_bodyAnimator.SetTrigger(trigger);
		_hairAnimator.SetTrigger(trigger);
		_headAnimator.SetTrigger(trigger);
	}
}
