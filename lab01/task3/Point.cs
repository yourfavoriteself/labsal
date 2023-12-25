﻿using System;
namespace PointNS
{
	public class Point
	{
		public Point()
		{
		}

		public Point(double x, double y)
		{
			this.x = x;
			this.y = y;
		}

		public double X
		{
			get
			{
				return x;
			}
		}
		public double Y
		{
			get
			{
				return y;
			}
		}

		private double x;
		private double y;
	}
}

