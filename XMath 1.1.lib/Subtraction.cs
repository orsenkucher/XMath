﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMath_1._1.lib
{
	public class Subtraction : Operation
	{
		public Subtraction()
		{
			Sign = '−';
		}

		protected override int ProcessOperation(int a, int b)
		{
			return a - b;
		}
	}
}
