﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mygame {
	
	public class SSDirector : System.Object {
		private static SSDirector _instance;
		public ISceneController currentSceneController { get; set; }

		public static SSDirector getInstance() {
			if (_instance == null) {
				_instance = new SSDirector ();
			}
			return _instance;
		}
	}

	public interface ISceneController {
		void LoadResources ();
	}

	public interface IUserAction {
		void MoveBoat();
		void CharacterIsClicked(CharacterController characterCtrl);
		void Restart();
	}
}