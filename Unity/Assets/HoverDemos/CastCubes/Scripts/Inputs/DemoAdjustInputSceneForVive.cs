﻿using UnityEngine;

namespace HoverDemos.CastCubes.Inputs {

	/*================================================================================================*/
	public class DemoAdjustInputSceneForVive : DemoAdjustInputSceneBase {

		private const string ViveCameraName = "Camera (eye)";


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		protected override bool IsReadyToAdjust() {
			return (GameObject.Find(ViveCameraName) != null);
		}

		/*--------------------------------------------------------------------------------------------*/
		protected override void PerformAdjustments() {
			ConfigureCamera(ViveCameraName);
		}

	}

}
