﻿using System;
namespace NDC.Implementation.ViewController.Base
{
	public class CheckAndBalance
	{
		public Func<bool> Check { get; set; }
		public string Balance { get; set; }
	}
}
