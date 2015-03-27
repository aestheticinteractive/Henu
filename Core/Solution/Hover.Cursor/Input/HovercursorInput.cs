﻿using System;
using Hover.Common.Input;
using Hover.Cursor.State;
using UnityEngine;

namespace Hover.Cursor.Input {

	/*================================================================================================*/
	public abstract class HovercursorInput : MonoBehaviour, IHovercursorInput {

		public bool IsEnabled { get; set; }
		public bool IsFailure { get; set; }

		protected Func<CursorType, PlaneData[]> vPlaneProviderFunc;


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		protected HovercursorInput() {
			IsEnabled = true;
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public void SetPlaneProvider(Func<CursorType, PlaneData[]> pProvider) {
			vPlaneProviderFunc = pProvider;
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public abstract void UpdateInput();

		/*--------------------------------------------------------------------------------------------*/
		public abstract IInputCursor GetCursor(CursorType pType);

	}

}


