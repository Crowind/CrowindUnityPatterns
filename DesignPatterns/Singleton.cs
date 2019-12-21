﻿using System;
using UnityEngine;

namespace DesignPatterns {

	public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour {

		public static T instance;

		public virtual void Awake() {
			if (!instance) {
				if (typeof(T) != GetType()) {
					Destroy(gameObject);
					throw new Exception("Singleton instance type mismatch!");
				}
				instance = this as T;
			}
			else {
				Destroy(gameObject);
			}
		}
	}

}